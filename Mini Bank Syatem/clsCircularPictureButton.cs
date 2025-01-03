using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Bank_Syatem
{
    public class clsCircularPictureButton : Button
    {
        private Image _image;

        public Image CircularImage
        {
            get { return _image; }
            set
            {
                _image = value;
                this.Invalidate(); // Forces the control to be redrawn
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (_image != null)
            {
                Graphics g = pevent.Graphics;

                // Set the smoothing mode for better circle rendering
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Calculate the circle's diameter
                int circleDiameter = Height/2 +18;// Adjust size if needed

                // Set the circular image position to be middle-left
                // X position (left-aligned): Small padding of 10
                // Y position (centered vertically): (Button height - circle size) / 2
                Rectangle circleRect = new Rectangle(10, 14, circleDiameter+3, circleDiameter+3);
                // Draw the circular image
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(circleRect); // Create a circular path
                    g.SetClip(path); // Set the clip to the circular region

                    // Resize and draw the image to fit inside the circle, maintaining aspect ratio
                    g.DrawImage(_image, circleRect); // Draw the image inside the circular region
                    g.ResetClip(); // Reset clipping for future graphics
                }
                
            }
        }
    }

}
