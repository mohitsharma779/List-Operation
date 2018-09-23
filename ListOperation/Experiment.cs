using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperation
{
    public class Experiment
    {
        public List<Product> ProductList = new List<Product>();
        //Use default constructor to create the object
        public Experiment()
        {
            var stringProd = string.Empty;
            for (int i = 65; i < 85; i++)
            {
                if (i % 2 != 0)
                {
                    stringProd = char.ConvertFromUtf32(i);
                }
                var product = new Product
                {
                    SNo = i - 65,
                    ProductId = stringProd,
                    URL = ("www.AmericanExpress.com\\ProductId\\" + stringProd),
                    TypeOfURL = i % 2 == 0 ? Product.URLType.WithoutLogin : Product.URLType.Login,
                    ProductDetails = CreateObject(stringProd,(i-65))
                };

                ProductList.Add(product);
            }

        }

        //Use this to Create Object for Each Product Id
        public string CreateObject(string prodId,int sNo)
        {
            // If the S.No is a multiple of 3 only then we are making the ProdId as separate
            return Product.ObjectValue1 + prodId + (sNo%3==0?sNo.ToString():string.Empty);
        }
    }
}
