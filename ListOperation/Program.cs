using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var experiment = new Experiment(); // The data is populated on object creation

            //Display objects in loop
            foreach (var item in experiment.ProductList)
            {
                Console.WriteLine(" # " + item.SNo + ".   ProductId: " + item.ProductId 
                    + " \t URL : " + item.URL 
                    + "\t >> URL Type:" + item.TypeOfURL
                    + "\t >> Details:" + item.ProductDetails);
            }

            Console.WriteLine(" Performing data comparison ... ");

            Thread.Sleep(50); // Give user time to take a look at the default data created

            var initialProductId = string.Empty;
            var previousProductId = string.Empty;

            var listOfNonMatchingProducts = new List<string>();
            var listOfMatchingProducts = new List<string>();
            //Perform Comparison
            foreach (var item in experiment.ProductList)
            {
                initialProductId = item.ProductId;

                if (initialProductId == previousProductId)  // Perform Comparison only if the Product IDs are same 
                {
                    if(item.ProductDetails.CompareTo(experiment.ProductList[item.SNo-1].ProductDetails)==0)
                    {
                        // The products details match
                        listOfMatchingProducts.Add(
                            " S.No :  " + item.SNo + "\t ProductId: " + item.ProductId );
                    }
                    else
                    {
                        // The products details don't match
                        listOfNonMatchingProducts.Add(
                            " S.No :  " + item.SNo + "\t ProductId: " + item.ProductId);
                         /*   "\n S.No:" + experiment.ProductList[item.SNo - 1].SNo + "\t ProductId: " + experiment.ProductList[item.SNo - 1].ProductId +
                            "\t ProductDetails: " + experiment.ProductList[item.SNo - 1].ProductDetails +
                            "\n -------------------------------------------- \n" +
                            "S.No:" + item.SNo + "\t ProductId: " + item.ProductId +
                            "\t ProductDetails: " + item.ProductDetails +
                            "\n ---------------------------------------------------------------------------- \n\n") ;*/
                    }
                }
                previousProductId = item.ProductId;

            }

            Console.WriteLine("\n List of Non-Matching Product IDs : \n ");
            foreach (var item in listOfNonMatchingProducts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n List of Matching Product IDs : \n ");
            foreach (var item in listOfMatchingProducts)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

    }
}
