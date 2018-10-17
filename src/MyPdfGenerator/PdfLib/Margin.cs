using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfLogic
{
    public class Margin
    {
        public float left { get; set; } = 0F;
        public float right { get; set; } = 0F;
        public float top { get; set; } = 0F;
        public float bottom { get; set; } = 0F;

        public Margin()
        {
        }

        public Margin(float left, float right, float top, float bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }
    }
}
