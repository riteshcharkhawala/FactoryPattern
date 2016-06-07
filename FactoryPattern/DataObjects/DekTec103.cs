using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern.DataObjects
{
    public class DekTec103 : IPlay
    {
        public DekTec103()
        {
        }

        public string Play()
        {
            return ("You choose DekTec103");
        }
    }
}
