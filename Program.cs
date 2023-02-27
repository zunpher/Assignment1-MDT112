using System;

namespace Assignment1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your passcode (6 digits): ");
            int passcode = int.Parse(Console.ReadLine());

            if (passcode > 99999 && passcode < 1000000) {
                Console.Write("Enter your affiliation (CIA, FBI, NSA): ");
                string aff = Console.ReadLine();

                int digit1 = passcode % 10;
                int dg2Ctrl = passcode / 10;
                int digit2 = dg2Ctrl % 10;
                int dg3Ctrl = passcode / 100;
                int digit3 = dg3Ctrl % 10;
                int dg4Ctrl = passcode / 1000;
                int digit4 = dg4Ctrl % 10;
                int dg5Ctrl = passcode / 10000;
                int digit5 = dg5Ctrl % 10;
                int dg6Ctrl = passcode / 100000;
                int digit6 = dg6Ctrl % 10;

                switch (aff) {
                    case "CIA" :
                    if (digit1 % 3 == 0) {
                        if (digit2 != 1 && digit2 != 3 && digit2 != 5) {
                            if (digit4 >= 6 && digit4 != 8) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False");
                            }
                        } else {
                            Console.WriteLine("False");
                        }
                    } else {
                        Console.WriteLine("False");
                    }
                    break;

                    case "FBI" :
                    if (digit6 >= 4 && digit6 <= 7) {
                        if (digit3 % 2 == 0 && digit3 != 6) {
                            if (digit5 == 1 || digit5 == 3 || digit5 == 5 || digit5 == 7 || digit5 == 9) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False");
                            }
                        } else {
                            Console.WriteLine("False");
                        }
                    } else {
                        Console.WriteLine("False");
                    }
                    break;

                    case "NSA" :
                    if (digit1 == 1 || digit1 == 2 || digit1 == 3 || digit1 == 5 || digit1 == 6) {
                        if (digit3 % 3 == 0 && digit3 % 2 != 0) {
                            if (digit1==7 || digit2==7 || digit3==7 || digit4==7 || digit5==7 || digit6==7) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False");
                            }
                        } else {
                            Console.WriteLine("False");
                        }
                    } else {
                        Console.WriteLine("False");
                    }
                    break;

                    default :
                    Console.WriteLine("False");
                    break;
                }
            } else {
                Console.WriteLine("False");
            }
        }
    }
}