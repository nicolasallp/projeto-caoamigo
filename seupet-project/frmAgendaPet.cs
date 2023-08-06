using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace seupet_project
{
    public partial class frmAgendaPet : Form
    {
        MySqlConnection bdConn = Program.bdConn;

        public frmAgendaPet()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbTipo.Text) && !string.IsNullOrEmpty(cmbPet.Text) && !string.IsNullOrEmpty(txtValor.Text) && !string.IsNullOrEmpty(cmbHorario.Text))
            {
                int cdPet = Convert.ToInt32(itemDictionary[cmbPet.Text]);
                string tipoServico = cmbTipo.Text;
                string dataServico = dtpServico.Value.ToString("yyyy-MM-dd");
                string horaServico = cmbHorario.Text;
                string valorServico = txtValor.Text.Replace("R$ ", "");

                string query = $"INSERT INTO tb_agenda(cd_pet, tp_servico, dt_servico, hr_servico ,vl_servico) VALUES ({cdPet}, '{tipoServico}', '{dataServico}', '{horaServico}', '{valorServico}')";

                Console.WriteLine(cdPet);

                bdConn.Open();
                MySqlCommand insert = new MySqlCommand(query, bdConn);
                insert.ExecuteNonQueryAsync();
                MessageBox.Show("Serviço agendado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdConn.Close();

                frmAgenda.agenda.listaAgenda();

                this.Close();

            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Agenda", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void frmAgendaPet_Load(object sender, EventArgs e)
        {
            txtValor.SelectionStart = txtValor.Text.Length;
            comboPet();
        }

        private Dictionary<string, string> itemDictionary;

        public void comboPet()
        {
            string query = "SELECT nm_pet, cd_telefone, tb_pet.cd_pet FROM tb_pet JOIN tb_tutor ON tb_pet.cd_tutor = tb_tutor.cd_tutor";

            MySqlCommand select = new MySqlCommand(query, bdConn);
            MySqlDataReader reader;

            bdConn.Open();
            reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                itemDictionary = new Dictionary<string, string>();
                while(reader.Read())
                {
                    string nm_pet = reader.GetString(0);
                    string cd_telefone = reader.GetString(1);
                    string cd_pet = reader.GetString(2);

                    itemDictionary.Add($"{nm_pet} ({cd_telefone})", cd_pet);
                }
                cmbPet.Items.AddRange(itemDictionary.Keys.ToArray());
            }
            bdConn.Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.SelectionStart = txtValor.Text.Length;
            string txt = txtValor.Text.Replace("R$ ", "");
            txt = txt.Replace(",", "");
            if (Regex.IsMatch(txt, "^[0-9]+$"))
            {
                if (txt.Length >= 3)
                {
                    txt = txt.Substring(0, txt.Length - 2) + "," + txt.Substring(txt.Length - 2);
                }
                txtValor.Text = "R$ " + txt;
                txtValor.SelectionStart = txtValor.Text.Length;
            }
            else
            {
                txtValor.Text = "R$ ";
            }
        }


        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
