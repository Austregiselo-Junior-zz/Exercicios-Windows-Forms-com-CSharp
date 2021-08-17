using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Crud_DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComandosSQL comandos = new ComandosSQL();
            comandos.CarregarGridTbDimensionamento(this);
        }

        private void btnAss_Click(object sender, EventArgs e)
        {
            ComandosSQL comandos = new ComandosSQL();
            comandos.AdicionarDadosTbDimensionamento(float.Parse(TxtVolUtil.Text), float.Parse(TxtLargura.Text), float.Parse(TxtComprimento.Text), float.Parse(TxtProfundidade.Text), int.Parse(TxtQtePneus.Text));
            comandos.CarregarGridTbDimensionamento(this);
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            ComandosSQL comandos = new ComandosSQL();
            comandos.AtualizarDadosTbDimensionamento(int.Parse(TxtId.Text), float.Parse(TxtVolUtil.Text), float.Parse(TxtLargura.Text), float.Parse(TxtComprimento.Text), float.Parse(TxtProfundidade.Text), int.Parse(TxtQtePneus.Text));
            comandos.CarregarGridTbDimensionamento(this);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ComandosSQL comandos = new ComandosSQL();
            comandos.ExcluirDadosTbDimensionamentop(int.Parse(TxtId.Text));
            comandos.CarregarGridTbDimensionamento(this);
        }
    }
}
