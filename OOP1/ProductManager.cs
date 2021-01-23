using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    { //encapsulation
        public void Add(Product product) //Product türünde bir şey ver diyor
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }


        public void Update( Product product )
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }
        //void emir kipidir
       

    }
}
