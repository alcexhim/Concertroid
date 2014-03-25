using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalEditor;

using Caltron;

using UniversalEditor.ObjectModels.Multimedia3D.Motion;
using UniversalEditor.DataFormats.Multimedia3D.Motion.PolygonMovieMaker;
using UniversalEditor.DataFormats.Multimedia3D.Motion.MotionVectorData;

using Concertroid.Networking;
using UniversalEditor.Accessors.File;

namespace Concertroid.Renderer
{
	public static class Program
	{
		private static MainWindow mw = null;

		private static AudioManager mvarAudioManager = new AudioManager();
		public static AudioManager AudioManager { get { return mvarAudioManager; } }

		private static void ConvertVMD()
		{
			MVDMotionDataFormat mvd = new MVDMotionDataFormat();
			VMDMotionDataFormat vmd = new VMDMotionDataFormat();

			MotionObjectModel motion = new MotionObjectModel();
			UniversalEditor.ObjectModel om = motion;

			FileAccessor accessor1 = new FileAccessor(om, vmd);
			accessor1.Open(@"C:\Applications\MikuMikuDance\UserFile\Motion\World is Mine.vmd");
			accessor1.Load();
			accessor1.Close();

			motion = new UniversalEditor.ObjectModels.Multimedia3D.Motion.MotionObjectModel();
			om = motion;

			FileAccessor accessor2 = new FileAccessor(om, mvd);
			accessor2.Open(@"C:\Applications\MikuMikuMoving\UserFile\Motion\World is Mine.mvd");
			accessor2.Load();
			accessor2.Close();

			accessor1.EnableWrite = true;
			accessor1.ForceOverwrite = true;
			accessor1.Open(@"C:\Applications\MikuMikuMoving\UserFile\Motion\World is Mine2.vmd");

			vmd.Version = new Version(1, 0);
			motion.CompatibleModelNames.Clear();
			motion.CompatibleModelNames.Add("miku");

			#region Convert VMD2 to VMD1 bone names
			motion.ReplaceBoneNames("下半身先", "lower body");
			motion.ReplaceBoneNames("右つま先ＩＫ", "right toe IK");
			motion.ReplaceBoneNames("左目先", "left eye");
			motion.ReplaceBoneNames("頭先", "head");
			motion.ReplaceBoneNames("左足ＩＫ", "left leg IK");
			motion.ReplaceBoneNames("右髪ＩＫ", "right hair IK");
			motion.ReplaceBoneNames("左つま先ＩＫ", "left toe IK");
			motion.ReplaceBoneNames("右足ＩＫ", "right leg IK");
			motion.ReplaceBoneNames("右目先", "right eye");
			motion.ReplaceBoneNames("左中指先", "left middle1");
			motion.ReplaceBoneNames("左人差指先", "left fore1");
			motion.ReplaceBoneNames("左小指先", "left little1");
			motion.ReplaceBoneNames("左薬指先", "left third1");
			motion.ReplaceBoneNames("左袖先", "left sleeve");
			motion.ReplaceBoneNames("腰飾り先", "waist access");
			motion.ReplaceBoneNames("左親指先", "left thumb1");
			motion.RemoveAllBoneReferences("左手先"); // left hand
			motion.ReplaceBoneNames("左髪ＩＫ", "left hair IK");
			motion.ReplaceBoneNames("両目", "eyes");
			motion.ReplaceBoneNames("右足首", "right ankle");
			motion.ReplaceBoneNames("前髪２", "front hair2");
			motion.ReplaceBoneNames("前髪１", "front hair1");
			motion.ReplaceBoneNames("右ｽｶｰﾄ後", "right skirt_f");
			motion.ReplaceBoneNames("右ｽｶｰﾄ前", "right skirt_b");
			motion.ReplaceBoneNames("右ひざ", "right knee");
			motion.ReplaceBoneNames("右足", "right leg");
			motion.ReplaceBoneNames("前髪３", "front hair3");
			motion.RemoveAllBoneReferences("左つま先"); // left toe
			motion.RemoveAllBoneReferences("右髪７"); // right hair7
			motion.ReplaceBoneNames("ﾈｸﾀｲＩＫ", "necktie IK");
			motion.RemoveAllBoneReferences("右つま先"); // right toe
			motion.RemoveAllBoneReferences("右目光"); // right eye light
			motion.RemoveAllBoneReferences("左目光"); // left eye light
			motion.RemoveAllBoneReferences("左髪７"); // left hair 7
			motion.RemoveAllBoneReferences("ﾈｸﾀｲ４"); // necktie 4
			motion.RemoveAllBoneReferences("左目光先"); // left eye light old
			motion.ReplaceBoneNames("前髪３先", "front hair3");
			motion.RemoveAllBoneReferences("左腕捩先"); // left arm torsion
			motion.RemoveAllBoneReferences("右目光先"); // right eye light old
			motion.ReplaceBoneNames("右つま先ＩＫ先", "right toe IK");
			motion.ReplaceBoneNames("左つま先ＩＫ先", "left toe IK");
			motion.ReplaceBoneNames("前髪２先", "front hair2");
			motion.ReplaceBoneNames("前髪１先", "front hair1");
			motion.RemoveAllBoneReferences("左手捩先"); // left hand torsion old
			motion.RemoveAllBoneReferences("右腕捩1"); // torsion
			motion.RemoveAllBoneReferences("左腕捩3"); // torsion
			motion.RemoveAllBoneReferences("右腕捩3"); // torsion
			motion.RemoveAllBoneReferences("右腕捩2"); // torsion
			motion.RemoveAllBoneReferences("右手捩先"); // torsion
			motion.RemoveAllBoneReferences("右腕捩先"); // torsion
			motion.RemoveAllBoneReferences("左腕捩2"); // torsion
			motion.RemoveAllBoneReferences("左腕捩1"); // torsion
			motion.ReplaceBoneNames("右足ＩＫ先", "right leg IK");
			motion.ReplaceBoneNames("右人差指先", "right fore1");
			motion.ReplaceBoneNames("右親指先", "right thumb1");
			motion.ReplaceBoneNames("右薬指先", "right third1");
			motion.ReplaceBoneNames("右中指先", "right middle1");
			motion.ReplaceBoneNames("左スカート後先", "left skirt_f");
			motion.ReplaceBoneNames("左スカート前先", "left skirt_b");
			motion.RemoveAllBoneReferences("右手先"); // right hand
			motion.ReplaceBoneNames("右袖先", "right sleeve");
			motion.ReplaceBoneNames("右小指先", "right little1");
			motion.ReplaceBoneNames("左髪ＩＫ先", "left hair IK");
			motion.ReplaceBoneNames("ﾈｸﾀｲＩＫ先", "necktie IK");
			motion.ReplaceBoneNames("左足ＩＫ先", "left leg IK");
			motion.ReplaceBoneNames("右髪ＩＫ先", "right hair IK");
			motion.ReplaceBoneNames("右スカート後先", "right skirt_f");
			motion.ReplaceBoneNames("右スカート前先", "right skirt_b");
			motion.ReplaceBoneNames("両目先", "eyes");
			motion.ReplaceBoneNames("センター先", "center");
			motion.ReplaceBoneNames("左袖", "left sleeve");
			motion.ReplaceBoneNames("左手首", "left wrist");
			motion.ReplaceBoneNames("左親指２", "left thumb2");
			motion.ReplaceBoneNames("左親指１", "left thumb1");
			motion.RemoveAllBoneReferences("左腕捩"); // torsion
			motion.ReplaceBoneNames("左腕", "left arm");
			motion.RemoveAllBoneReferences("左手捩"); // torsion
			motion.ReplaceBoneNames("左ひじ", "left elbow");
			motion.ReplaceBoneNames("左人指１", "left fore1");
			motion.ReplaceBoneNames("左薬指１", "left third1");
			motion.ReplaceBoneNames("左中指３", "left middle3");
			motion.ReplaceBoneNames("左薬指３", "left third3");
			motion.ReplaceBoneNames("左薬指２", "left third2");
			motion.ReplaceBoneNames("左人指３", "left fore3");
			motion.ReplaceBoneNames("左人指２", "left fore2");
			motion.ReplaceBoneNames("左中指２", "left middle2");
			motion.ReplaceBoneNames("左中指１", "left middle1");
			motion.ReplaceBoneNames("左肩", "left shoulder");
			motion.ReplaceBoneNames("右目", "right eye");
			motion.ReplaceBoneNames("左目", "left eye");
			motion.ReplaceBoneNames("ﾈｸﾀｲ２", "necktie2");
			motion.ReplaceBoneNames("ﾈｸﾀｲ１", "necktie1");
			motion.ReplaceBoneNames("上半身", "upper body");
			motion.ReplaceBoneNames("センター", "center");
			motion.ReplaceBoneNames("頭", "head");
			motion.ReplaceBoneNames("首", "neck");
			motion.ReplaceBoneNames("ﾈｸﾀｲ３", "necktie3");
			motion.ReplaceBoneNames("左髪４", "left hair4");
			motion.ReplaceBoneNames("左髪３", "left hair3");
			motion.ReplaceBoneNames("左髪６", "left hair6");
			motion.ReplaceBoneNames("左髪５", "left hair5");
			motion.ReplaceBoneNames("腰飾り", "waist access");
			motion.ReplaceBoneNames("下半身", "lower body");
			motion.ReplaceBoneNames("左髪２", "left hair2");
			motion.ReplaceBoneNames("左髪１", "left hair1");
			motion.ReplaceBoneNames("右人指１", "right fore1");
			motion.ReplaceBoneNames("右親指２", "right thumb2");
			motion.ReplaceBoneNames("右人指３", "right fore3");
			motion.ReplaceBoneNames("右人指２", "right fore2");
			motion.ReplaceBoneNames("右手首", "right wrist");
			motion.RemoveAllBoneReferences("右手捩"); // right torsion
			motion.ReplaceBoneNames("右親指１", "right thumb1");
			motion.ReplaceBoneNames("右袖", "right sleeve");
			motion.ReplaceBoneNames("右中指１", "right middle1");
			motion.ReplaceBoneNames("右小指１", "right little1");
			motion.ReplaceBoneNames("右薬指３", "right third3");
			motion.ReplaceBoneNames("右小指３", "right little3");
			motion.ReplaceBoneNames("右小指２", "right little2");
			motion.ReplaceBoneNames("右中指３", "right middle3");
			motion.ReplaceBoneNames("右中指２", "right middle2");
			motion.ReplaceBoneNames("右薬指２", "right third2");
			motion.ReplaceBoneNames("右薬指１", "right third1");
			motion.ReplaceBoneNames("右ひじ", "right elbow");
			motion.ReplaceBoneNames("左足", "left leg");
			motion.ReplaceBoneNames("左ｽｶｰﾄ後", "left skirt_f");
			motion.ReplaceBoneNames("左足首", "left ankle");
			motion.ReplaceBoneNames("左ひざ", "left knee");
			motion.ReplaceBoneNames("左小指２", "left little2");
			motion.ReplaceBoneNames("左小指１", "left little1");
			motion.ReplaceBoneNames("左ｽｶｰﾄ前", "left skirt_b");
			motion.ReplaceBoneNames("左小指３", "left little3");
			motion.ReplaceBoneNames("右髪１", "right hair1");
			motion.ReplaceBoneNames("右肩", "right shoulder");
			motion.ReplaceBoneNames("右髪６", "right hair6");
			motion.RemoveAllBoneReferences("右腕捩"); // right arm torsion
			motion.ReplaceBoneNames("右腕", "right arm");
			motion.ReplaceBoneNames("右髪３", "right hair3");
			motion.ReplaceBoneNames("右髪２", "right hair2");
			motion.ReplaceBoneNames("右髪５", "right hair5");
			motion.ReplaceBoneNames("右髪４", "right hair4");
			#endregion

			accessor1.Save();
			accessor1.Close();
		}

		[STAThread()]
		public static void Main(string[] args)
		{

#if !DEBUG
			try
			{
#endif

				Application.Initialize();


				// load the libraries
				// LibraryManager.Load();


				mw = new MainWindow();
				// mw.FullScreen = true;
				// mw.Hide();

				// Start the listener for the CR-Remote thread
				Server server = new Server();
				server.ServerName = "Concertroid Rendering Server";
				server.ExceptionThrown += server_ExceptionThrown;
				server.RequestReceived += new RequestReceivedEventHandler(server_RequestReceived);
				server.Start();

				AudioManager.Load(@"Music/Background/BGM5.wav");
				AudioManager.Play();

				Application.Start();
#if !DEBUG
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace, ex.GetType().FullName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
#endif
		}

		private static void server_ExceptionThrown(object sender, ExceptionThrownEventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Could not start the Concertroid! Server. The application will start in client-only mode.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			e.Cancel = true;
		}

		private static void server_RequestReceived(object sender, RequestReceivedEventArgs e)
		{
		}

	}
}
