using static CS_HomeWork_Day3_06.EnumImportance;

namespace CS_HomeWork_Day3_02
{
    class StructClient
    {
        struct Client
        {
            public int ClientID { get; private set; }
            public string Fullname { get; private set; }
            public string Adress { get; private set; }
            public string Phone { get; private set; }
            public int OrderQuantity { get; private set; }
            public decimal OverallOrdersSum { get; private set; }
            public Importance importance { get; private set; }
        }
    }
}
