using Microsoft.Win32;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise01_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() is true) {
                TextArea.Text = await TextReadSample.ReadTextAsync(ofd.FileName);
            }
        }
    }

    static class TextReadSample {
        public static async Task<string> ReadTextAsync(string fileName) {
            var sb = new StringBuilder();

            using (var sr = new StreamReader(fileName)) {
                // 行ごとに末尾まで非同期で読み込む
                while (!sr.EndOfStream) {
                    string line = await sr.ReadLineAsync();
                    sb.AppendLine(line);
                }

                return sb.ToString();
            }
        }
    }
}
