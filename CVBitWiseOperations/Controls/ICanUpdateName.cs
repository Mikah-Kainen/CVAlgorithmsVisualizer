using Emgu.CV;

using System;
using System.Collections.Generic;
using System.Text;

namespace CVBitWiseOperations.Controls
{
    public struct UpdateNameEvent
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public UpdateNameEvent(string oldValue, string newValue)
        {
            OldName = oldValue;
            NewName = newValue;
        }
    }

    public interface ICanUpdateName
    {
        public event EventHandler<UpdateNameEvent> NameUpdated;

        public Mat Image { get; }
    }
}
