using Emgu.CV;

using System;
using System.Collections.Generic;
using System.Text;

namespace CVBitWiseOperations.Controls
{
    public struct UpdateImageEvent
    {
        public Mat OldImage { get; set; }
        public Mat NewImage { get; set; }

        public UpdateImageEvent(Mat oldImage, Mat newImage)
        {
            OldImage = oldImage;
            NewImage = newImage;
        }
    }

    interface ICanUpdateImage
    {
        public event EventHandler<UpdateImageEvent> ImageUpdate;
        public string Name { get; }
    }
}
