using System;
namespace Ch4StudioMenu
{
    public class Menu
    {
        public static string welcomeMess = "Welcome to the NoodleVerse! \n sample traditional noodle dishes from around the universe!";
        public static string chefsStaples = "Chef's Staples Include: \n" +
            "1) Vulcan Beef and Noodle Soup\n" +
            "2) Alpha Centauri Chicken and Noodle Soup\n" +
            "3) Terran Salted Egg Ramen\n" +
            "4) Klingon Black Bean Udon (Now with extra Gagh!)\n";

        public Menu()
        {


        }

        public static void displayMenu()
        {
            Console.WriteLine(welcomeMess);
            Console.WriteLine();
            Console.WriteLine(chefsStaples);
        }
    }
}
