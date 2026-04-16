namespace sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            //入力
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                
            }
            //出力
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "]");
                //アスタリスク出力
                for (int j = 0;j < array[i]; j++)
                {
                    Console.Write("*");
                }
                //改行
                Console.WriteLine();
            }
            //集計
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("合計値:" + array.Where(n => n % 2 == 0).Sum());
        }
        static void astOut(int num)
        {
            for (int j = 0;j < num; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

