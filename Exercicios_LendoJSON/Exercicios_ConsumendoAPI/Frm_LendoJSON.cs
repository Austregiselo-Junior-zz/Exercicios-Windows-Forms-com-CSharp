using Exercicios_LendoJSON.Models.Entities;
using Exercicios_LendoJSON.Models.Services;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Exercicios_LendoJSON
{
    public partial class Frm_LendoJSON : Form
    {
        public Frm_LendoJSON()
        {
            InitializeComponent();
        }
              

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string cep = Masl_Txt_CEP.Text;
            if (cep != "" & cep.Length == 9) // Verificação na view
            {
                try
                {
                    var entity = new Entity();
                    var vJson = JsonProcess.GerarJsoneToString(Masl_Txt_CEP.Text);
                    entity = JsonProcess.Deserializador(vJson);
                    entity.ValidateEntity(); // Validação em nível de modelo de entidades

                    Txt_Logradouro.Text = entity.logradouro;
                    Txt_Bairro.Text = entity.bairro;
                    Txt_Localidade.Text = entity.localidade;

                    CBO_UF.SelectedIndex = -1; // Seleção vo vazio se o CEP não for válido
                    for (int i = 0; i <= CBO_UF.Items.Count - 1; i++)
                    {
                        var vPos = Strings.InStr(CBO_UF.Items[i].ToString(), "(" + entity.uf + ")");
                        if (vPos > 0)
                        {
                            CBO_UF.SelectedIndex = i; // Add o CEP quando i tem as caracteristicas acima.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campo incorreto!");
            }
        }
    }
}
