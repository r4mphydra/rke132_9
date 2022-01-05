using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();
            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffee machine");
            myWishList.Add("grill");
            myWishList.Add("new pair of J's");
            myWishList.Add("computer mice");

            Console.WriteLine(myWishList.Count);
            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
