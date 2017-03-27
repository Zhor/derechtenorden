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

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {

        public static int fenster = 0;

        private MySqlConnection connectDB;

        private string connection = globalVariable.EditorMySQLConnect;

        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        private BindingSource bindingsSource1 = new BindingSource();

        public Form4()
        {
            InitializeComponent();

            connectDB = new MySqlConnection(connection);

            initData();
            

        }

        private void GetData(string selectCmd)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter(selectCmd, connectDB);
                MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingsSource1.DataSource = table;

                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void initData()
        {
            try
            {
                connectDB.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc);
                this.Close();
            }

            switch (globalVariable.fenster)
            {
                case 1:

                    dataGridView1.DataSource = bindingsSource1;
                    //GetData("select player as Name from player");
                    GetData("select attr_playername as Name, " +
                                   "attr_waffe as Haupthand, " +
                                   "attr_offhand as Nebenhand, " +
                                   "attr_kopf as Kopf, " +
                                   "attr_brust as Brust, " +
                                   "attr_fuss as Fuss, " +
                                   "attr_tank as Tank, " +
                                   "attr_ddsinglemelee as DD_Single_Melee, " +
                                   "attr_ddaoemelee as DD_AOE_Melee, " +
                                   "attr_ddsinglerange as DD_Single_Range, " +
                                   "attr_ddaorrange as DD_AOE_Range, " +
                                   "attr_support as Support, " +
                                   "attr_singleheal as Single_Heal, " +
                                   "attr_aoeheal as AOE_Heal from albionprogram.playerattribute;");
                    //idplayer,attr_klasse,attr_waffe,attr_offhand,attr_kopf,attr_brust,attr_fuss
                    break;
                case 2:

                    dataGridView1.DataSource = bindingsSource1;
                    GetData("select gath_playername as Name, " +
                                   "erz as Erz, " +
                                   "holz as Holz, " +
                                   "wolle as Wolle, " +
                                   "fell as Fell, " +
                                   "stein as Stein, " +
                                   "metall as Metallstangen, " +
                                   "planke as Holzplanke, " +
                                   "stoff as Stoff, " +
                                   "leder as Leder, " +
                                   "steinblock as Steinblock " +
                                   "from albionprogram.playergathering;");
                    break;
                case 31:

                    dataGridView1.DataSource = bindingsSource1;
                    GetData("select craftweaponwarrior_playername as Name, " +
                                   "schwertschmiedstufe as 'Stufe Schwertschmied', " +
                                   "breitschwert as Breitschwert, " +
                                   "claymore as Claymore, " +
                                   "zweischwerter as Zweischwerter, " +
                                   "axtschmiedstufe as 'Stufe Axtschmied', " +
                                   "kriegsaxt as Kriegsaxt, " +
                                   "großaxt as Großaxt, " +
                                   "hellebarde as Hellebarde, " +
                                   "keulenschmiedstufe as 'Stufe Keulenschmied', " +
                                   "keule as Keule, " +
                                   "schwerekeule as 'Schwere Keule', " +
                                   "flegel as Flegel, " +
                                   "hammerschmiedstufe as 'Stufe Hammerschmied', " +
                                   "hammer as Hammer, " +
                                   "hammerstangenwaffen as 'Hammer-Stangenwaffen', " +
                                   "grosshammer as Großhammer, " +
                                   "armbrustschmiedstufe as 'Stufe Armbrustschmied', " +
                                   "armbrust as Armbrust, " +
                                   "schwerearmbrust as 'Schwere Armbrust', " +
                                   "einhandarmbrust as Einhandarmbrust, " +
                                   "schildschmiedstufe as 'Stufe Schildschmied' " +
                                   "from albionprogram.craftingweaponwarrior;");
                    break;
                case 32:

                    dataGridView1.DataSource = bindingsSource1;
                    GetData("select craftingweaponhunter_playername as Name, " +
                                   "bogenmacherstufe as 'Stufe Bogenmacher', " +
                                   "bogen as Bogen, " +
                                   "kriegsbogen as Kriegsbogen, " +
                                   "langbogen as Langbogen, " +
                                   "speerschmiedstufe as 'Stufe Speerschmied', " +
                                   "speer as Speer, " +
                                   "piken as Pike, " +
                                   "glefe as Glefe, " +
                                   "naturstabschmiedstufe as 'Stufe Naturstabschmied', " +
                                   "naturstab as Naturstab, " +
                                   "grossernaturstab as 'Großer Naturstab', " +
                                   "wildstab as Wildstab, " +
                                   "dolchschmiedstufe as 'Stufe Dolchschmied', " +
                                   "dolch as Dolch, " +
                                   "dolchpaar as 'Dolchpaar', " +
                                   "klauenpaar as Klauenpaar, " +
                                   "kampfstabschmiedstufe as 'Stufe Kampfstabschmied', " +
                                   "kampfstab as Kampfstab, " +
                                   "eisenpanzerstab as 'Eisenpanzerstab', " +
                                   "doppelklingenstab as Doppelklingenstab, " +
                                   "fackelschmiedstufe as 'Stufe Fackelschmied' " +
                                   "from albionprogram.craftingweaponhunter;");
                    break;
                case 33:

                    dataGridView1.DataSource = bindingsSource1;
                    GetData("select craftingweaponmage_playername as Name, " +
                                   "feuerstabschmiedstufe as 'Stufe Feuerstabschmied', " +
                                   "feuerstab as Feuerstab, " +
                                   "grosserfeuerstab as 'Großer Feuerstab', " +
                                   "hoellenstab as 'Höllenstab', " +
                                   "heiligenstabschmiedstufe as 'Stufe Heiligenstabschmied', " +
                                   "heiligenstab as Heiligenstab, " +
                                   "grosserheiligenstab as 'Großer Heiligenstab', " +
                                   "gottesstab as Gottesstab, " +
                                   "geheimstabschmiedstufe as 'Stufe Geheimstabschmied', " +
                                   "geheimstab as Geheimstab, " +
                                   "grossergeheimstab as 'Großer Geheimstab', " +
                                   "mysterioeserstab as 'Myteriöserstab', " +
                                   "froststabschmiedstufe as 'Stufe Froststabschmied', " +
                                   "froststab as Froststab, " +
                                   "grosserfroststab as 'Großer Froststab', " +
                                   "gletscherstab as Gletscherstab, " +
                                   "verfluchterstabschmiedstufe as 'Stufe Verfluchterstabschmied', " +
                                   "verfluchterstab as 'Verfluchterstab', " +
                                   "grosserverfluchterstab as 'Großer Verfluchterstab', " +
                                   "daemonenstab as 'Däemonenstab', " +
                                   "buchbinderstufe as 'Stufe Buchbinder' " +
                                   "from albionprogram.craftingweaponmage;");
                    break;
                case 4:

                    dataGridView1.DataSource = bindingsSource1;

                    GetData("select craftarmor_playername as Name, " +
                                   "plattekopf as Plattenhelm, " +
                                   "plattebrust as Plattenrüstung, " +
                                   "plattestiefel as Plattenstiefel, " +
                                   "lederkopf as Lederkapuze, " +
                                   "lederbrust as Lederjacke, " +
                                   "lederstiefel as Lederschuhe, " +
                                   "stoffkopf as Stoffgugel, " +
                                   "stoffbrust as Stoffrobe, " +
                                   "stoffstiefel as Stoffsandalen " +
                                   "from albionprogram.craftingarmor;");
                    break;
                case 5:

                    dataGridView1.DataSource = bindingsSource1;

                    GetData("select craftingtools_playername as Name, " +
                                   "abbruchhammer as Abbruchhammer, " +
                                   "sichel as Sichel, " +
                                   "abhäutemesser as Abhäutemesser, " +
                                   "spitzhacke as Spitzhacke, " +
                                   "steinhammer as Steinhammer, " +
                                   "axt as Axt, " +
                                   "umhangschneider as Umhangschneider, " +
                                   "taschenschneider as Taschenschneider " +
                                   "from albionprogram.craftingtools;");
                    break;
                case 6:

                    dataGridView1.DataSource = bindingsSource1;

                    GetData("select farm_playername as Name, " +
                                   "kraeuterarztstufe as 'Stufe Alchimist', " +
                                   "schmuggler as Schmuggler, " +
                                   "reinigungsbrauer as Reinigungsbrauer, " +
                                   "abklingzeitbrauer as Abklingzeitbrauer, " +
                                   "verlangsamungsfeldbrauer as Verlangsamungsbrauer, " +
                                   "steinhautbrauer as Steinhautbrauer, " +
                                   "wiederbelebungsbrauer as Wiederbelebungsbrauer, " +
                                   "energiebrauer as Energiebrauer, " +
                                   "umschlagvorbereiter as Umschlagvorbereiter, " +
                                   "kochstufe as 'Stufe Koch', " +
                                   "metzgerei as Metzgerei, " +
                                   "mueller as Müller, " +
                                   "sandwichkoch as Sandwichkoch, " +
                                   "eintopfkoch as Eintopfkoch, " +
                                   "pastetenkoch as Pastetenkoch, " +
                                   "omelettkoch as Omelettkoch, " +
                                   "salatkoch as Salatkoch, " +
                                   "suppenkoch as Suppenkoch, " +
                                   "ernterstufe as 'Stufe Ernter', " +
                                   "hirtestufe as 'Stufe Hirte', " +
                                   "reitierausbilderstufe as 'Stufe Reitierausbilder' " +
                                   "from albionprogram.playerfarming;");
                    break;
                default:
                    MessageBox.Show("Zugriff fehlgeschlagen!");
                    this.Close();
                    break;
            }

            globalVariable.fenster = 0;
        }

    }
}
