using System;

namespace FactoryPattern.DataObjects
{
    public class DekTec101 : IPlay
    {
        public DekTec101()
        {
        }

        public string Play()
        {
            return ("You choose DekTec101");
        }
    }
}