using System;
using System.Collections.Generic;

namespace Bai5
{
    class Program
    {
        public static List<Product> listProduct;
        static void Main(string[] args)
        {
            int cateId = 0;
            Console.WriteLine("Hello World!");
            Console.Write("Nhap ID danh muc can tim : ");
            try
            {
                cateId = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nhap so");
            }

            listProduct = fetchDataProduct();
            List<Product> listProductByPrice = findProductByCategory(listProduct, cateId);
            if(listProductByPrice.Count == 0)
            {
                Console.WriteLine("Khong ton tai danh muc nao .");
            }
            else
            {
                foreach (Product product in listProductByPrice)
                {
                    Console.WriteLine("Thong tin san pham : " + " Name : " + product.Name + " Price : " + product.Price + " Quanlity : " + product.Quanlity);
                }
            }
            


        }
        static List<Product> findProductByCategory(List<Product> listProduct, int categoryId)
        {
            List<Product> ouput = new List<Product>();
                        
            //   listpr = listProduct.FindAll(p => p.CategoryId.Equals(categoryId));
            foreach(Product product in listProduct)
            {
                if(product.CategoryId == categoryId)
                {
                    ouput.Add(product);
                }
            }
            
            return ouput;
        }

        static List<Category> fetchDataCategory()
        {
            List<Category> listCategory = new List<Category>();
            listCategory.Add(new Category(1, "Comuter"));
            listCategory.Add(new Category(2, "Memory"));
            listCategory.Add(new Category(3, "Card"));
            listCategory.Add(new Category(4, "Acsesory"));
            return listCategory;
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
     * Class Cate gory
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
