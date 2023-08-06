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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace seupet_project
{
    public partial class frmAgenda : Form
    {
        MySqlConnection bdConn = Program.bdConn;

        public static frmAgenda agenda;

        public frmAgenda()
        {
            InitializeComponent();
            agenda = this;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAgendaPet>().Count() == 0)
            {
                frmAgendaPet agenda = new frmAgendaPet();
                agenda.ShowDialog(this);
            }
            else
            {
                Form frm = Application.OpenForms["frmAgendaPet"];
                frm.ShowDialog(this);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }


        private void frmAgenda_Load(object sender, EventArgs e)
        {
            listaAgenda();
        }

        public void listaAgenda()
        {
            dgvAgenda.Rows.Clear();
            string query = "SELECT nm_pet, tp_servico, nm_tutor, dt_servico, hr_servico, vl_servico, cd_telefone, cd_agenda FROM tb_agenda JOIN tb_pet ON tb_agenda.cd_pet = tb_pet.cd_pet JOIN tb_tutor ON tb_pet.cd_tutor = tb_tutor.cd_tutor";

            MySqlCommand select = new MySqlCommand(query, bdConn);
            MySqlDataReader reader;

            bdConn.Open();
            reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nm_pet = reader.GetString(0);
                    string tp_servico = reader.GetString(1);
                    string nm_tutor = reader.GetString(2);
                    string dt_servico = reader.GetString(3).Substring(0, 10);
                    string hr_servico = reader.GetString(4).Substring(0, 5);
                    string vl_servico = reader.GetString(5);
                    string cd_telefone = reader.GetString(6);
                    string cd_agenda = reader.GetString(7);

                    dgvAgenda.Rows.Add(nm_pet, tp_servico, nm_tutor, dt_servico, hr_servico, vl_servico, cd_telefone, cd_agenda);
                }
            }
            bdConn.Close();
        }

        public DataGridViewRow text;
        public string nmPet, tpServico, nmTutor, pet, dtServico, hrServico, vlServico, cdTelefone, cdAgenda;

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgenda.Columns[e.ColumnIndex].Name == "Editar")
            {
                DataGridViewRow row = dgvAgenda.Rows[e.RowIndex];

                nmPet = row.Cells[0].Value.ToString();
                tpServico = row.Cells[1].Value.ToString();
                nmTutor = row.Cells[2].Value.ToString();
                dtServico = row.Cells[3].Value.ToString();
                hrServico = row.Cells[4].Value.ToString();
                vlServico = row.Cells[5].Value.ToString();
                cdTelefone = row.Cells[6].Value.ToString();
                cdAgenda = row.Cells[7] .Value.ToString();
                pet = $"{row.Cells[0].Value} ({cdTelefone})";

                if (Application.OpenForms.OfType<frmEditarAgenda>().Count() == 0)
                {
                    frmEditarAgenda editar = new frmEditarAgenda();
                    editar.ShowDialog(this);
                }
                else
                {
                    Form frm = Application.OpenForms["frmEditarAgenda"];
                    frm.ShowDialog(this);
                }
            }
        }
    }
}
