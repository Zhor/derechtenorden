using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string connection = globalVariable.EditorMySQLConnect;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalVariable.name = textBox1.Text;

            MySqlConnection connectDB = new MySqlConnection(connection);
            MySqlCommand cmdSelectName = new MySqlCommand("select playername from albionprogram.player where playername='" + globalVariable.name + "';", connectDB);

            MySqlCommand cmdInsertName = new MySqlCommand("insert into albionprogram.player (playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName2 = new MySqlCommand("insert into albionprogram.playerattribute (attr_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName3 = new MySqlCommand("insert into albionprogram.playergathering (gath_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName4 = new MySqlCommand("insert into albionprogram.craftingarmor (craftarmor_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName5 = new MySqlCommand("insert into albionprogram.craftingweaponwarrior (craftweaponwarrior_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName6 = new MySqlCommand("insert into albionprogram.craftingweaponhunter (craftingweaponhunter_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName7 = new MySqlCommand("insert into albionprogram.craftingweaponmage (craftingweaponmage_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName8 = new MySqlCommand("insert into albionprogram.craftingtools (craftingtools_playername) values ('" + globalVariable.name + "');", connectDB);
            MySqlCommand cmdInsertName9 = new MySqlCommand("insert into albionprogram.playerfarming (farm_playername) values ('" + globalVariable.name + "');", connectDB);

            /*
            string lnPlayer = "SELECT playername FROM DB2885876.player where playername ='" + globalVariable.name + "';";

            MySqlCommand logPlayer = new MySqlCommand(lnPlayer, connectDB);
            */
            try
            {
                connectDB.Open();

                String lnPlayer = cmdSelectName.ExecuteScalar().ToString();

                if (lnPlayer.Equals(globalVariable.name))
                {

                    

                    /*
                    cmdInsertName.ExecuteNonQueryAsync();
                    while (!cmdInsertName.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName2.ExecuteNonQueryAsync();
                    while (!cmdInsertName2.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName3.ExecuteNonQueryAsync();
                    while (!cmdInsertName3.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName4.ExecuteNonQueryAsync();
                    while (!cmdInsertName4.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName5.ExecuteNonQueryAsync();
                    while (!cmdInsertName5.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName6.ExecuteNonQueryAsync();
                    while (!cmdInsertName6.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName7.ExecuteNonQueryAsync();
                    while (!cmdInsertName7.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    cmdInsertName8.ExecuteNonQueryAsync();
                    while (!cmdInsertName8.ExecuteNonQueryAsync().IsCompleted)
                    {
                        Thread.Sleep(100);
                        label2.Text = "...";
                    }
                    */
                    MessageBox.Show("Willkommen " + textBox1.Text);
                }
                connectDB.Close();
            }
            catch (MySqlException mecx)
            {
                MessageBox.Show("Zugriff fehlgeschlagen!" + mecx.Number);
                MessageBox.Show("" + mecx.Message);
                this.Close();
            }
            catch (Exception exc)
            {

                cmdInsertName.ExecuteNonQueryAsync();
                cmdInsertName2.ExecuteNonQueryAsync();
                cmdInsertName3.ExecuteNonQueryAsync();
                cmdInsertName4.ExecuteNonQueryAsync();
                cmdInsertName5.ExecuteNonQueryAsync();
                cmdInsertName6.ExecuteNonQueryAsync();
                cmdInsertName7.ExecuteNonQueryAsync();
                cmdInsertName8.ExecuteNonQueryAsync();
                cmdInsertName9.ExecuteNonQueryAsync();

                MessageBox.Show("Spieler " + textBox1.Text + " hinzugefügt!");

                //MessageBox.Show("" + exc.Message);
                //this.Close();
            }

            globalVariable.name = textBox1.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
