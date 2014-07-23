using System;
using System.Collections.Generic;

using UniversalEditor;
using UniversalEditor.ObjectModels.Multimedia3D.Model;
using UniversalEditor.ObjectModels.Multimedia3D.Motion;

using Caltron;
using Caltron.Input.Keyboard;

using Concertroid.Renderer.Controls;
using Concertroid.Renderer.ChildWindows;

namespace Concertroid.Renderer
{
	public class MainWindow : Window
	{
		public MainWindow()
		{
			if (Properties.Resources.MainIcon != null)
			{
				base.IconHandle = Properties.Resources.MainIcon.Handle;
			}
			// base.Size = new Dimension2D(640, 480);
			base.Text = "Concertroid Renderer - v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " - " + System.Environment.OSVersion.VersionString;
			// base.AlwaysRender = true;

			ctlModel = new ModelRendererControl();
			ctlModel.Model = new ModelObjectModel();
			ctlModel.Position = new PositionVector3(0, -1, 0);
			ctlModel.Size = new Dimension3D(Width, Height, 0);

			ctlSplashScreen = new SplashScreenControl();
			ctlSplashScreen.Position = new PositionVector2((base.Size.Width - ctlSplashScreen.Size.Width) / 2, (base.Size.Height - ctlSplashScreen.Size.Height) / 2);
			Controls.Add(ctlSplashScreen);

			ctlWatermark = new WatermarkControl();
			ctlWatermark.Position = new PositionVector2(Width - 200, 32);
			ctlWatermark.Size = new Dimension2D(164, 26);
			ctlWatermark.Visible = false;
			Controls.Add(ctlWatermark);
			
			wndMotionTest = new MotionTestChildWindow();
			wndSetDebugCamera = new SetDebugCameraChildWindow();
			Controls.Add(ctlModel);
			Controls.Add(wndMotionTest);
			Controls.Add(wndSetDebugCamera);

			if (mvarJoypad != null) mvarJoypad.ButtonPressed += mvarJoypad_ButtonPressed;
		}

		private Joypad.Device mvarJoypad = Joypad.Device.GetDefaultDevice();

		private void mvarJoypad_ButtonPressed(object sender, Joypad.ButtonEventArgs e)
		{
			Joypad.SaturnJoypadButton button = (Joypad.SaturnJoypadButton)e.Button;
			if ((Joypad.SaturnJoypadButton)(mvarJoypad.Buttons) == (Joypad.SaturnJoypadButton.TriggerLeft | Joypad.SaturnJoypadButton.C))
			{
				DebugMode = !DebugMode;
			}
			else if ((Joypad.SaturnJoypadButton)mvarJoypad.Buttons == Joypad.SaturnJoypadButton.C)
			{
				FullScreen = !FullScreen;
			}
		}
		private bool boneOnly = false;
		private bool mvarDebugMode = false;
		public bool DebugMode
		{
			get { return mvarDebugMode; }
			set
			{
				mvarDebugMode = value;

				wndMotionTest.Visible = mvarDebugMode;
				wndSetDebugCamera.Visible = mvarDebugMode;
				ctlWatermark.Visible = (!mvarDebugMode && mvarModelLoaded);
			}
		}

		private bool mvarModelLoaded = false;

		private WatermarkControl ctlWatermark = null;

		private System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
		
		private string mvarModelPath = Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar.ToString() + "Models";
		private string mvarPosePath = Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar.ToString() + "Pose";
		private string mvarMotionPath = Environment.CurrentDirectory + System.IO.Path.DirectorySeparatorChar.ToString() + "Motion";

		private MotionTestChildWindow wndMotionTest = null;
		private SetDebugCameraChildWindow wndSetDebugCamera = null;
		private ModelRendererControl ctlModel = null;
		private SplashScreenControl ctlSplashScreen = null;

