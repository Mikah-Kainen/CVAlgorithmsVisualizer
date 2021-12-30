using System;
using System.Collections.Generic;
using System.Text;

namespace CVBitWiseOperations.Controls
{
    interface ICanReturnInt
    {
        public event EventHandler<int> IntReturned;
    }
}
