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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        private string connection = globalVariable.EditorMySQLConnect;
        private MySqlConnection connectDB;

        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        private BindingSource bindingsSource1 = new BindingSource();

        private Form4 klasse,refine,crftwaffe,crftarmor,crfteco,crfttools;


        public Form2()
        {

            InitializeComponent();

            connectDB = new MySqlConnection(connection);
 
        }
        
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void charakterHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            if (Application.OpenForms["Form3"] == null)
            {
                frm3.TopMost = true;
                frm3.Show();
            }
            else
            {
                Application.OpenForms["Form3"].BringToFront();
            }          
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void klasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 1;
            klasse = new Form4();
            klasse.MdiParent = this;
            klasse.Text = "Klasse";
            klasse.Show();
        }

        private void gatheringRefiningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 2;
            refine = new Form4();
            refine.MdiParent = this;
            refine.Text = "Gathering & Refining";
            refine.Show();
        }

        private void craftingRüstungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 4;
            crftarmor = new Form4();
            crftarmor.MdiParent = this;
            crftarmor.Text = "Crafting Rüstung";
            crftarmor.Show();
        }

        private void craftingWerkzeugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 5;
            crfteco = new Form4();
            crfteco.MdiParent = this;
            crfteco.Text = "Crafting Werkzeuge";
            crfteco.Show();
        }

        private void landwirtschaftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 6;
            crfttools = new Form4();
            crfttools.MdiParent = this;
            crfttools.Text = "Landwirtschaft";
            crfttools.Show();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            initStats();
            timer1.Enabled = true;
        }

        private void initStats()
        {
            string cntPlayer = "select count(*) from albionprogram.player;";

            MySqlCommand countPlayer = new MySqlCommand(cntPlayer, connectDB);

            string cntTank = "select attrib_count from albionprogram.arsenal where attrib_value = 'attr_tank';";

            //string cntTank = "select count(*) from albionprogram.playerattribute where attr_tank = 'X';";
            string cntSingleMelee = "select count(*) from albionprogram.playerattribute where attr_ddsinglemelee = 'X';";
            string cntSingleRange = "select count(*) from albionprogram.playerattribute where attr_ddsinglerange = 'X';";
            string cntSingleHeal = "select count(*) from albionprogram.playerattribute where attr_singleheal = 'X';";
            string cntAoEMelee = "select count(*) from albionprogram.playerattribute where attr_ddaoemelee = 'X';";
            string cntAoERange = "select count(*) from albionprogram.playerattribute where attr_ddaorrange = 'X';";
            string cntAoEHeal = "select count(*) from albionprogram.playerattribute where attr_aoeheal = 'X';";
            string cntSupport = "select count(*) from albionprogram.playerattribute where attr_support = 'X';";

            MySqlCommand countTank = new MySqlCommand(cntTank, connectDB);
            MySqlCommand countSingleMelee = new MySqlCommand(cntSingleMelee, connectDB);
            MySqlCommand countSingleRange = new MySqlCommand(cntSingleRange, connectDB);
            MySqlCommand countSingleHeal = new MySqlCommand(cntSingleHeal, connectDB);
            MySqlCommand countAoEMelee = new MySqlCommand(cntAoEMelee, connectDB);
            MySqlCommand countAoERange = new MySqlCommand(cntAoERange, connectDB);
            MySqlCommand countAoEHeal = new MySqlCommand(cntAoEHeal, connectDB);
            MySqlCommand countSupport = new MySqlCommand(cntSupport, connectDB);

            string cntErz = "select count(*) from albionprogram.playergathering where erz > 4;";
            string cntHolz = "select count(*) from albionprogram.playergathering where holz > 4;";
            string cntWolle = "select count(*) from albionprogram.playergathering where wolle > 4;";
            string cntFell = "select count(*) from albionprogram.playergathering where fell > 4;";
            string cntStein = "select count(*) from albionprogram.playergathering where stein > 4;";

            string cntMetall = "select count(*) from albionprogram.playergathering where metall > 4;";
            string cntPlanke = "select count(*) from albionprogram.playergathering where planke > 4;";
            string cntStoff = "select count(*) from albionprogram.playergathering where stoff > 4;";
            string cntLeder = "select count(*) from albionprogram.playergathering where leder > 4;";
            string cntSteinblock = "select count(*) from albionprogram.playergathering where steinblock > 4;";

            MySqlCommand countErz = new MySqlCommand(cntErz, connectDB);
            MySqlCommand countHolz = new MySqlCommand(cntHolz, connectDB);
            MySqlCommand countWolle = new MySqlCommand(cntWolle, connectDB);
            MySqlCommand countFell = new MySqlCommand(cntFell, connectDB);
            MySqlCommand countStein = new MySqlCommand(cntStein, connectDB);

            MySqlCommand countMetall = new MySqlCommand(cntMetall, connectDB);
            MySqlCommand countPlanke = new MySqlCommand(cntPlanke, connectDB);
            MySqlCommand countStoff = new MySqlCommand(cntStoff, connectDB);
            MySqlCommand countLeder = new MySqlCommand(cntLeder, connectDB);
            MySqlCommand countSteinblock = new MySqlCommand(cntSteinblock, connectDB);
            
            try
            {
                connectDB.Open();
                //Mitglieder
                string resultPlayer = countPlayer.ExecuteScalar().ToString();

                //Klasse
                string resultTank = countTank.ExecuteScalar().ToString();
                string resultSingleMelee = countSingleMelee.ExecuteScalar().ToString();
                string resultSingleRange = countSingleRange.ExecuteScalar().ToString();
                string resultSingleHeal = countSingleHeal.ExecuteScalar().ToString();
                string resultAoEMelee = countAoEMelee.ExecuteScalar().ToString();
                string resultAoERange = countAoERange.ExecuteScalar().ToString();
                string resultAoEHeal = countAoEHeal.ExecuteScalar().ToString();
                string resultSupport = countSupport.ExecuteScalar().ToString();

                //Gathering
                string resultErz = countErz.ExecuteScalar().ToString();
                string resultHolz = countHolz.ExecuteScalar().ToString();
                string resultWolle = countWolle.ExecuteScalar().ToString();
                string resultFell = countFell.ExecuteScalar().ToString();
                string resultStein = countStein.ExecuteScalar().ToString();

                //Refining
                string resultMetall = countMetall.ExecuteScalar().ToString();
                string resultPlanke = countPlanke.ExecuteScalar().ToString();
                string resultStoff = countStoff.ExecuteScalar().ToString();
                string resultLeder = countLeder.ExecuteScalar().ToString();
                string resultSteinblock = countSteinblock.ExecuteScalar().ToString();

                //Mitglieder
                label1.Text = "Anzahl Mitglieder: " + resultPlayer;
                
                //Klasse
                label14.Text = "Anzahl Tank: " + resultTank;
                label15.Text = "Anzahl Single Melee: " + resultSingleMelee;
                label16.Text = "Anzahl AoE Melee: " + resultAoEMelee;
                label17.Text = "Anzahl Single Range: " + resultSingleRange;
                label18.Text = "Anzahl AoE Range: " + resultAoERange;
                label19.Text = "Anzahl Support: " + resultSupport;
                label20.Text = "Anzahl Single Heal: " + resultSingleHeal;
                label21.Text = "Anzahl AoE Heal: " + resultAoEHeal;

                //Gathering
                label2.Text = "Anzahl Erzschürfer: " + resultErz;
                label3.Text = "Anzahl Holzfäller: " + resultHolz;
                label4.Text = "Anzahl Baumwollpflücker: " + resultWolle;
                label5.Text = "Anzahl Fellabzieher: " + resultFell;
                label6.Text = "Anzahl Steinhauer: " + resultStein;

                //Refining
                label8.Text = "Anzahl Schmied: " + resultMetall;
                label9.Text = "Anzahl Schreiner: " + resultPlanke;
                label10.Text = "Anzahl Weber: " + resultStoff;
                label11.Text = "Anzahl Gerber: " + resultLeder;
                label12.Text = "Anzahl Steinmetz: " + resultSteinblock;

                toolStripStatusLabel2.Text = "Angemeldet als " + globalVariable.name;
                toolStripStatusLabel1.BackColor = Color.PaleGreen;
            }
            catch (Exception exc)
            {
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel1.Text = "nicht Verbunden";
                toolStripStatusLabel1.BackColor = Color.LightCoral;
                MessageBox.Show(" " + exc);
            }

            if(connectDB != null)
                connectDB.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initStats();
        }

        private void kriegerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 31;
            crftwaffe = new Form4();
            crftwaffe.MdiParent = this;
            crftwaffe.Text = "Crafting Kriegerwaffen";
            crftwaffe.Show();
        }

        private void jägerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 32;
            crftwaffe = new Form4();
            crftwaffe.MdiParent = this;
            crftwaffe.Text = "Crafting Jägerwaffen";
            crftwaffe.Show();
        }

        private void magierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalVariable.fenster = 33;
            crftwaffe = new Form4();
            crftwaffe.MdiParent = this;
            crftwaffe.Text = "Crafting Magierwaffen";
            crftwaffe.Show();
        }

        private void charakterLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Wollen Sie den Charakter \"" + globalVariable.name + "\" wirklich löschen?\n\n"+
                                                     "Das Programm wird nach diesem Vorgang geschlossen!", "Charakter löschen!", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                try
                {
                    connectDB.Open();
                    
                    string deletePlayer = "delete from albionprogram.player where playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayer = new MySqlCommand(deletePlayer, connectDB);
                    dltPlayer.ExecuteNonQuery();

                    string deletePlayerAttr = "delete from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerAttr = new MySqlCommand(deletePlayerAttr, connectDB);
                    dltPlayerAttr.ExecuteNonQuery();

                    string deletePlayerGath = "delete from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerGath = new MySqlCommand(deletePlayerGath, connectDB);
                    dltPlayerGath.ExecuteNonQuery();

                    string deletePlayerCraftArmor = "delete from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerCraftArmor = new MySqlCommand(deletePlayerCraftArmor, connectDB);
                    dltPlayerCraftArmor.ExecuteNonQuery();

                    string deletePlayerCraftWeaponWarrior = "delete from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerCraftWeaponWarrior = new MySqlCommand(deletePlayerCraftWeaponWarrior, connectDB);
                    dltPlayerCraftWeaponWarrior.ExecuteNonQuery();

                    string deletePlayerCraftWeaponHunter = "delete from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerCraftWeaponHunter = new MySqlCommand(deletePlayerCraftWeaponHunter, connectDB);
                    dltPlayerCraftWeaponHunter.ExecuteNonQuery();

                    string deletePlayerCraftWeaponMage = "delete from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerCraftWeaponMage = new MySqlCommand(deletePlayerCraftWeaponMage, connectDB);
                    dltPlayerCraftWeaponMage.ExecuteNonQuery();

                    string deletePlayerCraftTools = "delete from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
                    MySqlCommand dltPlayerCraftTools = new MySqlCommand(deletePlayerCraftTools, connectDB);
                    dltPlayerCraftTools.ExecuteNonQuery();

                    timer1.Enabled = false;
                    MessageBox.Show("Programm wird beendet!");
                
                    connectDB.Close();
                    Application.Exit();
                }
                catch (MySqlException mexc)
                {
                    MessageBox.Show("Fehler beim löschen!\n" + mexc);
                }
                
            }
            
        }
    }
}
