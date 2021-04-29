namespace SentimentAnalysis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Hosgeldiniz = new System.Windows.Forms.Label();
            this.DosyaGirisiLabel = new System.Windows.Forms.Label();
            this.FileDialogButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SecilenPath = new System.Windows.Forms.TextBox();
            this.devamButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // Hosgeldiniz
            // 
            resources.ApplyResources(this.Hosgeldiniz, "Hosgeldiniz");
            this.Hosgeldiniz.ForeColor = System.Drawing.Color.ForestGreen;
            this.Hosgeldiniz.Name = "Hosgeldiniz";
            // 
            // DosyaGirisiLabel
            // 
            resources.ApplyResources(this.DosyaGirisiLabel, "DosyaGirisiLabel");
            this.DosyaGirisiLabel.Name = "DosyaGirisiLabel";
            this.DosyaGirisiLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FileDialogButton
            // 
            resources.ApplyResources(this.FileDialogButton, "FileDialogButton");
            this.FileDialogButton.Name = "FileDialogButton";
            this.FileDialogButton.UseVisualStyleBackColor = true;
            this.FileDialogButton.Click += new System.EventHandler(this.FileDialogButton_Click);
            // 
            // SecilenPath
            // 
            resources.ApplyResources(this.SecilenPath, "SecilenPath");
            this.SecilenPath.Name = "SecilenPath";
            this.SecilenPath.ReadOnly = true;
            // 
            // devamButton
            // 
            resources.ApplyResources(this.devamButton, "devamButton");
            this.devamButton.ForeColor = System.Drawing.Color.Green;
            this.devamButton.Name = "devamButton";
            this.devamButton.UseVisualStyleBackColor = true;
            this.devamButton.Click += new System.EventHandler(this.devamButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.devamButton);
            this.Controls.Add(this.SecilenPath);
            this.Controls.Add(this.FileDialogButton);
            this.Controls.Add(this.DosyaGirisiLabel);
            this.Controls.Add(this.Hosgeldiniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label Hosgeldiniz;
        private System.Windows.Forms.Label DosyaGirisiLabel;
        private System.Windows.Forms.Button FileDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button devamButton;
        private System.Windows.Forms.TextBox SecilenPath;
        private System.Windows.Forms.Button button1;
    }
}

