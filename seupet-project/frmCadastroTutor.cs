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
using System.Windows.Input;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace seupet_project
{
    public partial class frmCadastroTutor : Form
    {
        MySqlConnection bdConn = Program.bdConn;
        public frmCadastroTutor()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCPF.Text) && !string.IsNullOrEmpty(txtNomeTutor.Text) && !string.IsNullOrEmpty(txtTelefone.Text))
            {
                string cpf = txtCPF.Text;
                string telefone = txtTelefone.Text;
                string nome = txtNomeTutor.Text;

                string query = $"INSERT INTO tb_tutor(cd_cpf, cd_telefone, nm_tutor) VALUES('{cpf}', '{telefone}', '{nome}')";

                bdConn.Open();
                MySqlCommand insert = new MySqlCommand(query, bdConn);
                insert.ExecuteNonQueryAsync();
                MessageBox.Show("Tutor cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdConn.Close();
            }

            txtCPF.Clear();
            txtNomeTutor.Clear();
            txtTelefone.Clear();
            txtNomeTutor.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtNomeTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && (char.IsDigit(e.KeyChar)))
            {
                if (txtCPF.TextLength < 14)
                {
                    txtCPF.SelectionStart = txtCPF.Text.Length;
                    string txt = txtCPF.Text;

                    if (txt.Length == 3)
                    {
                        txt = txt.Substring(0, 3) + ".";
                    }
                    else if (txt.Length == 7)
                    {
                        txt = txt.Substring(0, 7) + ".";
                    }
                    else if (txt.Length == 11)
                    {
                        txt = txt.Substring(0, 11) + "-";
                    }
                    txtCPF.Text = txt;
                    txtCPF.SelectionStart = txtCPF.Text.Length;
                }
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
