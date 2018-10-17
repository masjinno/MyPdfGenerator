using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfLib
{
    public class Margin
    {
        public float Left { get; set; } = 0F;
        public float Right { get; set; } = 0F;
        public float Top { get; set; } = 0F;
        public float Bottom { get; set; } = 0F;

        public Margin()
        {
        }

        public Margin(float left, float right, float top, float bottom)
        {
            this.Left = left;
            this.Right = right;
            this.Top = top;
            this.Bottom = bottom;
        }
    }
}
