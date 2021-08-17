
namespace Exercicios_LendoJSON
{
    partial class Frm_LendoJSON
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
        private void InitializeComponent()
        {
            this.Masl_Txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.CBO_UF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Txt_Localidade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Masl_Txt_CEP
            // 
            this.Masl_Txt_CEP.Location = new System.Drawing.Point(366, 35);
            this.Masl_Txt_CEP.Mask = "00000-9999";
            this.Masl_Txt_CEP.Name = "Masl_Txt_CEP";
            this.Masl_Txt_CEP.Size = new System.Drawing.Size(74, 20);
            this.Masl_Txt_CEP.TabIndex = 35;
            this.Masl_Txt_CEP.Text = "58046370";
            // 
            // CBO_UF
            // 
            this.CBO_UF.FormattingEnabled = true;
            this.CBO_UF.Items.AddRange(new object[] {
            "João Pessoa (PB)",
            "Rio de Janeiro (RJ)",
            "Acre (AC)",
            "Alagoas (AL)"});
            this.CBO_UF.Location = new System.Drawing.Point(137, 203);
            this.CBO_UF.Name = "CBO_UF";
            this.CBO_UF.Size = new System.Drawing.Size(85, 21);
            this.CBO_UF.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Localidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Logradouro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "CEP";
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(262, 31);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(77, 24);
            this.Btn_Pesquisar.TabIndex = 27;
            this.Btn_Pesquisar.Text = "Pesquisar";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Txt_Localidade
            // 
            this.Txt_Localidade.Location = new System.Drawing.Point(28, 203);
            this.Txt_Localidade.Name = "Txt_Localidade";
            this.Txt_Localidade.Size = new System.Drawing.Size(85, 20);
            this.Txt_Localidade.TabIndex = 25;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(137, 154);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(85, 20);
            this.Txt_Bairro.TabIndex = 24;
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(28, 154);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(85, 20);
            this.Txt_Logradouro.TabIndex = 23;
            // 
            // Frm_LendoJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 235);
            this.Controls.Add(this.Masl_Txt_CEP);
            this.Controls.Add(this.CBO_UF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Txt_Localidade);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Txt_Logradouro);
            this.Name = "Frm_LendoJSON";
            this.Text = "Lendo JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masl_Txt_CEP;
        private System.Windows.Forms.ComboBox CBO_UF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.TextBox Txt_Localidade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Logradouro;
    }
}

