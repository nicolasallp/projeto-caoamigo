using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace seupet_project
{

    public partial class frmCadastroPet : Form
    {
        MySqlConnection bdConn = Program.bdConn;

        public static frmCadastroPet frm;
        public frmCadastroPet()
        {
            InitializeComponent();
            frm = this;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroPet_Load(object sender, EventArgs e)
        {
            listaTutor();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomePet.Text) && !string.IsNullOrEmpty(txtRaca.Text) && !string.IsNullOrEmpty(cmbPorte.Text))
            {
                string selectedItem = cmbTutor.SelectedItem.ToString();
                int cdTutor = Convert.ToInt32(itemDictionary[selectedItem]); ;
                string nomePet = txtNomePet.Text;
                string raca = txtRaca.Text;
                string porte = cmbPorte.Text;

                string query = $"INSERT INTO tb_pet(cd_tutor, nm_pet, tp_raca, tp_porte) VALUES('{cdTutor}', '{nomePet}', '{raca}', '{porte}')";

                bdConn.Open();
                MySqlCommand inserir = new MySqlCommand(query, bdConn);
                inserir.ExecuteNonQueryAsync();
                MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdConn.Close();

                frmPet.frm.listar();

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
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
    }
}
