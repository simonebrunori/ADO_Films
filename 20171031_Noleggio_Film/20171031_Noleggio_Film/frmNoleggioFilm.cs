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
    public partial class frmNoleggioFilm : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;
        public frmNoleggioFilm()
        {
            InitializeComponent();
        }
        private string cod_f = null;

        private void frmNoleggioFilm_Load(object sender, EventArgs e)
        {
            //DATAREADER
            noleggiaToolStripMenuItem.Enabled = false;
            restituisciToolStripMenuItem.Enabled = false;
            string sql_str;
            cmbGenere.Items.Add("Tutti");
            cmbGenere.SelectedItem = "Tutti";
            UserToolStripMenuItem.Text = Program.utente;
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                sql_str = string.Format("select distinct genere from film");
                cmd = new OleDbCommand(sql_str, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbGenere.Items.Add(dr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            sql_str = string.Format("select noleggi.cod_f,titolo,data_noleggio,data_restituzione from noleggi,film where noleggi.cod_f=film.cod_f and id='{0}'", Program.utente);
            eseguiQuery(sql_str, "noleggi",dataGridNoleggi);
        }
           
        private void noleggiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DML
            string sql_str;
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                sql_str = string.Format("insert into noleggi values('{0}','{1}',#{2}#,#{3}#)", Program.utente, cod_f, DateTime.Now.ToString("dd/MM/yyyy"), dateTimeRest.Value.ToString("dd/MM/yyyy"));
                cmd = new OleDbCommand(sql_str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                int disponibilita = nCopie(cod_f);
                conn.Open();
                sql_str = string.Format("update film set Disponibilita={0} where cod_f='{1}'", disponibilita-1, cod_f);
                cmd = new OleDbCommand(sql_str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Il noleggio è stato eseguito correttamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            sql_str = string.Format("select noleggi.cod_f,titolo,data_noleggio,data_restituzione from noleggi,film where noleggi.cod_f=film.cod_f and id='{0}'", Program.utente);
            eseguiQuery(sql_str, "noleggi", dataGridNoleggi);
            sql_str = string.Format(cmbGenere.SelectedItem.ToString() == "Tutti" ? "select * from film" : "select * from film where genere='{0}'", cmbGenere.SelectedItem.ToString());
            eseguiQuery(sql_str, "genere", dataGridFilm);
            noleggiaToolStripMenuItem.Enabled = false;
            pulisci();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void cmbGenere_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_str = string.Format(cmbGenere.SelectedItem.ToString() == "Tutti" ? "select * from film" : "select * from film where genere='{0}'", cmbGenere.SelectedItem.ToString());
            eseguiQuery(sql_str, "genere",dataGridFilm);
        }

        private void frmNoleggioFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtTitolo_TextChanged(object sender, EventArgs e)
        {
            string sql_str = string.Format("select * from film where titolo like '%{0}%'", txtTitolo.Text);
            eseguiQuery(sql_str, "titolo",dataGridFilm);
            
        }
        private void eseguiQuery(string sql_str,string member, DataGridView dgv)
        {
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                da = new OleDbDataAdapter(sql_str, conn);
                ds = new DataSet();
                da.Fill(ds, member);
                dgv.DataSource = ds;
                dgv.DataMember = member;
                if (member=="genere" || member=="titolo")
                {
                    foreach(DataGridViewRow row in dgv.Rows)
                    {
                        if(Convert.ToInt32(row.Cells[6].Value) > 2)
                            row.Cells[6].Style.BackColor = Color.Green;
                        else if(Convert.ToInt32(row.Cells[6].Value) > 0)
                            row.Cells[6].Style.BackColor = Color.Yellow;
                        else if(Convert.ToInt32(row.Cells[6].Value) ==0)
                            row.Cells[6].Style.BackColor = Color.Red;
                    }
                }else if(member=="noleggi")
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if ((Convert.ToDateTime(row.Cells[3].Value)- Convert.ToDateTime(row.Cells[2].Value)).TotalDays > 4)
                            row.Cells[3].Style.BackColor = Color.Green;
                        else if ((Convert.ToDateTime(row.Cells[3].Value) - Convert.ToDateTime(row.Cells[2].Value)).TotalDays >1 )
                            row.Cells[3].Style.BackColor = Color.Yellow;
                        else if ((Convert.ToDateTime(row.Cells[3].Value) - Convert.ToDateTime(row.Cells[2].Value)).TotalDays >= 0)
                        {
                            row.Cells[3].Style.BackColor = Color.Red;
                            MessageBox.Show("Attenzione, rimane meno di un giorno per la restituzione del film " + row.Cells[1].Value + " !", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                            
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAREADER
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                string sql_str = string.Format("select film.* from film where cod_f='"+ dataGridFilm.SelectedCells[0].Value.ToString()+"'");
                cmd = new OleDbCommand(sql_str, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTitolo1.Text = dr.GetValue(1).ToString();
                    txtGenere1.Text = dr.GetValue(2).ToString();
                    txtAnno.Text = dr.GetValue(3).ToString();
                    txtNazione.Text = dr.GetValue(5).ToString();
                    txtRegista.Text = dr.GetValue(4).ToString();
                    txtNolo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    cod_f = dr.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            if (nCopie(cod_f) > 0)
                noleggiaToolStripMenuItem.Enabled = true;
        }

        private void dateTimeRest_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Now;
            endDate = endDate.AddDays(10);
            if (dateTimeRest.Value > endDate || dateTimeRest.Value < DateTime.Now)
            {
                MessageBox.Show("La data non può essere precedente alla data odierna e non è possibile noleggiare un film per più di 10 giorni!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimeRest.ResetText();
            }
        }

        private void restituisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql_str;
            int selectedrowindex = dataGridNoleggi.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridNoleggi.Rows[selectedrowindex];

            string codF = Convert.ToString(selectedRow.Cells[0].Value);
            conn = new OleDbConnection(Program.conn_str);
            try
            {
                conn.Open();
                sql_str = string.Format("delete from noleggi where cod_f='{0}'", codF);
                cmd = new OleDbCommand(sql_str, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                int disponibilita = nCopie(codF);
                conn.Open();
                sql_str = string.Format("update film set Disponibilita={0} where cod_f='{1}'",disponibilita+1 , codF);
                cmd = new OleDbCommand(sql_str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Il film è stato restituito con successo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            sql_str = string.Format("select noleggi.cod_f,titolo,data_noleggio,data_restituzione from noleggi,film where noleggi.cod_f=film.cod_f and id='{0}'", Program.utente);
            eseguiQuery(sql_str, "noleggi", dataGridNoleggi);
            sql_str = string.Format(cmbGenere.SelectedItem.ToString() == "Tutti" ? "select * from film" : "select * from film where genere='{0}'", cmbGenere.SelectedItem.ToString());
            eseguiQuery(sql_str, "genere", dataGridFilm);
            restituisciToolStripMenuItem.Enabled = false;
        }
        private int nCopie(string codF)
        {
            conn = new OleDbConnection(Program.conn_str);
            int disp=0;
            try
            {
                conn.Open();
                string sql_str = string.Format("select disponibilita from film where cod_f='{0}'", codF);
                cmd = new OleDbCommand(sql_str, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    disp=Convert.ToInt32(dr.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            return disp;
        }

        private void dataGridNoleggi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            restituisciToolStripMenuItem.Enabled = true;
        }
        private void pulisci()
        {
            txtAnno.Clear();
            txtGenere1.Clear();
            txtNazione.Clear();
            txtNolo.Clear();
            txtRegista.Clear();
            txtTitolo1.Clear();
        }
    }
}
