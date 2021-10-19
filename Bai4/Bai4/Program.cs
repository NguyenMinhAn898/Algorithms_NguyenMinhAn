using System;
using System.Collections.Generic;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten can tim :");
            String nameProduct = Console.ReadLine();
            List<Product> listProduct = fetchData();
            Product product = findProduct(listProduct, nameProduct);
            if (product.Name == null)
            {
                Console.WriteLine("Khong ton tai san pham nao ten : " + nameProduct);
            }
            else {
                Console.WriteLine( "Thong tin san pham : \n"+" Name : " + product.Name +"\n"+ " Price : " + product.Price + "\n" + " Quanlity : " + product.Quanlity);
            }
        }
        static Product findProduct(List<Product> listProduct, String nameProduct)
        {
            Product ouput = new Product();
            //Product pr = listProduct.Find(p => p.Name.Equals(nameProduct));
            foreach(Product product in listProduct)
            {
                if (product.Name.Equals(nameProduct))
                {
                    ouput = product;
                };
            }
            return ouput;
        }
        /*
         * Ham create data fetch
         */
        static List<Product> fetchData()
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