		protected override void OnKeyDown(KeyboardEventArgs e)
		{
			base.OnKeyDown(e);

			switch (e.Keys)
			{
				case KeyboardKey.Z:
				{
					Program.AudioManager.FadeOut();
					break;
				}
				case KeyboardKey.B:
					boneOnly = !boneOnly;
					break;
				case KeyboardKey.D:
					{
						if (((e.ModifierKeys & KeyboardModifierKey.Alt) == KeyboardModifierKey.Alt)
							&& ((e.ModifierKeys & KeyboardModifierKey.Shift) == KeyboardModifierKey.Shift))
						{
							// create a window on top of the frame
							DebugMode = !DebugMode;
						}
						break;
					}
				/*
				case KeyboardKey.W:
					ty -= 0.1;
					break;
				case KeyboardKey.S:
					ty += 0.1;
					break;
				case KeyboardKey.A:
					tx += 0.1;
					break;
				case KeyboardKey.D:
					tx -= 0.1;
					break;
				case KeyboardKey.Z:
					tz -= 0.1;
					break;
				case KeyboardKey.X:
					tz+= 0.1;
					break;
				*/
				case KeyboardKey.L:
					ToggleLighting(((e.ModifierKeys & KeyboardModifierKey.Shift) == KeyboardModifierKey.Shift));
					break;
				case KeyboardKey.R:
					{
						if (System.Windows.Forms.MessageBox.Show("Reset all bone positions to their original values?", "Reset", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
						{
							ctlModel.Model.Reset();

							rot = 0;
						}
						break;
					}
				case KeyboardKey.O:
					{
						// string FileName = @"/media/FreeAgent-1TB/Profiles/Mike Becker/Applications/MikuMikuDance/v7.39/UserFile/Model/kio/kio_miku_20100901/kio_miku_20100901.pmd";
						ofd.Title = "Load Model Data";
						ofd.Filter = UniversalEditor.Common.Dialog.GetCommonDialogFilter(ctlModel.Model.MakeReference());
						ofd.RestoreDirectory = false;

						if (mvarModelPath != null && System.IO.Directory.Exists(mvarModelPath))
						{
							ofd.InitialDirectory = mvarModelPath;
						}

						if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							mvarModelPath = System.IO.Path.GetDirectoryName(ofd.FileName);

#if ENABLE_TRANSITIONS
						if (tTransitionThread != null)
						{
							// wait till we finish transitioning?
							tTransitionThread.Abort();
							tTransitionThread = null;
						}

						mvarTransitioningModel = UniversalEditor.Common.Reflection.GetAvailableObjectModel<UniversalEditor.ObjectModels.Multimedia3D.Model.ModelObjectModel>(ofd.FileName);
						mvarTransitioningModel.IgnoreEdgeFlag = true; // set so the model always is affected by lighting

						tTransitionThread = new System.Threading.Thread(tTransitionThread_ThreadStart);
						tTransitionThread.Start();
#else
							DisplayModelImmediate(ofd.FileName);
#endif
						}
						break;
					}
				case KeyboardKey.M:
					{
						if (tMotionThread != null)
						{
							tMotionThread.Abort();
							tMotionThread = null;

							mvarCurrentMotion = null;
						}
						else
						{
							// string FileName = @"/media/FreeAgent-1TB/Profiles/Mike Becker/Applications/MikuMikuDance/v7.39/UserFile/Model/kio/kio_miku_20100901/kio_miku_20100901.pmd";
							UniversalEditor.ObjectModels.Multimedia3D.Motion.MotionObjectModel motion = new UniversalEditor.ObjectModels.Multimedia3D.Motion.MotionObjectModel();
							ofd.Title = "Load Motion Data";
							ofd.Filter = UniversalEditor.Common.Dialog.GetCommonDialogFilter(motion.MakeReference());
							ofd.RestoreDirectory = false;

							if (mvarMotionPath != null && System.IO.Directory.Exists(mvarMotionPath))
							{
								ofd.InitialDirectory = mvarMotionPath;
							}

							if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
							{
								mvarMotionPath = System.IO.Path.GetDirectoryName(ofd.FileName);

								UniversalEditor.Common.Reflection.GetAvailableObjectModel<UniversalEditor.ObjectModels.Multimedia3D.Motion.MotionObjectModel>(ofd.FileName, ref motion);

								mvarCurrentMotion = motion;

								tMotionThread = new System.Threading.Thread(tMotionThread_ThreadStart);
								tMotionThread.Start();
							}
						}
						break;
					}
				case KeyboardKey.P:
					{
						// string FileName = @"/media/FreeAgent-1TB/Profiles/Mike Becker/Applications/MikuMikuDance/v7.39/UserFile/Model/kio/kio_miku_20100901/kio_miku_20100901.pmd";
						UniversalEditor.ObjectModels.Multimedia3D.Pose.PoseObjectModel pose = new UniversalEditor.ObjectModels.Multimedia3D.Pose.PoseObjectModel();
						ofd.Title = "Load Pose Data";
						ofd.Filter = UniversalEditor.Common.Dialog.GetCommonDialogFilter(pose.MakeReference());
						ofd.RestoreDirectory = false;

						if (mvarPosePath != null && System.IO.Directory.Exists(mvarPosePath))
						{
							ofd.InitialDirectory = mvarPosePath;
						}

						if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							mvarPosePath = System.IO.Path.GetDirectoryName(ofd.FileName);

							UniversalEditor.Common.Reflection.GetAvailableObjectModel<UniversalEditor.ObjectModels.Multimedia3D.Pose.PoseObjectModel>(ofd.FileName, ref pose);
							ctlModel.Model.ApplyPose(pose);
						}
						break;
					}
				case KeyboardKey.Space:
					{
						dorotate = !dorotate;
						break;
					}
				case KeyboardKey.Enter:
					{
						if ((e.ModifierKeys & KeyboardModifierKey.Alt) == KeyboardModifierKey.Alt)
						{
							FullScreen = !FullScreen;
						}
						break;
					}
			}
			Refresh();
		}

