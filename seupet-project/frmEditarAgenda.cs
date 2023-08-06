using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seupet_project
{
    public partial class frmEditarAgenda : Form
    {
        MySqlConnection bdConn = Program.bdConn;

        public frmEditarAgenda()
        {
            InitializeComponent();
        }

        private void frmEditarAgenda_Load(object sender, EventArgs e)
        {
            string nm_pet = frmAgenda.agenda.nmPet;
            string tp_servico = frmAgenda.agenda.tpServico;
            string dt_servico = frmAgenda.agenda.dtServico;
            string hr_servico = frmAgenda.agenda.hrServico;
            string vl_servico = frmAgenda.agenda.vlServico;
            string pet = frmAgenda.agenda.pet;

            cmbTipo.Text = tp_servico;
            txtValor.Text = vl_servico;
            dtpServico.Value = Convert.ToDateTime(dt_servico);
            cmbHorario.Text = hr_servico;
            comboPet();
            cmbPet.Text = pet;
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
                while (reader.Read())
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbTipo.Text) && !string.IsNullOrEmpty(cmbPet.Text) && !string.IsNullOrEmpty(txtValor.Text) && !string.IsNullOrEmpty(cmbHorario.Text))
            {
                string selectedItem = cmbPet.SelectedItem.ToString();
                int cdPet = Convert.ToInt32(itemDictionary[selectedItem]);

                Console.WriteLine($"{cmbTipo.Text} {txtValor.Text} {cdPet} {frmAgenda.agenda.cdAgenda}");
                string query = $"UPDATE tb_agenda SET tp_servico = '{cmbTipo.Text}', vl_servico = {(txtValor.Text).Replace(",", ".")}, cd_pet = {cdPet} WHERE cd_agenda = {frmAgenda.agenda.cdAgenda}";

                bdConn.Open();
                MySqlCommand update = new MySqlCommand(query, bdConn);
                update.ExecuteNonQueryAsync();
                MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdConn.Close();

                frmAgenda.agenda.listaAgenda();

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
