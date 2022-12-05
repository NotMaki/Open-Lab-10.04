using Open_Lab_10._03;
using Open_Lab_10._04;
using System;
using System.Security.Cryptography;

namespace Open_Lab_10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book();
            LOTR.Title = "The Lord of the Rings";
            LOTR.Pages = 9250;
            LOTR.Category = "epic high-fantasy novel";
            LOTR.Author = "John Ronald Reuel Tolkien";
            LOTR.ReleaseDate = 1954;
            Console.WriteLine(LOTR.ToString());


        }
    }
}