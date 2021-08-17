
namespace Exercicios_Crud_DatabaseFirst
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAss = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.TxtVolUtil = new System.Windows.Forms.TextBox();
            this.TxtLargura = new System.Windows.Forms.TextBox();
            this.TxtComprimento = new System.Windows.Forms.TextBox();
            this.TxtProfundidade = new System.Windows.Forms.TextBox();
            this.TxtQtePneus = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAss
            // 
            this.btnAss.Location = new System.Drawing.Point(273, 367);
            this.btnAss.Name = "btnAss";
            this.btnAss.Size = new System.Drawing.Size(151, 33);
            this.btnAss.TabIndex = 1;
            this.btnAss.Text = "Adicionar";
            this.btnAss.UseVisualStyleBackColor = true;
            this.btnAss.Click += new System.EventHandler(this.btnAss_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(442, 367);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(151, 33);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(613, 367);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(151, 33);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // TxtVolUtil
            // 
            this.TxtVolUtil.Location = new System.Drawing.Point(32, 143);
            this.TxtVolUtil.Name = "TxtVolUtil";
            this.TxtVolUtil.Size = new System.Drawing.Size(100, 20);
            this.TxtVolUtil.TabIndex = 4;
            // 
            // TxtLargura
            // 
            this.TxtLargura.Location = new System.Drawing.Point(32, 169);
            this.TxtLargura.Name = "TxtLargura";
            this.TxtLargura.Size = new System.Drawing.Size(100, 20);
            this.TxtLargura.TabIndex = 5;
            // 
            // TxtComprimento
            // 
            this.TxtComprimento.Location = new System.Drawing.Point(32, 195);
            this.TxtComprimento.Name = "TxtComprimento";
            this.TxtComprimento.Size = new System.Drawing.Size(100, 20);
            this.TxtComprimento.TabIndex = 6;
            // 
            // TxtProfundidade
            // 
            this.TxtProfundidade.Location = new System.Drawing.Point(32, 221);
            this.TxtProfundidade.Name = "TxtProfundidade";
            this.TxtProfundidade.Size = new System.Drawing.Size(100, 20);
            this.TxtProfundidade.TabIndex = 7;
            // 
            // TxtQtePneus
            // 
            this.TxtQtePneus.Location = new System.Drawing.Point(32, 247);
            this.TxtQtePneus.Name = "TxtQtePneus";
            this.TxtQtePneus.Size = new System.Drawing.Size(100, 20);
            this.TxtQtePneus.TabIndex = 8;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(32, 117);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(45, 20);
            this.TxtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Largura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Comprimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Volume útil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Profundidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantidade de pneus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtQtePneus);
            this.Controls.Add(this.TxtProfundidade);
            this.Controls.Add(this.TxtComprimento);
            this.Controls.Add(this.TxtLargura);
            this.Controls.Add(this.TxtVolUtil);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnAss);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAss;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.TextBox TxtVolUtil;
        private System.Windows.Forms.TextBox TxtLargura;
        private System.Windows.Forms.TextBox TxtComprimento;
        private System.Windows.Forms.TextBox TxtProfundidade;
        private System.Windows.Forms.TextBox TxtQtePneus;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

