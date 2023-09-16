namespace yiginVEkuyruk
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_yigin_durum = new System.Windows.Forms.TextBox();
            this.btn_yigin_cikar = new System.Windows.Forms.Button();
            this.btn_yigin_ekle = new System.Windows.Forms.Button();
            this.txt_yigin_ekle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kyrk_kontrol = new System.Windows.Forms.TextBox();
            this.kuyruk_cikar_btn = new System.Windows.Forms.Button();
            this.kuyruk_ekle_btn = new System.Windows.Forms.Button();
            this.kyrk_ekle = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_yigin_durum);
            this.tabPage1.Controls.Add(this.btn_yigin_cikar);
            this.tabPage1.Controls.Add(this.btn_yigin_ekle);
            this.tabPage1.Controls.Add(this.txt_yigin_ekle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yığın";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_yigin_durum
            // 
            this.txt_yigin_durum.Location = new System.Drawing.Point(281, 63);
            this.txt_yigin_durum.Multiline = true;
            this.txt_yigin_durum.Name = "txt_yigin_durum";
            this.txt_yigin_durum.Size = new System.Drawing.Size(128, 233);
            this.txt_yigin_durum.TabIndex = 3;
            // 
            // btn_yigin_cikar
            // 
            this.btn_yigin_cikar.Location = new System.Drawing.Point(415, 63);
            this.btn_yigin_cikar.Name = "btn_yigin_cikar";
            this.btn_yigin_cikar.Size = new System.Drawing.Size(75, 23);
            this.btn_yigin_cikar.TabIndex = 2;
            this.btn_yigin_cikar.Text = "Çıkar";
            this.btn_yigin_cikar.UseVisualStyleBackColor = true;
            this.btn_yigin_cikar.Click += new System.EventHandler(this.btn_yigin_cikar_Click);
            // 
            // btn_yigin_ekle
            // 
            this.btn_yigin_ekle.Location = new System.Drawing.Point(188, 63);
            this.btn_yigin_ekle.Name = "btn_yigin_ekle";
            this.btn_yigin_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_yigin_ekle.TabIndex = 1;
            this.btn_yigin_ekle.Text = "Ekle";
            this.btn_yigin_ekle.UseVisualStyleBackColor = true;
            this.btn_yigin_ekle.Click += new System.EventHandler(this.btn_yigin_ekle_Click);
            // 
            // txt_yigin_ekle
            // 
            this.txt_yigin_ekle.Location = new System.Drawing.Point(46, 63);
            this.txt_yigin_ekle.Name = "txt_yigin_ekle";
            this.txt_yigin_ekle.Size = new System.Drawing.Size(100, 22);
            this.txt_yigin_ekle.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kyrk_kontrol);
            this.tabPage2.Controls.Add(this.kuyruk_cikar_btn);
            this.tabPage2.Controls.Add(this.kuyruk_ekle_btn);
            this.tabPage2.Controls.Add(this.kyrk_ekle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kuyruk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kyrk_kontrol
            // 
            this.kyrk_kontrol.Location = new System.Drawing.Point(68, 162);
            this.kyrk_kontrol.Name = "kyrk_kontrol";
            this.kyrk_kontrol.Size = new System.Drawing.Size(544, 22);
            this.kyrk_kontrol.TabIndex = 3;
            // 
            // kuyruk_cikar_btn
            // 
            this.kuyruk_cikar_btn.Location = new System.Drawing.Point(429, 51);
            this.kuyruk_cikar_btn.Name = "kuyruk_cikar_btn";
            this.kuyruk_cikar_btn.Size = new System.Drawing.Size(75, 23);
            this.kuyruk_cikar_btn.TabIndex = 2;
            this.kuyruk_cikar_btn.Text = "çıkar";
            this.kuyruk_cikar_btn.UseVisualStyleBackColor = true;
            ,
            // 
            // kuyruk_ekle_btn
            // 
            this.kuyruk_ekle_btn.Location = new System.Drawing.Point(312, 50);
            this.kuyruk_ekle_btn.Name = "kuyruk_ekle_btn";
            this.kuyruk_ekle_btn.Size = new System.Drawing.Size(75, 23);
            this.kuyruk_ekle_btn.TabIndex = 1;
            this.kuyruk_ekle_btn.Text = "ekle";
            this.kuyruk_ekle_btn.UseVisualStyleBackColor = true;
            this.kuyruk_ekle_btn.Click += new System.EventHandler(this.kuyruk_ekle_btn_Click);
            // 
            // kyrk_ekle
            // 
            this.kyrk_ekle.Location = new System.Drawing.Point(149, 51);
            this.kyrk_ekle.Name = "kyrk_ekle";
            this.kyrk_ekle.Size = new System.Drawing.Size(129, 22);
            this.kyrk_ekle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_yigin_durum;
        private System.Windows.Forms.Button btn_yigin_cikar;
        private System.Windows.Forms.Button btn_yigin_ekle;
        private System.Windows.Forms.TextBox txt_yigin_ekle;
        private System.Windows.Forms.TextBox kyrk_kontrol;
        private System.Windows.Forms.Button kuyruk_cikar_btn;
        private System.Windows.Forms.Button kuyruk_ekle_btn;
        private System.Windows.Forms.TextBox kyrk_ekle;
    }
}

