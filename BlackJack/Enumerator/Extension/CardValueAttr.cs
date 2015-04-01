using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Enumerator.Extension
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    class CardValueAttr : Attribute
    {
        internal CardValueAttr(int value)
        {
            this.Value = value;
        }
        public int Value { get; private set; }
    }
}
