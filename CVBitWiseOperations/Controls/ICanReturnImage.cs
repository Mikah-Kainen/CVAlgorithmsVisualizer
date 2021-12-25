using Emgu.CV;

using System;
using System.Collections.Generic;
using System.Text;

namespace CVBitWiseOperations.Controls
{
    public struct NewImageEvent
    {
        public Mat OldImage { get; set; }
        public Mat NewImage { get; set; }

        public NewImageEvent(Mat oldImage, Mat newImage)
        {
            OldImage = oldImage;
            NewImage = newImage;
        }
    }

    interface ICanReturnImage
    {
        public event EventHandler<NewImageEvent> ImageReturned;

    }
}
