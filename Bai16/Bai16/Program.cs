using System;
using System.Collections.Generic;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bai 15");
            List<Product> listproduct = fetchDataProduct();
            double maxprice = maxPrice(listproduct);
            List<Product> listProductByMaxPrice = maxByPrice(listproduct, maxprice);
            foreach(Product product in listProductByMaxPrice)
            {
                Console.WriteLine(product.Name + " " + product.Price);

            }
        }
        /*
         * Giả sử giá không phải duy nhất có lặp lại
         */
        static double maxPrice(List<Product> listProduct)
        {
            double maxPrice = listProduct[0].Price;
            for(int i = 1; i< listProduct.Count; i++)
            {
                if(listProduct[i].Price > maxPrice)
                {
                    maxPrice = listProduct[i].Price;
                }
            }
            return maxPrice;
        }

        /*
         * Tim cac san pham co gia lon nhat
         */
        static List<Product> maxByPrice(List<Product> listProduct, double maxPrice)
        {
            List<Product> output = new List<Product>();
            for(int i = 0; i < listProduct.Count; i++)
            {
                if(listProduct[i].Price == maxPrice)
                {
                    output.Add(listProduct[i]);
                }
            }
            return output;
        }

        static List<Product> fetchDataProduct()
        {
            List<Product> listProduct = new List<Product>();
            listProduct.Add(new Product("CPU", 750, 10, 1));
            listProduct.Add(new Product("RAM", 50, 2, 2));
            listProduct.Add(new Product("HDD", 70, 1, 2));
            listProduct.Add(new Product("Main", 400, 3, 1));
            listProduct.Add(new Product("Keyboard", 30, 8, 4));
            listProduct.Add(new Product("Mouse", 25, 50, 4));
            listProduct.Add(new Product("VGA", 60, 35, 3));
            listProduct.Add(new Product("Monitor", 120, 28, 2));
            listProduct.Add(new Product("Case", 120, 28, 5));

            return listProduct;
        }

    }
    
    /*
    * Class Product
    */
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quanlity { get; set; }
        public int CategoryId { get; set; }

        public Product() { }

        public Product(String name, double price, int quanlity, int categoryId)
        {
            Name = name;
            Price = price;
            Quanlity = quanlity;
            CategoryId = categoryId;
        }
    }
}
