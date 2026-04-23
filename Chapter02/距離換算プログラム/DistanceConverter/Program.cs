

namespace DistanceConverter
{
    internal class Program {
        static void Main(string[] args) {

            if (args.Length >= 3
                && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int end)) {
                if (args[0] == "-tom") {
                    PrintFeetToMeterList(start, end);  //メートルへ変換
                }
                else if (args[0] == "-tof") {
                    PrintMeterToFeetList(start, end);  //フィートへ変換
                }
                else {
                    Console.WriteLine("Error!");  //エラーの表示
                }
            }
        }
        static void PrintFeetToMeterList(int start, int stop) {
            //フィートからメートルへの対応表を出力
            FeetConverter converter = new FeetConverter();

            for (int feet = start; feet <= stop; feet++) {
                double meter = converter.FeeToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        static void PrintMeterToFeetList(int start, int stop) {
            //メートルからフィートへの対応表を出力
            FeetConverter converter = new FeetConverter();

            for (int meter = start; meter <= stop; meter++) {
                double feet = converter.FeeToMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}   
