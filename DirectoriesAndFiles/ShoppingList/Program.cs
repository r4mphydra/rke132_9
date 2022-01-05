using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Documents\RKE132\Nadal9\";
            string newDirectory = @"shoppinglist";
            string fileName = @"\\shoppinglist.txt";
            string fileLocation = @"C:\Users\...\Documents\RKE132\Nadal9\shoppinglist";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();
            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add something new to the cart? Y/N:");
                char userI = Convert.ToChar(Console.ReadLine().ToLower());
                if (userI == 'y')
                {
                    Console.WriteLine("Enter your needs:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();
            foreach (string wish in myWishList)
            {
                Console.WriteLine($"in your cart: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}
