

namespace DistanceConverter
{
    internal class Program{
        static void Main(string[] args){

            if (args.Length >= 1 && args[0] == "-tom"){
                PrintFeetToMeterList(10, 30);  //メートルへ変換
            }
            else if (args.Length >= 1 && args[0] == "-tof"){
                PrintMeterToFeetList(5, 15);  //フィートへ変換
            }
            else {
                Console.WriteLine("error");
        }
     }
        static void PrintFeetToMeterList(int start, int stop){                
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeeToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        static void PrintMeterToFeetList(int start, int stop){
            //メートルからフィートへの対応表を出力
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

        //フィートからメートルを求める
        static double FeeToMeter(int feet)
        {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}   
