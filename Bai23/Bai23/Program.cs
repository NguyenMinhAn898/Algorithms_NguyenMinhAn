using System;
using System.Collections.Generic;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Bài 23");
            List<Menu> listMenu = fetchDataMenu();
        }

        static List<Menu> fetchDataMenu()
        {
            List<Menu> listMenu = new List<Menu>();
            listMenu.Add(new Menu(1, "Thể thao", 0));
            listMenu.Add(new Menu(2, "Xã hội", 0));
            listMenu.Add(new Menu(3, "Thể thao trong nước", 1));
            listMenu.Add(new Menu(4, "Giao thông", 2));
            listMenu.Add(new Menu(5, "Môi trường", 2));
            listMenu.Add(new Menu(6, "Thể thao quốc tế", 1));
            listMenu.Add(new Menu(7, "Môi trường đô thị", 5));
            listMenu.Add(new Menu(8, "Giao thông ùn tắc", 4));

            return listMenu;
        }
    }

    class Menu
    {
        public int id { get; set; }
        public String title { get; set; }
        public int parentId { get; set; }

        public Menu()
        {

        }
        public Menu(int id, String title, int parentId)
        {
            id = id;
            title = title;
            parentId = parentId;
        }
    }
}
