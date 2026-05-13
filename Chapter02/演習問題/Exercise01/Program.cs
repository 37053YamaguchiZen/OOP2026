using Exercise01;
using System;
using System.Security.Principal;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            // 2.1.3

            while (true) {
                var songs = new List<Song>();

                Console.Write("曲名：");
                string? title = Console.ReadLine();

                if (title == "end") {

                    Console.Write("アーティスト名：");
                    string? srtistname = Console.ReadLine();

                    Console.Write("演奏時間(秒)：");
                    int length = int.Parse(Console.ReadLine());

                    Song song = new Song(title, srtistname, length);

                    songs.Add(song);
                }
            }
        }
        //Mainメソッド内の PrintSongs(songs); をクリックして
        //Alt + Enterを押すと、以下のメソッドが自動的に作成される
        // 2.1.4
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
               Console.WriteLine($"{song.Title},{song.ArtistName},{song.Length / 60}:{song.Length % 60:00} ");
            }
        }
    }
}