		private Dictionary<string, ModelObjectModel> modelDictionary = new Dictionary<string, ModelObjectModel>();
		private void RemoveModel()
		{
			ctlModel.Model = null;

			ctlSplashScreen.Visible = true;
			ctlWatermark.Visible = false;
			// Refresh();
		}
		private void DisplayModelImmediate(string FileName)
		{
			mvarModelLoaded = true;
			ctlSplashScreen.Visible = false;
			ctlWatermark.Visible = true;

			if (modelDictionary.ContainsKey(FileName))
			{
				ctlModel.Model = modelDictionary[FileName];
				ctlModel.Model.IgnoreEdgeFlag = true; // set so the model always is affected by lighting
			}
			else
			{
				ctlModel.Model = UniversalEditor.Common.Reflection.GetAvailableObjectModel<UniversalEditor.ObjectModels.Multimedia3D.Model.ModelObjectModel>(ofd.FileName);
				ctlModel.Model.IgnoreEdgeFlag = true; // set so the model always is affected by lighting

				Caltron.Controls.Controls2D.ComboBox cboBone = (wndMotionTest.Controls["cboBone"] as Caltron.Controls.Controls2D.ComboBox);
				cboBone.Items.Clear();
				for (int i = 0; i < ctlModel.Model.Bones.Count; i++)
				{
					string name = ctlModel.Model.Bones[i].Name;
					if (ctlModel.Model.StringTable.ContainsKey(1033))
					{
						// name = ctlModel.Model.StringTable[1033].BoneNames[i];
					}
					cboBone.Items.Add(name, ctlModel.Model.Bones[i]);
				}
			}
		}

		private System.Timers.Timer _timerText = new System.Timers.Timer(500);

		private Timer tmrFlash = new Timer(1000);

		protected override void OnCreated()
		{
			base.OnCreated();

			dorotate = false;

			Caltron.Internal.OpenGL.Methods.glMatrixMode(MatrixMode.Projection);
			Caltron.Internal.OpenGL.Methods.glLoadIdentity();
			// Caltron.Internal.GLU.Methods.gluPerspective(45.0, Size.Width / Size.Height, 0.0, 45.0);

			// 

			// do not enable blending unless you want seams between your tris!
			// Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.Blending);
			// Caltron.Internal.OpenGL.Methods.glBlendFunc(Caltron.Internal.OpenGL.Constants.GLBlendFunc.SourceAlpha, Caltron.Internal.OpenGL.Constants.GLBlendFunc.OneMinusSourceAlpha);

			// 
			// 

			World.Lights[0].Position = new PositionVector4(0.45f, 1.45f, -4.0f, 0.0f);
			World.Lights[0].DiffuseColor = ApplicationSettings.LightOnDiffuseColor;
			World.Lights[0].AmbientColor = ApplicationSettings.LightOnAmbientColor;
			World.Lights[0].SpecularColor = ApplicationSettings.LightOnSpecularColor;
			World.Lights[0].Enabled = true;



			fInterpolateLightBy[0][0] = (float)(ApplicationSettings.LightOnAmbientColor.Red - ApplicationSettings.LightOffAmbientColor.Red);
			fInterpolateLightBy[0][1] = (float)(ApplicationSettings.LightOnAmbientColor.Green - ApplicationSettings.LightOffAmbientColor.Green);
			fInterpolateLightBy[0][2] = (float)(ApplicationSettings.LightOnAmbientColor.Blue - ApplicationSettings.LightOffAmbientColor.Blue);
			fInterpolateLightBy[1][0] = (float)(ApplicationSettings.LightOnDiffuseColor.Red - ApplicationSettings.LightOffDiffuseColor.Red);
			fInterpolateLightBy[1][1] = (float)(ApplicationSettings.LightOnDiffuseColor.Green - ApplicationSettings.LightOffDiffuseColor.Green);
			fInterpolateLightBy[1][2] = (float)(ApplicationSettings.LightOnDiffuseColor.Blue - ApplicationSettings.LightOffDiffuseColor.Blue);
			fInterpolateLightBy[2][0] = (float)(ApplicationSettings.LightOnSpecularColor.Red - ApplicationSettings.LightOffSpecularColor.Red);
			fInterpolateLightBy[2][1] = (float)(ApplicationSettings.LightOnSpecularColor.Green - ApplicationSettings.LightOffSpecularColor.Green);
			fInterpolateLightBy[2][2] = (float)(ApplicationSettings.LightOnSpecularColor.Blue - ApplicationSettings.LightOffSpecularColor.Blue);

			_timerText.Elapsed += _timerText_Elapsed;
			_timerText.Start();

			tmrFlash.Tick += tmrFlash_Tick;
			tmrFlash.Enabled = true;
		}

