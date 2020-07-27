using System;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
namespace PasswordHasherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordHasher = new PasswordHasher<string>();
            Console.WriteLine(passwordHasher.HashPassword(null, "heyodamo"));
            Console.Beep();
            Console.ReadLine();
        }
    }
}