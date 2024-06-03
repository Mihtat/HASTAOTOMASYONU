namespace HASTAOTOMASYONU
{
    partial class HastaKaydıYap
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
            this.AD = new System.Windows.Forms.TextBox();
            this.SOYAD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCPASPORT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.POLİKLİNİK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KAYITYAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AD
            // 
            this.AD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AD.Location = new System.Drawing.Point(227, 126);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(100, 22);
            this.AD.TabIndex = 1;
            this.AD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AD_KeyPress);
            // 
            // SOYAD
            // 
            this.SOYAD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SOYAD.Location = new System.Drawing.Point(227, 190);
            this.SOYAD.Name = "SOYAD";
            this.SOYAD.Size = new System.Drawing.Size(100, 22);
            this.SOYAD.TabIndex = 2;
            this.SOYAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SOYAD_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(53, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "POLİKLİNİK : ";
            // 
            // TCPASPORT
            // 
            this.TCPASPORT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TCPASPORT.Location = new System.Drawing.Point(227, 252);
            this.TCPASPORT.MaxLength = 11;
            this.TCPASPORT.Name = "TCPASPORT";
            this.TCPASPORT.Size = new System.Drawing.Size(100, 22);
            this.TCPASPORT.TabIndex = 3;
            this.TCPASPORT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCPASPORT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC/PASPORT : ";
            // 
            // POLİKLİNİK
            // 
            this.POLİKLİNİK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.POLİKLİNİK.Location = new System.Drawing.Point(227, 317);
            this.POLİKLİNİK.Name = "POLİKLİNİK";
            this.POLİKLİNİK.Size = new System.Drawing.Size(100, 22);
            this.POLİKLİNİK.TabIndex = 4;
            this.POLİKLİNİK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.POLİKLİNİK_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(53, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYAD : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(53, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(103, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hasta Girişi";
            // 
            // KAYITYAP
            // 
            this.KAYITYAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KAYITYAP.Location = new System.Drawing.Point(138, 371);
            this.KAYITYAP.Name = "KAYITYAP";
            this.KAYITYAP.Size = new System.Drawing.Size(100, 84);
            this.KAYITYAP.TabIndex = 5;
            this.KAYITYAP.Text = "ONAYLA";
            this.KAYITYAP.UseVisualStyleBackColor = true;
            this.KAYITYAP.Click += new System.EventHandler(this.KAYITYAP_Click);
            // 
            // HastaKaydıYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(400, 497);
            this.Controls.Add(this.KAYITYAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SOYAD);
            this.Controls.Add(this.POLİKLİNİK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCPASPORT);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HastaKaydıYap";
            this.Text = "HastaKaydıYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.TextBox SOYAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCPASPORT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox POLİKLİNİK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KAYITYAP;
    }
}