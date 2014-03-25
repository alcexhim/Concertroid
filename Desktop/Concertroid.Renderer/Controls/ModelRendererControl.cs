using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Caltron;

using UniversalEditor.ObjectModels.Multimedia3D.Model;

namespace Concertroid.Renderer.Controls
{
    public class ModelRendererControl : Control3D
    {
        private ModelObjectModel mvarModel = null;
        public ModelObjectModel Model { get { return mvarModel; } set { mvarModel = value; } }

        protected override void OnRender(RenderEventArgs e)
        {
            base.OnRender(e);
            e.Canvas.Matrix.Mode = MatrixMode.Projection;
            e.Canvas.Matrix.Push();
            e.Canvas.Matrix.Reset();

            // e.Canvas.Rotate(, RotationAxis.Y);

            e.Canvas.Matrix.Mode = MatrixMode.ModelView;
            e.Canvas.Matrix.Push();
            e.Canvas.Matrix.Reset();


            //Tell OpenGL how to convert from coordinates to pixel values
            double ratio = ((double)1920 / (double)1080);
            int width = (int)(Size.Height * ratio);
            Caltron.Internal.OpenGL.Methods.glViewport((int)((Size.Width - width) / 2), 0, width, (int)Size.Height);

            // Switch to setting the camera perspective
            Caltron.Internal.OpenGL.Methods.glMatrixMode(MatrixMode.Projection);

            // Set the camera perspective
            Caltron.Internal.OpenGL.Methods.glLoadIdentity(); //Reset the camera
            
            /*
            Caltron.Internal.GLU.Methods.gluPerspective
            (
                45.0,													// The camera angle
                (double)Size.Width / (double)Size.Height,		// The width-to-height ratio
                1.0,													// The near z clipping coordinate
                200.0													// The far z clipping coordinate
            );
            */

            e.Canvas.Translate(base.Position.X, base.Position.Y, base.Position.Z);
            e.Canvas.Scale(0.045, 0.08, 0.1);

            // Enable multisampling
            Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.Multisampling);
            Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.DepthTesting);

            // Caltron.Internal.OpenGL.Methods.glDisable(Caltron.Internal.OpenGL.Constants.GLCapabilities.CullFace);
            // Caltron.Internal.OpenGL.Methods.glFrontFace(Caltron.Internal.OpenGL.Constants.GLFaceOrientation.Clockwise);
            // Caltron.Internal.OpenGL.Methods.glCullFace(Caltron.Internal.OpenGL.Constants.GLFace.Back);
            // Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.PolygonSmoothing);
            // Caltron.Internal.OpenGL.Methods.glHint(Caltron.Internal.OpenGL.Constants.GLHintTarget.PolygonSmooth, Caltron.Internal.OpenGL.Constants.GLHintMode.Nicest);
            // Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.Normalization);

            // Caltron.Internal.OpenGL.Methods.glEnable(Caltron.Internal.OpenGL.Constants.GLCapabilities.AlphaTesting);
            // Caltron.Internal.OpenGL.Methods.glAlphaFunc(Caltron.Internal.OpenGL.Constants.GLAlphaFunc.GreaterOrEqual, 0.05f);

            e.Canvas.DrawModel(mvarModel);

            // Disable multisampling
            Caltron.Internal.OpenGL.Methods.glDisable(Caltron.Internal.OpenGL.Constants.GLCapabilities.DepthTesting);
            Caltron.Internal.OpenGL.Methods.glDisable(Caltron.Internal.OpenGL.Constants.GLCapabilities.Multisampling);

            // Disable texturing, in the case that it got enabled by a rogue model
            Caltron.Internal.OpenGL.Methods.glDisable(Caltron.Internal.OpenGL.Constants.GLCapabilities.Texture2D);

            e.Canvas.Matrix.Mode = MatrixMode.ModelView;
            e.Canvas.Matrix.Pop();

            e.Canvas.Matrix.Mode = MatrixMode.Projection;
            e.Canvas.Matrix.Pop();
        }
    }
}
