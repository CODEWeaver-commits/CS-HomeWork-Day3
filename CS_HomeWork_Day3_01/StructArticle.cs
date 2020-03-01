using static CS_HomeWork_Day3_05.EnumArticleType;

namespace CS_HomeWork_Day3_01
{
    class StructArticle
    {
        struct Article
        {
            public int ItemID { get; private set; }
            public string ItemName { get; private set; }
            public double ItemPrice { get; private set; }
            public ArticleType type { get; private set; }
        }
    }
}