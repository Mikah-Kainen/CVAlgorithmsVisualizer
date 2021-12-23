using Emgu.CV;
using Emgu.CV.Util;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CVBitWiseOperations
{
    public static class Extensions
    {

        public static (Mat R, Mat G, Mat B) GetRGBGreyScale(this Mat mat)
        {
            VectorOfMat colorChannels = new VectorOfMat();
            CvInvoke.Split(mat, colorChannels);
            (Mat R, Mat G, Mat B) returnValue;
            returnValue.B = colorChannels[0];
            returnValue.G = colorChannels[1];
            returnValue.R = colorChannels[2];
            return returnValue;
        }

        public static (int R, int G, int B) GetRGB(this Mat mat)
        {
            (int R, int G, int B) returnValue = (0, 0, 0);

            var bitmap = mat.ToBitmap(tryDataSharing: true);
            for(int y = 0; y < bitmap.Height; y ++)
            {
                for(int x = 0; x < bitmap.Width; x ++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    returnValue.R += pixel.R;
                    returnValue.G += pixel.G;
                    returnValue.B += pixel.B;
                }
            }

            returnValue.R /= (bitmap.Height * bitmap.Width);
            returnValue.G /= (bitmap.Height * bitmap.Width);
            returnValue.B /= (bitmap.Height * bitmap.Width);

            return returnValue;
        }
    }
}
