using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfLib
{
    public class Margin
    {
        public float Top { get; set; } = 0F;
        public float Left { get; set; } = 0F;
        public float Right { get; set; } = 0F;
        public float Bottom { get; set; } = 0F;

        public Margin()
        {
        }

        public Margin(float top, float left, float right, float bottom)
        {
            this.Top = top;
            this.Left = left;
            this.Right = right;
            this.Bottom = bottom;
        }
    }
}
