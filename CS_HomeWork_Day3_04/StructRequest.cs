using System;
using static CS_HomeWork_Day3_07.EnumPayType;

namespace CS_HomeWork_Day3_04
{
    class StructRequest
    {
        struct Request
        {
            public int OrderID { get; private set; }
            public string Client { get; private set; }
            public DateTime OrderDate { get; private set; }
            public int[] OrderedItems { get; private set; } // Предпологалось что перечень товаров это ID товара
            public double OrderSum { get { return (double)OrderedItems.Length; } }
            public PayType payType { get; private set; }
        }
    }
}
