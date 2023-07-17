namespace WinMerhabaBasic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(126, 15);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(6);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(180, 38);
            this.txtIsim.TabIndex = 2;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(126, 61);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(180, 38);
            this.txtSoyisim.TabIndex = 3;
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(126, 111);
            this.btnMesaj.Margin = new System.Windows.Forms.Padding(6);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(138, 44);
            this.btnMesaj.TabIndex = 4;
            this.btnMesaj.Text = "Tıklayınız!";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 171);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Merhaba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Button btnMesaj;
    }
}

