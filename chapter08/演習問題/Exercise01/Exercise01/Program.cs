namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var dict = new Dictionary<char, int>();
            string upperText = text.ToUpper();

            foreach (var item in upperText) {
                if (dict.ContainsKey(item)) {
                        dict[item] += 1;
                    } else {
                        dict[item] = 1;
                    }
                }
            foreach (var item in dict.OrderBy(x => x.Key)) {
                    Console.WriteLine(item);
                }
            }
        private static void Exercise2(string text) {

        }
    }
}
