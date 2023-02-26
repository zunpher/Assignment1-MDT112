using System;

namespace Assignment1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Input your passcode (6 digits): ");
            int passcode = int.Parse(Console.ReadLine());

            if (passcode<1000000 && passcode>=99999) {
                Console.Write("Input your affiliation: ");
                string aff = Console.ReadLine();
            } else {
                Console.WriteLine("Incorrect passcode.");
            }
        }
    }
}