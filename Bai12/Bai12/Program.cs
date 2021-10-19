using System;
using System.Collections.Generic;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bai 12");

            List<Product> listProduct = fetchDataProduct();

            List<Product> listProductSortByName = sortByName(listProduct);

            foreach(Product product in listProductSortByName)
            {
                Console.WriteLine(product.Name);
            }

        }

        static List<Product> sortByName(List<Product> listProduct)
        {
            if(listProduct.Count > 0)
            {
                Product valueInsert;
                int holePosition;
                int i;

                for (i = 1 ; i < listProduct.Count; i++)
                {
                    valueInsert = listProduct[i];
                    holePosition = i;

                    while (holePosition > 0 && (listProduct[holePosition - 1].Name).Length < valueInsert.Name.Length)
                    {
                        listProduct[holePosition] = listProduct[holePosition - 1];
                        holePosition--;
                    }

                    if (holePosition != i)
                    {
                        listProduct[holePosition] = valueInsert;
                    }
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
