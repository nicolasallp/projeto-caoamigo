using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace seupet_project
{
    public partial class frmPet : Form
    {
        public static frmPet frm;

        MySqlConnection bdConn = Program.bdConn;

        public frmPet()
        {
            InitializeComponent();
            frm = this;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroPet>().Count() == 0) 
            {
                frmCadastroPet cadastro = new frmCadastroPet();
                cadastro.ShowDialog(this);
            }
            else
            {
                Form frm = Application.OpenForms["frmCadastroPet"];
                frm.ShowDialog(this);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            listar();
        }


        public void listar()
        {
            dgvPet.Rows.Clear();
            string query = "SELECT nm_pet, tp_raca, tp_porte, nm_tutor, cd_telefone, cd_cpf, cd_pet FROM tb_pet JOIN tb_tutor ON tb_pet.cd_tutor = tb_tutor.cd_tutor";

            MySqlCommand select = new MySqlCommand(query, bdConn);
            MySqlDataReader reader;

            
            bdConn.Open();
            reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nm_pet = reader.GetString(0);
                    string tp_raca = reader.GetString(1);
                    string tp_porte = reader.GetString(2);
                    string nm_tutor = reader.GetString(3);
                    string cd_telefone = reader.GetString(4);
                    string cd_cpf = reader.GetString(5);
                    string cd_pet = reader.GetString(6);

                    dgvPet.Rows.Add(nm_pet, tp_raca, tp_porte, nm_tutor, cd_telefone, cd_cpf, cd_pet);
                }
            }
            bdConn.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroTutor>().Count()==0)
            {
                frmCadastroTutor tutor = new frmCadastroTutor();
                tutor.ShowDialog(this);
            }
            else
            {
                Form frm = Application.OpenForms["frmCadastroTutor"];
                frm.ShowDialog(this);
            }
        }

        public DataGridViewRow text;
        public string nmPet, tpRaca, tpPorte, tutor, cdPet;

        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPet.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (Application.OpenForms.OfType<frmEditarPet>().Count()==0)
                {
                    frmEditarPet editar = new frmEditarPet();
                    DataGridViewRow row = dgvPet.Rows[e.RowIndex];
                   
                    nmPet = row.Cells[0].Value.ToString();
                    tpRaca = row.Cells[1].Value.ToString();
                    tpPorte = row.Cells[2].Value.ToString();
                    tutor = $"{row.Cells[3].Value} ({row.Cells[4].Value})";
                    cdPet = row.Cells[6].Value.ToString();
                    editar.ShowDialog(this);
                }
                else
                {
                    Form frm = Application.OpenForms["frmEditarPet"];
                    frm.ShowDialog(this);
                }
            }
        }
    }
}