		void tmrFlash_Tick(object sender, EventArgs e)
		{
			bFlash = !bFlash;
			Refresh();
		}
		protected override void OnBeforeRender(BeforeRenderEventArgs e)
		{
			base.OnBeforeRender(e);
			if (mvarDebugMode)
			{
				BackgroundColor = Colors.DarkGray;
			}
			else
			{
				BackgroundColor = Colors.Black;
			}
		}
		protected override void OnAfterRender(RenderEventArgs e)
		{
			base.OnAfterRender(e);
			
			e.Canvas.Color = Color.FromRGBA (255, 255, 0, 255);
			e.Canvas.DrawText ("Hello!", 0, 0, 1.0, 1.0f, Program.LargeFont);
			
			return;

			if (FullScreen)
			{
				Caltron.Internal.OpenGL.Methods.glTranslated(0, -28, 0);
			}
			else
			{
				Caltron.Internal.OpenGL.Methods.glTranslated(0, 8, 0);
			}

			if (mvarDebugMode)
			{
				bool lightmode = e.Canvas.EnableLighting;
				e.Canvas.EnableLighting = false;
				e.Canvas.Color = Colors.Red;
				e.Canvas.DrawText("PAUSED", 16, 16, 0.1f, 1.0f, Program.LargeFont);
				e.Canvas.EnableLighting = lightmode;
			}
			else
			{
				e.Canvas.Color = Colors.DarkGray;
				e.Canvas.DrawText("KEYCHIP ID: ", (Width - 320), Height - 48, 0.1, 1.0f, Program.LargeFont);
				e.Canvas.DrawText("MAIN ID:", (Width - 320), Height - 24, 0.1, 1.0f, Program.LargeFont);

				if (Program.KeychipID == null)
				{
					if (bFlash)
					{
						e.Canvas.Color = Colors.Red;
					}
					else
					{
						e.Canvas.Color = Colors.DarkGray;
					}
					e.Canvas.DrawText("(NOT PRESENT)", (Width - 160), Height - 48, 0.1, 1.0f, Program.LargeFont);
				}
				else
				{
					e.Canvas.DrawText(Program.KeychipID, (Width - 160), Height - 48, 0.1, 1.0f, Program.LargeFont);
				}

				e.Canvas.Color = Colors.DarkGray;
				e.Canvas.DrawText(Program.MainID, (Width - 160), Height - 24, 0.1, 1.0f, Program.LargeFont);
			}
		}

		private bool bFlash = false;

		void _timerText_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			/*
			string text = "Concertroid: render in " + m_dts.TotalMilliseconds + "ms";
			if (mvarCurrentMotion != null) text += " [" + mvarCurrentMotionFrame.ToString() + "/" + mvarCurrentMotion.Frames.Count.ToString() + "]";
			Text = text;
			*/
		}

		protected override void OnResizing(ResizeEventArgs e)
		{
			base.OnResizing(e);

			ctlWatermark.Position = new PositionVector2(Width - 200, 32);
			ctlSplashScreen.Position = new PositionVector2((Width - ctlSplashScreen.Size.Width) / 2, (Height - ctlSplashScreen.Size.Height) / 2);
			ctlModel.Size = new Dimension3D(Width, Height, 0);
		}
		
