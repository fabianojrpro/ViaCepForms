namespace ViaCep
{
    partial class Frm_ViaCep
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ViaCep));
            this.Btn_Click_Close = new System.Windows.Forms.Button();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Tbx_Cep = new System.Windows.Forms.TextBox();
            this.Lbl_Rua = new System.Windows.Forms.Label();
            this.Tbx_Rua = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Tbx_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Localidade = new System.Windows.Forms.Label();
            this.Tbx_Localidade = new System.Windows.Forms.TextBox();
            this.Lbl_Uf = new System.Windows.Forms.Label();
            this.Tbx_Uf = new System.Windows.Forms.TextBox();
            this.Btn_Click_Consultar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Click_Close
            // 
            this.Btn_Click_Close.Location = new System.Drawing.Point(685, 409);
            this.Btn_Click_Close.Name = "Btn_Click_Close";
            this.Btn_Click_Close.Size = new System.Drawing.Size(103, 29);
            this.Btn_Click_Close.TabIndex = 0;
            this.Btn_Click_Close.Text = "Fechar";
            this.Btn_Click_Close.UseVisualStyleBackColor = true;
            this.Btn_Click_Close.Click += new System.EventHandler(this.Btn_Click_Close_Click);
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cep.Location = new System.Drawing.Point(217, 192);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(42, 18);
            this.Lbl_Cep.TabIndex = 2;
            this.Lbl_Cep.Text = "Cep:";
            // 
            // Tbx_Cep
            // 
            this.Tbx_Cep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Cep.Location = new System.Drawing.Point(313, 192);
            this.Tbx_Cep.Name = "Tbx_Cep";
            this.Tbx_Cep.Size = new System.Drawing.Size(195, 22);
            this.Tbx_Cep.TabIndex = 3;
            this.Tbx_Cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbx_Cep_KeyDown);
            // 
            // Lbl_Rua
            // 
            this.Lbl_Rua.AutoSize = true;
            this.Lbl_Rua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rua.Location = new System.Drawing.Point(217, 224);
            this.Lbl_Rua.Name = "Lbl_Rua";
            this.Lbl_Rua.Size = new System.Drawing.Size(40, 18);
            this.Lbl_Rua.TabIndex = 5;
            this.Lbl_Rua.Text = "Rua:";
            this.Lbl_Rua.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tbx_Rua
            // 
            this.Tbx_Rua.Enabled = false;
            this.Tbx_Rua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Rua.Location = new System.Drawing.Point(313, 225);
            this.Tbx_Rua.Name = "Tbx_Rua";
            this.Tbx_Rua.Size = new System.Drawing.Size(195, 22);
            this.Tbx_Rua.TabIndex = 6;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bairro.Location = new System.Drawing.Point(217, 263);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(55, 18);
            this.Lbl_Bairro.TabIndex = 7;
            this.Lbl_Bairro.Text = "Bairro:";
            // 
            // Tbx_Bairro
            // 
            this.Tbx_Bairro.Enabled = false;
            this.Tbx_Bairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Bairro.Location = new System.Drawing.Point(313, 264);
            this.Tbx_Bairro.Name = "Tbx_Bairro";
            this.Tbx_Bairro.Size = new System.Drawing.Size(195, 22);
            this.Tbx_Bairro.TabIndex = 8;
            // 
            // Lbl_Localidade
            // 
            this.Lbl_Localidade.AutoSize = true;
            this.Lbl_Localidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Localidade.Location = new System.Drawing.Point(217, 300);
            this.Lbl_Localidade.Name = "Lbl_Localidade";
            this.Lbl_Localidade.Size = new System.Drawing.Size(90, 18);
            this.Lbl_Localidade.TabIndex = 9;
            this.Lbl_Localidade.Text = "Localidade:";
            // 
            // Tbx_Localidade
            // 
            this.Tbx_Localidade.Enabled = false;
            this.Tbx_Localidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Localidade.Location = new System.Drawing.Point(313, 301);
            this.Tbx_Localidade.Name = "Tbx_Localidade";
            this.Tbx_Localidade.Size = new System.Drawing.Size(195, 22);
            this.Tbx_Localidade.TabIndex = 10;
            // 
            // Lbl_Uf
            // 
            this.Lbl_Uf.AutoSize = true;
            this.Lbl_Uf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Uf.Location = new System.Drawing.Point(217, 337);
            this.Lbl_Uf.Name = "Lbl_Uf";
            this.Lbl_Uf.Size = new System.Drawing.Size(33, 18);
            this.Lbl_Uf.TabIndex = 11;
            this.Lbl_Uf.Text = "UF:";
            // 
            // Tbx_Uf
            // 
            this.Tbx_Uf.Enabled = false;
            this.Tbx_Uf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Uf.Location = new System.Drawing.Point(313, 338);
            this.Tbx_Uf.Name = "Tbx_Uf";
            this.Tbx_Uf.Size = new System.Drawing.Size(195, 22);
            this.Tbx_Uf.TabIndex = 12;
            // 
            // Btn_Click_Consultar
            // 
            this.Btn_Click_Consultar.Location = new System.Drawing.Point(576, 409);
            this.Btn_Click_Consultar.Name = "Btn_Click_Consultar";
            this.Btn_Click_Consultar.Size = new System.Drawing.Size(103, 29);
            this.Btn_Click_Consultar.TabIndex = 13;
            this.Btn_Click_Consultar.Text = "Consultar";
            this.Btn_Click_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Click_Consultar.Click += new System.EventHandler(this.Btn_Click_Consultar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(433, 366);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 14;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 167);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ViaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Click_Consultar);
            this.Controls.Add(this.Tbx_Uf);
            this.Controls.Add(this.Lbl_Uf);
            this.Controls.Add(this.Tbx_Localidade);
            this.Controls.Add(this.Lbl_Localidade);
            this.Controls.Add(this.Tbx_Bairro);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Tbx_Rua);
            this.Controls.Add(this.Lbl_Rua);
            this.Controls.Add(this.Tbx_Cep);
            this.Controls.Add(this.Lbl_Cep);
            this.Controls.Add(this.Btn_Click_Close);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MaximizeBox = false;
            this.Name = "Frm_ViaCep";
            this.Text = "CEP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Click_Close;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.TextBox Tbx_Cep;
        private System.Windows.Forms.Label Lbl_Rua;
        private System.Windows.Forms.TextBox Tbx_Rua;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.TextBox Tbx_Bairro;
        private System.Windows.Forms.Label Lbl_Localidade;
        private System.Windows.Forms.TextBox Tbx_Localidade;
        private System.Windows.Forms.Label Lbl_Uf;
        private System.Windows.Forms.TextBox Tbx_Uf;
        private System.Windows.Forms.Button Btn_Click_Consultar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

