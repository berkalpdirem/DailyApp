namespace DailyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listDaily = new ListBox();
            rtbDailyWriting = new RichTextBox();
            btnRegister = new Button();
            tbTitle = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // listDaily
            // 
            listDaily.FormattingEnabled = true;
            listDaily.ItemHeight = 15;
            listDaily.Location = new Point(12, 12);
            listDaily.Name = "listDaily";
            listDaily.Size = new Size(193, 334);
            listDaily.TabIndex = 0;
            listDaily.MouseDoubleClick += listDaily_MouseDoubleClick;
            // 
            // rtbDailyWriting
            // 
            rtbDailyWriting.Location = new Point(211, 12);
            rtbDailyWriting.Name = "rtbDailyWriting";
            rtbDailyWriting.Size = new Size(544, 274);
            rtbDailyWriting.TabIndex = 1;
            rtbDailyWriting.Text = "";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(211, 324);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kaydet ve Gönder";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(211, 292);
            tbTitle.Name = "tbTitle";
            tbTitle.PlaceholderText = "Başlık";
            tbTitle.Size = new Size(137, 23);
            tbTitle.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Enabled = false;
            btnBack.Location = new Point(354, 292);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 54);
            btnBack.TabIndex = 3;
            btnBack.Text = "Okuma Modundan Çık";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 408);
            Controls.Add(tbTitle);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(rtbDailyWriting);
            Controls.Add(listDaily);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listDaily;
        private RichTextBox rtbDailyWriting;
        private Button btnRegister;
        private TextBox tbTitle;
        private Button btnBack;
    }
}