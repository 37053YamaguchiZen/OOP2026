using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            tbOut1.Text = $"{today}";
        }

        private void tbButton2_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            tbOut2.Text = today.ToString("yyyy”NMŒd“ú@HHmm•ªss•b");
        }

        private void tbButton3_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            CultureInfo cultureJp = new CultureInfo("ja-JP", false);
            cultureJp.DateTimeFormat.Calendar = new JapaneseCalendar();
            string text = today.ToString("ggy”NMŒd“ú (dddd)", cultureJp);
            tbOut3.Text = $"{text}";
        }
    }
}
