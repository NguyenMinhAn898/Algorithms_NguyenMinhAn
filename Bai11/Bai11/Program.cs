using System;
using System.Collections.Generic;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bai 11");
            List<Product> listProduct =  fetchDataProduct();
            List<Product> listProductSortByPrice = sortByPrice(listProduct);

            foreach(Product product in listProductSortByPrice)
            {
                Console.WriteLine(product.Name +" "+ product.Price);
            }
        }

        static List<Product> sortByPrice(List<Product> listProduct)
        {
            for (int i = 0; i < listProduct.Count - 1; i++)
            {
                bool swapped = true;
                for (int j = 0; j < listProduct.Count - 1 - i; j++)
                {
                    if (listProduct[j].Price > listProduct[j + 1].Price)
                    {
                        Product temp = listProduct[j];
                        listProduct[j] = listProduct[j + 1];
                        listProduct[j + 1] = temp;

                        swapped = false;
                    }
                }
                if (swapped)
                {
                    break;
                }
            }
            return listProduct;
        }

        static List<Category> fetchDataCategory()
        {
            List<Category> listCate = new List<Category>();
            listCate.Add(new Category(1, "Comuter"));
            listCate.Add(new Category(2, "Memory"));
            listCate.Add(new Category(3, "Card"));
            listCate.Add(new Category(4, "Acsesory"));
            return listCate;
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
     * Class Category
     */
    class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Category() { }

        public Category(int id, String name)
        {
            Id = id;
            Name = name;
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
