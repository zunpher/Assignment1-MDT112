using System;

namespace Assignment1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your passcode (6 digits): ");
            int passcode = int.Parse(Console.ReadLine());

            if (passcode > 99999 && passcode < 1000000) {
                Console.Write("Enter your affiliation (CIA, FBI, NSA): ");
                string aff = Console.ReadLine();

                switch (aff) {
                    case "CIA" :
                    break;

                    case "FBI" :
                    break;

                    case "NSA" :
                    break;
                }
            } else {
                Console.WriteLine("False");
            }
        }
    }
}