using Emgu.CV;

using System;
using System.Collections.Generic;
using System.Text;

namespace CVBitWiseOperations.Controls
{
    public struct NewNameEvent
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public NewNameEvent(string oldValue, string newValue)
        {
            OldName = oldValue;
            NewName = newValue;
        }
    }

    public interface ICanChangeName
    {
        public event EventHandler<NewNameEvent> NameChanged;

        public Mat Image { get; }
        //might need to add the setImage function
    }
}
