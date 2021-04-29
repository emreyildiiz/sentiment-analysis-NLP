namespace SentimentAnalysis
{
    partial class Sınıf_Seç
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetinTextBox = new System.Windows.Forms.RichTextBox();
            this.metinTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.olumsuzRadioButton = new System.Windows.Forms.RadioButton();
            this.notrRadioButton = new System.Windows.Forms.RadioButton();
            this.olumluRadioButton = new System.Windows.Forms.RadioButton();
            this.sonrakiMetinButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DosyaIsmiLabel = new System.Windows.Forms.Label();
            this.DosyaIsmi = new System.Windows.Forms.Label();
            this.bitirButton = new System.Windows.Forms.Button();
            this.OncekiMetinButton = new System.Windows.Forms.Button();
            this.Tahmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetinTextBox
            // 
            this.MetinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetinTextBox.BackColor = System.Drawing.Color.White;
            this.MetinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MetinTextBox.Location = new System.Drawing.Point(12, 49);
            this.MetinTextBox.Name = "MetinTextBox";
            this.MetinTextBox.ReadOnly = true;
            this.MetinTextBox.Size = new System.Drawing.Size(894, 510);
            this.MetinTextBox.TabIndex = 0;
            this.MetinTextBox.Text = "";
            // 
            // metinTitle
            // 
            this.metinTitle.AutoSize = true;
            this.metinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metinTitle.Location = new System.Drawing.Point(416, 9);
            this.metinTitle.Name = "metinTitle";
            this.metinTitle.Size = new System.Drawing.Size(99, 37);
            this.metinTitle.TabIndex = 1;
            this.metinTitle.Text = "Metin";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.olumsuzRadioButton);
            this.panel1.Controls.Add(this.notrRadioButton);
            this.panel1.Controls.Add(this.olumluRadioButton);
            this.panel1.Location = new System.Drawing.Point(972, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 127);
            this.panel1.TabIndex = 2;
            // 
            // olumsuzRadioButton
            // 
            this.olumsuzRadioButton.AutoSize = true;
            this.olumsuzRadioButton.Location = new System.Drawing.Point(12, 81);
            this.olumsuzRadioButton.Name = "olumsuzRadioButton";
            this.olumsuzRadioButton.Size = new System.Drawing.Size(65, 17);
            this.olumsuzRadioButton.TabIndex = 5;
            this.olumsuzRadioButton.Text = "Olumsuz";
            this.olumsuzRadioButton.UseVisualStyleBackColor = true;
            // 
            // notrRadioButton
            // 
            this.notrRadioButton.AutoSize = true;
            this.notrRadioButton.Checked = true;
            this.notrRadioButton.Location = new System.Drawing.Point(12, 48);
            this.notrRadioButton.Name = "notrRadioButton";
            this.notrRadioButton.Size = new System.Drawing.Size(45, 17);
            this.notrRadioButton.TabIndex = 4;
            this.notrRadioButton.TabStop = true;
            this.notrRadioButton.Text = "Nötr";
            this.notrRadioButton.UseVisualStyleBackColor = true;
            // 
            // olumluRadioButton
            // 
            this.olumluRadioButton.AutoSize = true;
            this.olumluRadioButton.Location = new System.Drawing.Point(12, 16);
            this.olumluRadioButton.Name = "olumluRadioButton";
            this.olumluRadioButton.Size = new System.Drawing.Size(57, 17);
            this.olumluRadioButton.TabIndex = 3;
            this.olumluRadioButton.Text = "Olumlu";
            this.olumluRadioButton.UseVisualStyleBackColor = true;
            // 
            // sonrakiMetinButton
            // 
            this.sonrakiMetinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sonrakiMetinButton.Location = new System.Drawing.Point(972, 335);
            this.sonrakiMetinButton.Name = "sonrakiMetinButton";
            this.sonrakiMetinButton.Size = new System.Drawing.Size(150, 50);
            this.sonrakiMetinButton.TabIndex = 3;
            this.sonrakiMetinButton.Text = "Sonraki Metin";
            this.sonrakiMetinButton.UseVisualStyleBackColor = true;
            this.sonrakiMetinButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(989, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sınıf Seç";
            // 
            // DosyaIsmiLabel
            // 
            this.DosyaIsmiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DosyaIsmiLabel.AutoSize = true;
            this.DosyaIsmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DosyaIsmiLabel.Location = new System.Drawing.Point(995, 63);
            this.DosyaIsmiLabel.Name = "DosyaIsmiLabel";
            this.DosyaIsmiLabel.Size = new System.Drawing.Size(100, 24);
            this.DosyaIsmiLabel.TabIndex = 5;
            this.DosyaIsmiLabel.Text = "Dosya İsmi";
            // 
            // DosyaIsmi
            // 
            this.DosyaIsmi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DosyaIsmi.AutoSize = true;
            this.DosyaIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DosyaIsmi.Location = new System.Drawing.Point(1006, 97);
            this.DosyaIsmi.Name = "DosyaIsmi";
            this.DosyaIsmi.Size = new System.Drawing.Size(75, 18);
            this.DosyaIsmi.TabIndex = 6;
            this.DosyaIsmi.Text = "dosyaismi";
            // 
            // bitirButton
            // 
            this.bitirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitirButton.Enabled = false;
            this.bitirButton.Location = new System.Drawing.Point(972, 447);
            this.bitirButton.Name = "bitirButton";
            this.bitirButton.Size = new System.Drawing.Size(150, 50);
            this.bitirButton.TabIndex = 7;
            this.bitirButton.Text = "Sonuclari Goster";
            this.bitirButton.UseVisualStyleBackColor = true;
            this.bitirButton.Click += new System.EventHandler(this.bitirButton_Click);
            // 
            // OncekiMetinButton
            // 
            this.OncekiMetinButton.Enabled = false;
            this.OncekiMetinButton.Location = new System.Drawing.Point(972, 391);
            this.OncekiMetinButton.Name = "OncekiMetinButton";
            this.OncekiMetinButton.Size = new System.Drawing.Size(150, 50);
            this.OncekiMetinButton.TabIndex = 8;
            this.OncekiMetinButton.Text = "Önceki Metin";
            this.OncekiMetinButton.UseVisualStyleBackColor = true;
            this.OncekiMetinButton.Click += new System.EventHandler(this.OncekiMetinButton_Click);
            // 
            // Tahmin
            // 
            this.Tahmin.Enabled = false;
            this.Tahmin.Location = new System.Drawing.Point(972, 503);
            this.Tahmin.Name = "Tahmin";
            this.Tahmin.Size = new System.Drawing.Size(150, 50);
            this.Tahmin.TabIndex = 9;
            this.Tahmin.Text = "Tahmin Et";
            this.Tahmin.UseVisualStyleBackColor = true;
            this.Tahmin.Click += new System.EventHandler(this.Tahmin_Click);
            // 
            // Sınıf_Seç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1203, 585);
            this.Controls.Add(this.Tahmin);
            this.Controls.Add(this.OncekiMetinButton);
            this.Controls.Add(this.bitirButton);
            this.Controls.Add(this.DosyaIsmi);
            this.Controls.Add(this.DosyaIsmiLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonrakiMetinButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metinTitle);
            this.Controls.Add(this.MetinTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "Sınıf_Seç";
            this.Text = "Sınıf_Seç";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Sınıf_Seç_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MetinTextBox;
        private System.Windows.Forms.Label metinTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton olumsuzRadioButton;
        private System.Windows.Forms.RadioButton notrRadioButton;
        private System.Windows.Forms.RadioButton olumluRadioButton;
        private System.Windows.Forms.Button sonrakiMetinButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DosyaIsmiLabel;
        private System.Windows.Forms.Label DosyaIsmi;
        private System.Windows.Forms.Button bitirButton;
        private System.Windows.Forms.Button OncekiMetinButton;
        private System.Windows.Forms.Button Tahmin;
    }
}