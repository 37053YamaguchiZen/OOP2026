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
            tbButton1 = new Button();
            tbButton2 = new Button();
            tbButton3 = new Button();
            tbOut1 = new TextBox();
            tbOut2 = new TextBox();
            tbOut3 = new TextBox();
            SuspendLayout();
            // 
            // tbButton1
            // 
            tbButton1.Location = new Point(149, 37);
            tbButton1.Name = "tbButton1";
            tbButton1.Size = new Size(75, 23);
            tbButton1.TabIndex = 0;
            tbButton1.Text = "button1";
            tbButton1.UseVisualStyleBackColor = true;
            tbButton1.Click += btButton1_Click;
            // 
            // tbButton2
            // 
            tbButton2.Location = new Point(149, 132);
            tbButton2.Name = "tbButton2";
            tbButton2.Size = new Size(75, 23);
            tbButton2.TabIndex = 1;
            tbButton2.Text = "button2";
            tbButton2.UseVisualStyleBackColor = true;
            tbButton2.Click += tbButton2_Click;
            // 
            // tbButton3
            // 
            tbButton3.Location = new Point(149, 235);
            tbButton3.Name = "tbButton3";
            tbButton3.Size = new Size(75, 23);
            tbButton3.TabIndex = 2;
            tbButton3.Text = "button3";
            tbButton3.UseVisualStyleBackColor = true;
            tbButton3.Click += tbButton3_Click;
            // 
            // tbOut1
            // 
            tbOut1.Location = new Point(292, 37);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(231, 23);
            tbOut1.TabIndex = 3;
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(288, 133);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(235, 23);
            tbOut2.TabIndex = 4;
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(288, 235);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(226, 23);
            tbOut3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut1);
            Controls.Add(tbButton3);
            Controls.Add(tbButton2);
            Controls.Add(tbButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tbButton1;
        private Button tbButton2;
        private Button tbButton3;
        private TextBox tbOut1;
        private TextBox tbOut2;
        private TextBox tbOut3;
    }
}
