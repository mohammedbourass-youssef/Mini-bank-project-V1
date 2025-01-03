using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Bank_Syatem
{
    internal class ChangeColorRandomly
    {
        
        int _CurrentColor = -1;
        public ChangeColorRandomly(int Color)
        {
            _CurrentColor = Color;
        }
        public  void ChangeButtunAndHeadersColorRandomly(Button button) 
        {
            //            Color[] colorPalette = new Color[]
            //{
            //    Color.FromArgb(125, 123, 103), // Muted Olive Gray (Base Color)
            //    Color.FromArgb(139, 69, 19),   // Saddle Brown
            //    Color.FromArgb(47, 79, 79),    // Dark Slate Gray
            //    Color.FromArgb(92, 64, 51),    // Dark Brown
            //    Color.FromArgb(128, 0, 0),     // Maroon
            //    Color.FromArgb(0, 100, 0),     // Dark Green
            //    Color.FromArgb(70, 130, 180),  // Steel Blue
            //    Color.FromArgb(128, 128, 0),   // Olive
            //};





            //Random Random = new Random();
            //int NextColor = Random.Next(colorPalette.Length);
            //while(NextColor == _CurrentColor)
            //   NextColor = Random.Next(colorPalette.Length);

            //button.BackColor = colorPalette[NextColor];

            button.BackColor = Color.FromArgb(125, 123, 103);
        }
    }
}
