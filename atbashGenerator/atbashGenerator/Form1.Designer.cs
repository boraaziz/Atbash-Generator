namespace atbashGenerator
{
    partial class atbashGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atbashGenerator));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.pnlResim = new System.Windows.Forms.Panel();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrSifrele = new System.Windows.Forms.Timer(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.pnlResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.lblName);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.ForeColor = System.Drawing.Color.White;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(6);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1050, 50);
            this.pnlUst.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(357, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(336, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Atbash Generator and Cracker\r\n";
            // 
            // txtMetin
            // 
            this.txtMetin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtMetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMetin.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMetin.Location = new System.Drawing.Point(24, 212);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(1002, 40);
            this.txtMetin.TabIndex = 1;
            this.txtMetin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMetin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMetin_KeyDown);
            this.txtMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetin_KeyPress);
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.Color.Black;
            this.txtSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSonuc.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonuc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSonuc.Location = new System.Drawing.Point(24, 148);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(1002, 40);
            this.txtSonuc.TabIndex = 1;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSifrele.FlatAppearance.BorderSize = 0;
            this.btnSifrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSifrele.Location = new System.Drawing.Point(24, 74);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(489, 50);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnKir
            // 
            this.btnKir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnKir.FlatAppearance.BorderSize = 0;
            this.btnKir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKir.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnKir.Location = new System.Drawing.Point(537, 74);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(489, 50);
            this.btnKir.TabIndex = 2;
            this.btnKir.Text = "Kır";
            this.btnKir.UseVisualStyleBackColor = false;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSifirla.FlatAppearance.BorderSize = 0;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSifirla.Location = new System.Drawing.Point(24, 276);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(1002, 50);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Reset Text";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // pnlResim
            // 
            this.pnlResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlResim.Controls.Add(this.pictureBox1);
            this.pnlResim.Location = new System.Drawing.Point(24, 350);
            this.pnlResim.Name = "pnlResim";
            this.pnlResim.Size = new System.Drawing.Size(250, 250);
            this.pnlResim.TabIndex = 4;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoHeader.Location = new System.Drawing.Point(299, 363);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(129, 24);
            this.lblInfoHeader.TabIndex = 5;
            this.lblInfoHeader.Text = "Atbash Nedir?\r\n";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.Location = new System.Drawing.Point(299, 400);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(725, 168);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // tmrSifrele
            // 
            this.tmrSifrele.Enabled = true;
            this.tmrSifrele.Interval = 1;
            this.tmrSifrele.Tick += new System.EventHandler(this.tmrSifrele_Tick);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.IndianRed;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(991, 220);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "İ";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::atbashGenerator.Properties.Resources.yazi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::atbashGenerator.Properties.Resources.mc_red;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(10, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // atbashGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1050, 624);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblInfoHeader);
            this.Controls.Add(this.pnlResim);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.pnlUst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "atbashGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.atbashGenerator_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Panel pnlResim;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Timer tmrSifrele;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

