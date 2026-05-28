using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("--- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("--- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("--- 4.2.3 ---");
            Exercise3();
        }


        private static void Exercise1() {
            var s = Console.ReadLine();
            if (int.TryParse(s, out var num))
                if (num < 0) {
                    Console.WriteLine(num);
                } else if (num < 100) {
                    Console.WriteLine(num * 2);
                } else if (num < 500) {
                    Console.WriteLine(num * 3);
                } else {
                    Console.WriteLine(num);
                }
        }

        private static void Exercise2() {
            var s = Console.ReadLine();
            if (int.TryParse(s, out var num))
                switch (num) {
                    case < 0:
                        Console.WriteLine(num);
                        break;
                    case < 100:
                        Console.WriteLine(num * 2);
                        break;
                    case < 500:
                        Console.WriteLine(num * 3);
                        break;
                    default:
                        Console.WriteLine(num);
                        break;
                }
        }

        private static void Exercise3() {
            var s = Console.ReadLine();
            if (int.TryParse(s, out var num)) {
                var outNum = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                => num

                };
                Console.WriteLine(outNum);
            }
        }
    }
}
