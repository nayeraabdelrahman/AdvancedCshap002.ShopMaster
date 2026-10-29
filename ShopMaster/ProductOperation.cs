using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace ShopMaster
{
    internal class ProductOperation
    {
        public static List<Product> SearchProduct(List<Product>collage, Func<Product, bool> expression)
        {
            List<Product> result = [];
            foreach (var item in collage)
            {
                if (expression(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<Product>FilterProducts(List<Product> products, Predicate<Product> expression)
        {

            return SearchProduct(products, (Product item) => expression(item));
        }
        public static void PrintReport(List<Product> filter, Action<Product> action)
        {
            foreach (var item in filter)
            {
                action(item);
            }
        }

        public static List<string> TransformProducts(List<Product> collage, Func<Product, string> transfereToString)
        {
            List<string> result = [];
            foreach (var item in collage)
            {
                string PriceText = transfereToString(item);
                
                result.Add(PriceText);
            }
            return result;
        }
     

    }
}
