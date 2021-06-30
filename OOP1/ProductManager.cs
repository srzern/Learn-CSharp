using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        //void -> method sonunda sonuçla bi ilgi alakamız yoksa void kullanılır
      
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }



    
    }
}
