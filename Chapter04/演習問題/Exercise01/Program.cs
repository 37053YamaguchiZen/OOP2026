
using System.Runtime.InteropServices;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");

            Exercise2(langs);
            Console.WriteLine("---");

            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            var where = langs.Where(n => n.Contains('s')).ToList(); 
            foreach (var item in where) {
                Console.WriteLine(item);
           
                    }
            for(int i = 0; i < where.Count(); i++) {
                Console.WriteLine(where);
            }
            int a = 0;
            while (true) {
                Console.WriteLine(where[a]);
                a = a + 1;
                if(a == where.Count()) { break; }
            }
        }

        private static void Exercise2(List<string> langs) {

        }

        private static void Exercise3(List<string> langs) {
        }
    }
}
