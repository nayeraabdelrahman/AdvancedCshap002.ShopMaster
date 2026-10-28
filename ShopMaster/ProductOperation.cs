using System;
using System.Collections;
using System.Collections.Generic;
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
        public static void PrintReport(List<Product> filter, Action<Product> action)
        {
            foreach (var item in filter)
            {
                action(item);
            }
        }
       
    }
}
