using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern.DataObjects
{
    public class DekTec102 : IPlay
    {
        public DekTec102()
        {
        }

        public string Play()
        {
            return ("You choose DekTec102");
        }
    }
}
