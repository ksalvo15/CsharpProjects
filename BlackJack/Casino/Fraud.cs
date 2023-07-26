using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Fraud : Exception
    {
        public Fraud()
            :base() { }
        public Fraud(string message)
            :base(message) { }
    }
}
