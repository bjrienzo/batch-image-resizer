using System;
using System.Collections.Generic;
using System.Text;

namespace BIR.Common.Enums
{

    /// <summary>
    /// Cover - Image will be resized, maintaining aspect ratio, so the entire canvas is filled
    /// Contain - Image will be rseized, maintaining aspect ration, until any dimension reaches a boundary
    /// </summary>
    public enum ResizeMode
    {
        Cover = 1,
        Contain = 2,
        Stretch = 3       
    }
}
