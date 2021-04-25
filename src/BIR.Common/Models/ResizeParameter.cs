using System;
using System.Collections.Generic;
using System.Text;

namespace BIR.Common.Models
{
    public class ResizeParameter
    {

        public int TargetWidth { get;  }
        public int TargetHeight { get; }

        public ResizeParameter(int width, int height)
        {
            TargetWidth = width;
            TargetHeight = height;
        }

        public string DisplayText => $"{TargetWidth}x{TargetHeight}";


    }
}
