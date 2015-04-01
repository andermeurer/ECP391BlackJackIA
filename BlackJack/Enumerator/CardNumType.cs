using BlackJack.Enumerator.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Enumerator
{
    public enum CardNumType
    {
        [CardValueAttr(1)]
        [CardValueAttr(11)]
        AS = 1,
        [CardValueAttr(2)]
        DOIS = 2,
        [CardValueAttr(3)]
        TRES = 3,
        [CardValueAttr(4)]
        QUATRO = 4,
        [CardValueAttr(5)]
        CINCO = 5,
        [CardValueAttr(6)]
        SEIS = 6,
        [CardValueAttr(7)]
        SETE = 7,
        [CardValueAttr(8)]
        OITO = 8,
        [CardValueAttr(9)]
        NOVE = 9,
        [CardValueAttr(10)]
        DEZ = 10,
        [CardValueAttr(10)]
        VALETE = 11,
        [CardValueAttr(10)]
        DAMA = 12,
        [CardValueAttr(10)]
        REI = 13
    }
}