		private bool dorotate = true;
		private double rot = 0.0;

		#region Lighting
		private bool m_LightingEnabled = true;
		private void ToggleLighting()
		{
			ToggleLighting(false);
		}
		private void ToggleLighting(bool immediate)
		{
			if (m_LightingEnabled)
			{
				DisableLighting(immediate);
			}
			else
			{
				EnableLighting(immediate);
			}
		}

		private void DisableLighting()
		{
			DisableLighting(false);
		}
		private void DisableLighting(bool immediate)
		{
			m_LightingEnabled = false;

			if (!immediate)
			{
				if (tLightingThread != null)
				{
					tLightingThread.Abort();
					tLightingThread = null;
				}
				tLightingThread = new System.Threading.Thread(tLightingThread_ThreadStart);
				tLightingThread.Start();
			}
			else
			{
				World.Lights[0].AmbientColor = ApplicationSettings.LightOffAmbientColor;
				World.Lights[0].DiffuseColor = ApplicationSettings.LightOffDiffuseColor;
				World.Lights[0].SpecularColor = ApplicationSettings.LightOffSpecularColor;
			}
		}
		private void EnableLighting()
		{
			EnableLighting(false);
		}
		private void EnableLighting(bool immediate)
		{
			m_LightingEnabled = true;
			if (!immediate)
			{
				if (tLightingThread != null)
				{
					tLightingThread.Abort();
					tLightingThread = null;
				}
				tLightingThread = new System.Threading.Thread(tLightingThread_ThreadStart);
				tLightingThread.Start();
			}
			else
			{
				World.Lights[0].AmbientColor = ApplicationSettings.LightOnAmbientColor;
				World.Lights[0].DiffuseColor = ApplicationSettings.LightOnDiffuseColor;
				World.Lights[0].SpecularColor = ApplicationSettings.LightOnSpecularColor;
			}
		}

		private bool mvarUpdatingLight = false;
		private System.Threading.Thread tLightingThread = null;
		private float fInterpolateLight = 0.0f;
		private float[][] fInterpolateLightBy = new float[][]
		{
			new float[3],
			new float[3],
			new float[3]
		};

