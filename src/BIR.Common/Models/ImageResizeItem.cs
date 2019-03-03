using System;
using System.Collections.Generic;
using System.Text;

namespace BIR.Common.Models
{
    public class ImageResizeItem
    {
        public string SourceFileName { get; set; }
        public int ResizeWidth { get; set; }
        public int ResizeHeight { get; set; }
        public string TargetPath { get; set; }
        public string TargetFileName { get; set; }

    }
}
