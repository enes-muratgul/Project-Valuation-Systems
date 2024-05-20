namespace Project_Evaluation_System
{
    partial class anaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAkademik = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnBitProje = new System.Windows.Forms.Button();
            this.btnGListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projesi Değerlendirme Sistemi";
            // 
            // btnAkademik
            // 
            this.btnAkademik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAkademik.Location = new System.Drawing.Point(48, 41);
            this.btnAkademik.Name = "btnAkademik";
            this.btnAkademik.Size = new System.Drawing.Size(122, 39);
            this.btnAkademik.TabIndex = 5;
            this.btnAkademik.Text = "Akademisyenler";
            this.btnAkademik.UseVisualStyleBackColor = true;
            this.btnAkademik.Click += new System.EventHandler(this.btnAkademik_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Location = new System.Drawing.Point(255, 41);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(122, 39);
            this.btnOgrenci.TabIndex = 6;
            this.btnOgrenci.Text = "Öğrenciler";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnBitProje
            // 
            this.btnBitProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitProje.Location = new System.Drawing.Point(48, 95);
            this.btnBitProje.Name = "btnBitProje";
            this.btnBitProje.Size = new System.Drawing.Size(122, 39);
            this.btnBitProje.TabIndex = 7;
            this.btnBitProje.Text = "Bitirme Projeleri";
            this.btnBitProje.UseVisualStyleBackColor = true;
            this.btnBitProje.Click += new System.EventHandler(this.btnBitProje_Click);
            // 
            // btnGListe
            // 
            this.btnGListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGListe.Location = new System.Drawing.Point(255, 95);
            this.btnGListe.Name = "btnGListe";
            this.btnGListe.Size = new System.Drawing.Size(122, 39);
            this.btnGListe.TabIndex = 8;
            this.btnGListe.Text = "Genel Liste";
            this.btnGListe.UseVisualStyleBackColor = true;
            this.btnGListe.Click += new System.EventHandler(this.btnGListe_Click);
            // 
            // anaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 161);
            this.Controls.Add(this.btnGListe);
            this.Controls.Add(this.btnBitProje);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnAkademik);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projesi Değerlendirme Sistem";
            this.Load += new System.EventHandler(this.anaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAkademik;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnBitProje;
        private System.Windows.Forms.Button btnGListe;
    }
}