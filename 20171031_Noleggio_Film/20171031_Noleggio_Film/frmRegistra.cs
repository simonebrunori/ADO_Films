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
    public partial class frmRegistra : Form
    {
        public bool ID=true;
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader dr;
        public frmRegistra()
        {
            InitializeComponent();
        }

        private void frmRegistra_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtRipPass.UseSystemPasswordChar = true;
            clear();
        }

        private void frmRegistra_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

        }
        private void clear()
        {
            lblMail.Hide();
            lblPass.Hide();
            lblID.Hide();
            txtPassword.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtNominativo.Clear();
            txtRipPass.Clear();
            ckbNews.Checked = false;
            btnConferma.Enabled = false;
            txtNominativo.Focus();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            string sql_str;
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                sql_str = string.Format("insert into utenti values('{0}','{1}','{2}','{3}',{4})", txtID.Text, txtPassword.Text, txtNominativo.Text, txtEmail.Text, ckbNews.Checked);
                cmd = new OleDbCommand(sql_str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complimenti, la registrazione è andata a buon fine!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        private bool controllaMail(string mail)
        {
            if (mail.Contains('@'))
                return true;
            return false;

        }
        private bool controllaPassword(string pass1, string pass2)
        {
            if (pass2 == pass1)
                return true;
            return false;
        }

        private void txtNominativo_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtID.Text != "" && txtNominativo.Text != "" && txtPassword.Text != "" && txtRipPass.Text != "" && ID && controllaMail(txtEmail.Text) && controllaPassword(txtPassword.Text, txtRipPass.Text))
                btnConferma.Enabled = true;
            else
                btnConferma.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string sql_str;
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                sql_str = string.Format("select * from utenti where ID='{0}'", txtID.Text);
                cmd = new OleDbCommand(sql_str, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ID = false;
                    lblID.Show();
                }
                else
                {
                    ID = true;
                    lblID.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            if (txtEmail.Text != "" && txtID.Text != "" && txtNominativo.Text != "" && txtPassword.Text != "" && txtRipPass.Text != "" && ID && controllaMail(txtEmail.Text) && controllaPassword(txtPassword.Text, txtRipPass.Text))
                btnConferma.Enabled = true;
            else
                btnConferma.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!controllaMail(txtEmail.Text))
                lblMail.Show();
            else
                lblMail.Hide();
            if (txtEmail.Text != "" && txtID.Text != "" && txtNominativo.Text != "" && txtPassword.Text != "" && txtRipPass.Text != "" && ID && controllaMail(txtEmail.Text) && controllaPassword(txtPassword.Text, txtRipPass.Text))
                btnConferma.Enabled = true;
            else
                btnConferma.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtID.Text != "" && txtNominativo.Text != "" && txtPassword.Text != "" && txtRipPass.Text != "" && ID && controllaMail(txtEmail.Text) && controllaPassword(txtPassword.Text, txtRipPass.Text))
                btnConferma.Enabled = true;
            else
                btnConferma.Enabled = false;
        }

        private void txtRipPass_TextChanged(object sender, EventArgs e)
        {
            if (!controllaPassword(txtPassword.Text, txtRipPass.Text))
                lblPass.Show();
            else
                lblPass.Hide();
            if (txtEmail.Text != "" && txtID.Text != "" && txtNominativo.Text != "" && txtPassword.Text != "" && txtRipPass.Text != "" && ID && controllaMail(txtEmail.Text) && controllaPassword(txtPassword.Text, txtRipPass.Text))
                btnConferma.Enabled = true;
            else
                btnConferma.Enabled = false;
        }
    }
}
