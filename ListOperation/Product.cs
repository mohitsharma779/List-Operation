using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperation
{
    public class Product
    {
        public enum URLType
        {
            Login,
            WithoutLogin
        };

        public int SNo { get; set; }

        public string ProductId { get; set; }

        public string URL { get; set; }

        public URLType TypeOfURL { get; set; }

        public string ProductDetails { get; set; }

        public const string ObjectValue1 = "This is a dummy value";

        public const string ObjectValue2 = "This is a dummy value 2";
    }
}
