using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace BIR.Common
{

    public class ImageUtility
    {
        
        /// <summary>
        /// Resize a source image to the target dimensions, based on the resize mode
        /// </summary>
        /// <param name="image">Image to Resize</param>
        /// <param name="width">Target desired Width</param>
        /// <param name="height">Target desired Height</param>
        /// <param name="mode">Resize Mode</param>
        /// <returns>Resized Image</returns>
        public static Bitmap ResizeImage(Image image, int width, int height, Enums.ResizeMode mode)
        {

            Rectangle destRect;
            Bitmap destImage = null;

            int xPos = 0;
            int yPos = 0;
            int cropHeight = image.Height;
            int cropWidth = image.Width;
            var widthRatio = (double)width / image.Width;
            var heightRatio = (double)height / image.Height;
            double ratio = 0;

            switch (mode)
            {
                case Enums.ResizeMode.Stretch:
                    //Resize image with no regard for life or limb
                    destRect = new Rectangle(0, 0, width, height);
                    destImage = new Bitmap(width, height);
                    break;
                case Enums.ResizeMode.Contain:
                    //Resize the image as large as possible while maintaining aspect ratio and not exceeding the bounds
                    ratio = widthRatio < heightRatio ? widthRatio : heightRatio;
                    destRect = new Rectangle(0, 0, (int)(image.Width * ratio), (int)(image.Height * ratio));
                    destImage = new Bitmap((int)(image.Width * ratio), (int)(image.Height * ratio));
                    break;

                case Enums.ResizeMode.Cover:
                    //Completely cover the canvas, while maintaining aspect ratio
                    ratio = widthRatio > heightRatio ? widthRatio : heightRatio;

                    //Destination image is exactly requested dimensions
                    destRect = new Rectangle(0, 0, width, height);
                    destImage = new Bitmap(width, height);

                    //Scale the source image so completely covers the requested dimensions
                    var scaledX = Convert.ToInt32(image.Width * ratio);
                    var scaledY = Convert.ToInt32(image.Height * ratio);

                    //Set the start coordinates, centering the source image in the target
                    xPos = (int)((double)(scaledX - destRect.Width) / 2 / ratio);
                    yPos = (int)((double)(scaledY - destRect.Height) / 2 / ratio);

                    //Set the dimensions to grab from the original image
                    cropHeight = image.Height - Convert.ToInt32((scaledY - height) / ratio);
                    cropWidth = image.Width - Convert.ToInt32((scaledX - width) / ratio);

                    break;

            }

            //destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, xPos, yPos, cropWidth, cropHeight, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


    }
}
