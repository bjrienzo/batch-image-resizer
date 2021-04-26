using System;
using System.Collections.Generic;
using System.Text;

namespace BIR.Common.Models {
    public class ImageReference {
        /// <summary>
        /// Filename with extension
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Filename including path
        /// </summary>
        public string DirectoryPath { get; set; }
               
        /// <summary>
        /// The root path that was active when adding this image, will be used for building relative folder structures
        /// </summary>
        public string RootPath { get; set; }
    }
}