		private void tLightingThread_ThreadStart()
		{
			if (m_LightingEnabled)
			{
				mvarUpdatingLight = true;

				while (fInterpolateLight <= 1.0f)
				{
					World.Lights[0].AmbientColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[0][0], fInterpolateLight * fInterpolateLightBy[0][1], fInterpolateLight * fInterpolateLightBy[0][2], 1.0);
					World.Lights[0].DiffuseColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[1][0], fInterpolateLight * fInterpolateLightBy[1][1], fInterpolateLight * fInterpolateLightBy[1][2], 1.0);
					World.Lights[0].SpecularColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[2][0], fInterpolateLight * fInterpolateLightBy[2][1], fInterpolateLight * fInterpolateLightBy[2][2], 1.0);
					fInterpolateLight += 0.05f;
					System.Threading.Thread.Sleep(50);
				}
				EnableLighting(true);

				System.Threading.Thread.Sleep(100);
				mvarUpdatingLight = false;
				fInterpolateLight = 1.0f;
			}
			else
			{
				mvarUpdatingLight = true;

				while (fInterpolateLight >= 0.0f)
				{
					World.Lights[0].AmbientColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[0][0], fInterpolateLight * fInterpolateLightBy[0][1], fInterpolateLight * fInterpolateLightBy[0][2], 1.0);
					World.Lights[0].DiffuseColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[1][0], fInterpolateLight * fInterpolateLightBy[1][1], fInterpolateLight * fInterpolateLightBy[1][2], 1.0);
					World.Lights[0].SpecularColor = Color.FromRGBA(fInterpolateLight * fInterpolateLightBy[2][0], fInterpolateLight * fInterpolateLightBy[2][1], fInterpolateLight * fInterpolateLightBy[2][2], 1.0);
					fInterpolateLight -= 0.05f;
					System.Threading.Thread.Sleep(50);
				}
				DisableLighting(true);

				System.Threading.Thread.Sleep(100);
				mvarUpdatingLight = false;
				fInterpolateLight = 0.0f;
			}
		}
		#endregion

		private TimeSpan m_dts = TimeSpan.Zero;
		private MotionObjectModel mvarCurrentMotion = null;

		private int motionThreadWaitTimes = 0;
		private const int MOTION_THREAD_MAX_WAIT_TIMES = 3;

		private System.Threading.Thread tMotionThread = null;
		private void tMotionThread_ThreadStart()
		{
			while ((mvarCurrentMotion == null) || (ctlModel.Model == null))
			{
				Console.WriteLine("Motion thread started on a null motion or model file, waiting...");
				System.Threading.Thread.Sleep(200);

				motionThreadWaitTimes++;
				if (motionThreadWaitTimes == MOTION_THREAD_MAX_WAIT_TIMES)
				{
					Console.WriteLine("Motion thread timed out while waiting on a null motion or model file, aborting...");
					return;
				}
			}

			double fps = 30.0;
			double fpms = fps / 1000;
			int frameTime = (int)(1 / fpms);

			int currentKeyframeIndex = 1;

			uint totalFrameCount = mvarCurrentMotion.Frames[mvarCurrentMotion.Frames.Count - 1].Index;
			// regroup the keyframe data by bone name instead of by frame number??

			List<string> lastUpdatedBoneNames = new List<string>();
			
			for (uint i = 1; i < totalFrameCount; i++)
			{
				ctlModel.Model.BeginUpdate();

				// next frame we hit, we have to determine whether the bone was update
				// or not. if it isn't , we interpolate...

				if (i <= mvarCurrentMotion.Frames[currentKeyframeIndex].Index)
				{
					// no need to advance the frame just yet

					foreach (MotionAction action in mvarCurrentMotion.Frames[currentKeyframeIndex].Actions)
					{
						if (action is MotionBoneRepositionAction)
						{
							MotionBoneRepositionAction repos = (action as MotionBoneRepositionAction);
							if (true) // (lastUpdatedBoneNames.Contains(repos.BoneName))
							{
								// the bone was updated last time, so no need to interpolate
								// just update the position like usual
								ctlModel.Model.Bones[repos.BoneName].Position = repos.Position;
								ctlModel.Model.Bones[repos.BoneName].Rotation = repos.Rotation;
							}
							else
							{
								// continue with the interpolation of the bone
								
								// we need to figure out what position the bone will be in
								// next, and store that information for later
								/*
								if (repos.NextInterpolatedBonePosition == null)
								{
									// repos.NextInterpolatedBoneIndex

									// TODO: find the next keyframe position for this bone
								}
								*/

								lastUpdatedBoneNames.Add(repos.BoneName);
							}
						}
					}

				}
				else
				{
					// current frame is greater than last keyframe index, advance the keyframe
					// and clear out the list of last updated bone names
					lastUpdatedBoneNames.Clear();

					currentKeyframeIndex++;
				}




				ctlModel.Model.EndUpdate();

				System.Threading.Thread.Sleep(frameTime);
			}
		}

#if ENABLE_TRANSITIONS
		private System.Threading.Thread tTransitionThread = null;
		public void tTransitionThread_ThreadStart()
		{
			// Transition between the model

			// Before displaying the model, the model must be posed in the same way as the previous model
			// to make it look good ;)


			foreach (ModelMaterial mat in mvarCurrentModel.Materials)
			{
				mat.AmbientColor = System.Drawing.Color.White;
			}

			Dictionary<ModelMaterial, System.Drawing.Color> prevColors = new Dictionary<ModelMaterial, System.Drawing.Color>();
			foreach (ModelMaterial mat in mvarTransitioningModel.Materials)
			{
				prevColors.Add(mat, mat.AmbientColor);
				mat.AmbientColor = System.Drawing.Color.White;
			}

			double a = 0.1;

			bool done = false;
			while (!done)
			{
				foreach (ModelMaterial mat in mvarTransitioningModel.Materials)
				{
					System.Drawing.Color color = System.Drawing.Color.FromRGBA((int)(a * prevColors[mat].R), (int)(a * prevColors[mat].G), (int)(a * prevColors[mat].B));
					mat.AmbientColor = color;

					System.Threading.Thread.Sleep(50);
					a += 0.1;

					if (color == prevColors[mat] || a >= 1)
					{
						done = true;
						break;
					}
				}
				foreach (ModelMaterial mat in mvarCurrentModel.Materials)
				{
					mat.AmbientColor = System.Drawing.Color.FromRGBA(mat.AmbientColor.R - 1, mat.AmbientColor.G - 1, mat.AmbientColor.B - 1);
				}
				System.Threading.Thread.Sleep(50);
			}

			mvarCurrentModel = mvarTransitioningModel;
			mvarTransitioningModel = null;
		}
#endif
	}
}

