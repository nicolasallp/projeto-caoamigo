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
    public partial class frmEditarPet : Form
    {
        MySqlConnection bdConn = Program.bdConn;
        public frmEditarPet()
        {
            InitializeComponent();
        }

        private void frmEditarPet_Load(object sender, EventArgs e)
        {
            string nm_pet = frmPet.frm.nmPet;
            string tp_raca = frmPet.frm.tpRaca;
            string tp_porte = frmPet.frm.tpPorte;
            string tutor = frmPet.frm.tutor;

            txtNomePet.Text = nm_pet;
            txtRaca.Text = tp_raca;
            cmbPorte.Text = tp_porte;
            listaTutor();
            cmbTutor.Text = tutor;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<string, string> itemDictionary;

        public void listaTutor()
        {
            string query = "SELECT  cd_tutor, nm_tutor, cd_telefone FROM tb_tutor";

            MySqlCommand select = new MySqlCommand(query, bdConn);
            MySqlDataReader reader;

            bdConn.Open();
            reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                itemDictionary = new Dictionary<string, string>();

                while (reader.Read())
                {
                    string cd_tutor = reader.GetString(0);
                    string nm_tutor = reader.GetString(1);
                    string cd_telefone = reader.GetString(2);

                    itemDictionary.Add($"{nm_tutor} ({cd_telefone})", cd_tutor);
                }
                cmbTutor.Items.AddRange(itemDictionary.Keys.ToArray());

            }
            bdConn.Close();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomePet.Text) && !string.IsNullOrEmpty(txtRaca.Text) && !string.IsNullOrEmpty(cmbPorte.Text))
            {
                string selectedItem = cmbTutor.SelectedItem.ToString();
                int cdTutor = Convert.ToInt32(itemDictionary[selectedItem]);

                string query = $"UPDATE tb_pet SET nm_pet = '{txtNomePet.Text}', tp_raca = '{txtRaca.Text}', tp_porte = '{cmbPorte.Text}', cd_tutor = {cdTutor} WHERE cd_pet = {frmPet.frm.cdPet}";

                bdConn.Open();
                MySqlCommand update = new MySqlCommand(query, bdConn);
                update.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdConn.Close();

                frmPet.frm.listar();

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
