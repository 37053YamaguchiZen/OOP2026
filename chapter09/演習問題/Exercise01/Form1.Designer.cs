namespace Exercise01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btButton1 = new Button();
            tbOut1 = new TextBox();
            btButton3 = new Button();
            btButton2 = new Button();
            tbOut3 = new TextBox();
            tbOut2 = new TextBox();
            SuspendLayout();
            // 
            // btButton1
            // 
            btButton1.Location = new Point(69, 66);
            btButton1.Name = "btButton1";
            btButton1.Size = new Size(75, 23);
            btButton1.TabIndex = 0;
            btButton1.Text = "①";
            btButton1.UseVisualStyleBackColor = true;
            // 
            // tbOut1
            // 
            tbOut1.Location = new Point(186, 65);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(294, 23);
            tbOut1.TabIndex = 1;
            // 
            // btButton3
            // 
            btButton3.Location = new Point(69, 193);
            btButton3.Name = "btButton3";
            btButton3.Size = new Size(75, 23);
            btButton3.TabIndex = 2;
            btButton3.Text = "③";
            btButton3.UseVisualStyleBackColor = true;
            // 
            // btButton2
            // 
            btButton2.Location = new Point(69, 130);
            btButton2.Name = "btButton2";
            btButton2.Size = new Size(75, 23);
            btButton2.TabIndex = 3;
            btButton2.Text = "②";
            btButton2.UseVisualStyleBackColor = true;
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(186, 194);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(294, 23);
            tbOut3.TabIndex = 4;
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(186, 131);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(294, 23);
            tbOut2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut2);
            Controls.Add(tbOut3);
            Controls.Add(btButton2);
            Controls.Add(btButton3);
            Controls.Add(tbOut1);
            Controls.Add(btButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btButton1;
        private TextBox tbOut1;
        private Button btButton3;
        private Button btButton2;
        private TextBox tbOut3;
        private TextBox tbOut2;
    }
}
