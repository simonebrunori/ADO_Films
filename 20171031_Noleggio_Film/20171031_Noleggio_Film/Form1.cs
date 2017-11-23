using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _20171031_Noleggio_Film
{
    public partial class frmLogin : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader dr;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            clear();
        }
        private void clear()
        {
            txtPassword.Clear();
            txtUtente.Clear();
            btnEntra.Enabled = false;
            txtUtente.Focus();
        }

        private void txtUtente_TextChanged(object sender, EventArgs e)
        {
            if (txtUtente.Text != "" && txtPassword.Text != "")
                btnEntra.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUtente.Text != "" && txtPassword.Text != "")
                btnEntra.Enabled = true;
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {

            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                string sql_str = string.Format("select password,id from utenti where id='{0}' and password='{1}'", txtUtente.Text, txtPassword.Text);
                cmd = new OleDbCommand(sql_str, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Program.utente = dr.GetValue(1).ToString();
                    frmNoleggioFilm frm = new frmNoleggioFilm();
                    frm.Show();
                    this.Hide();
                    break;
                }
                if(!dr.HasRows)
                   MessageBox.Show("Credenziali errate!", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblRegitra_Click(object sender, EventArgs e)
        {
            frmRegistra frm = new frmRegistra();
            frm.Show();
            this.Hide();
        }
    }
}
