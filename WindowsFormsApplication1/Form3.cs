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
    public partial class Form3 : Form
    {
        private MySqlConnection connectDB;

        private string connection = globalVariable.EditorMySQLConnect;
        
        public Form3()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();

            connectDB = new MySqlConnection(connection);

            init();
            combodontedit();
        }
        
        private void init()
        #region combobox
        {
            //gathering
            string cbErzStatement = "select erz from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbholzStatement = "select holz from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbwolleStatement = "select wolle from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbfellStatement = "select fell from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbsteinStatement = "select stein from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";

            MySqlCommand cBErzCommand = new MySqlCommand(cbErzStatement, connectDB);
            MySqlCommand cBholzCommand = new MySqlCommand(cbholzStatement, connectDB);
            MySqlCommand cBwolleCommand = new MySqlCommand(cbwolleStatement, connectDB);
            MySqlCommand cBfellCommand = new MySqlCommand(cbfellStatement, connectDB);
            MySqlCommand cBsteinCommand = new MySqlCommand(cbsteinStatement, connectDB);
            
            //refining
            string cbMetallStatement = "select metall from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbPlankeStatement = "select planke from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbStoffStatement = "select stoff from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbLederStatement = "select leder from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbSteinblockStatement = "select steinblock from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";

            MySqlCommand cBMetallCommand = new MySqlCommand(cbMetallStatement, connectDB);
            MySqlCommand cBPlankeCommand = new MySqlCommand(cbPlankeStatement, connectDB);
            MySqlCommand cBStoffCommand = new MySqlCommand(cbStoffStatement, connectDB);
            MySqlCommand cBLederCommand = new MySqlCommand(cbLederStatement, connectDB);
            MySqlCommand cBSteinblockCommand = new MySqlCommand(cbSteinblockStatement, connectDB);

            connectDB.Open();

            try 
            {

                //gathering
                gath_erzLvl.SelectedIndex = Convert.ToInt32(cBErzCommand.ExecuteScalar().ToString());
                gath_holzLvl.SelectedIndex = Convert.ToInt32(cBholzCommand.ExecuteScalar().ToString());
                gath_wolleLvl.SelectedIndex = Convert.ToInt32(cBwolleCommand.ExecuteScalar().ToString());
                gath_fellLvl.SelectedIndex = Convert.ToInt32(cBfellCommand.ExecuteScalar().ToString());
                gath_steinLvl.SelectedIndex = Convert.ToInt32(cBsteinCommand.ExecuteScalar().ToString());

                //refining
                refine_metallstangeLvl.SelectedIndex = Convert.ToInt32(cBMetallCommand.ExecuteScalar().ToString());
                refine_plankeLvl.SelectedIndex = Convert.ToInt32(cBPlankeCommand.ExecuteScalar().ToString());
                refine_stoffLvl.SelectedIndex = Convert.ToInt32(cBStoffCommand.ExecuteScalar().ToString());
                refine_lederLvl.SelectedIndex = Convert.ToInt32(cBLederCommand.ExecuteScalar().ToString());
                refine_steinblockLvl.SelectedIndex = Convert.ToInt32(cBSteinblockCommand.ExecuteScalar().ToString());

            }catch(Exception exc)
            {
            
            }

            connectDB.Close();

            equip_weaponName.SelectedIndex = 0;
            equip_weaponLvl.SelectedIndex = 0;
            equip_offHandName.SelectedIndex = 0;
            equip_offHandLvl.SelectedIndex = 0;
            equip_headName.SelectedIndex = 0;
            equip_headLvl.SelectedIndex = 0;
            equip_chestName.SelectedIndex = 0;
            equip_chestLvl.SelectedIndex = 0;
            equip_shoesName.SelectedIndex = 0;
            equip_shoesLvl.SelectedIndex = 0;
            craft_PlateHeadLvl.SelectedIndex = 0;
            craft_PlateHeadName.SelectedIndex = 0;
            craft_PlateChestLvl.SelectedIndex = 0;
            craft_PlateChestName.SelectedIndex = 0;
            craft_PlateShoesLvl.SelectedIndex = 0;
            warrior_SchwertschmiedLvl.SelectedIndex = 0;
            warrior_HellebardeLvl.SelectedIndex = 0;
            warrior_BreitschwertLvl.SelectedIndex = 0;
            warrior_AxtschmiedLvl.SelectedIndex = 0;
            craft_PlateShoesName.SelectedIndex = 0;
            craft_LeatherHeadLvl.SelectedIndex = 0;
            craft_LeatherHeadName.SelectedIndex = 0;
            craft_LeatherChestLvl.SelectedIndex = 0;
            craft_LeatherChestName.SelectedIndex = 0;
            craft_LeatherShoesLvl.SelectedIndex = 0;
            warrior_ClaymoreLvl.SelectedIndex = 0;
            warrior_KriegsAxtLvl.SelectedIndex = 0;
            warrior_ZweischwerterLvl.SelectedIndex = 0;
            warrior_GrossaxtLvl.SelectedIndex = 0;
            craft_LeatherShoesName.SelectedIndex = 0;
            craft_ClothHeadLvl.SelectedIndex = 0;
            craft_ClothHeadName.SelectedIndex = 0;
            craft_ClothChestLvl.SelectedIndex = 0;
            craft_ClothChestName.SelectedIndex = 0;
            craft_ClothShoesLvl.SelectedIndex = 0;
            warrior_FlegelLvl.SelectedIndex = 0;
            warrior_KeulenschmiedLvl.SelectedIndex = 0;
            warrior_KeuleLvl.SelectedIndex = 0;
            warrior_schwereKeuleLvl.SelectedIndex = 0;
            craft_ClothShoesName.SelectedIndex = 0;
            warrior_GrosshammerLvl.SelectedIndex = 0;
            warrior_HammerschmiedLvl.SelectedIndex = 0;
            warrior_HammerLvl.SelectedIndex = 0;
            warrior_HammerstangenwaffeLvl.SelectedIndex = 0;
            warrior_einhandArmbrustLvl.SelectedIndex = 0;
            warrior_ArmbrustschmiedLvl.SelectedIndex = 0;
            warrior_ArmbrustLvl.SelectedIndex = 0;
            warrior_schwereArmbrustLvl.SelectedIndex = 0;
            hunter_DoppelklingenstabLvl.SelectedIndex = 0;
            hunter_KampfstabschmiedLvl.SelectedIndex = 0;
            hunter_kampfstabLvl.SelectedIndex = 0;
            hunter_eisenpanzerstabLvl.SelectedIndex = 0;
            hunter_klauenpaarLvl.SelectedIndex = 0;
            hunter_DolchschmiedLvl.SelectedIndex = 0;
            hunter_DolchLvl.SelectedIndex = 0;
            hunter_dolchpaarLvl.SelectedIndex = 0;
            hunter_wildstabLvl.SelectedIndex = 0;
            hunter_NaturstabschmiedLvl.SelectedIndex = 0;
            hunter_naturstabLvl.SelectedIndex = 0;
            hunter_grosserNaturstabLvl.SelectedIndex = 0;
            hunter_glefeLvl.SelectedIndex = 0;
            hunter_SpeerschmiedLvl.SelectedIndex = 0;
            hunter_speerLvl.SelectedIndex = 0;
            hunter_pikenLvl.SelectedIndex = 0;
            hunter_LangbogenLvl.SelectedIndex = 0;
            hunter_BogenmacherLvl.SelectedIndex = 0;
            hunter_BogenLvl.SelectedIndex = 0;
            hunter_KriegsbogenLvl.SelectedIndex = 0;
            mage_daemonstabLvl.SelectedIndex = 0;
            mage_cursedStabschmiedLvl.SelectedIndex = 0;
            mage_cursedStabLvl.SelectedIndex = 0;
            mage_grosserCursedstabLvl.SelectedIndex = 0;
            mage_GletscherstabLvl.SelectedIndex = 0;
            mage_froststabschmiedLvl.SelectedIndex = 0;
            mage_froststabLvl.SelectedIndex = 0;
            mage_grosserFroststabLvl.SelectedIndex = 0;
            mage_mysterioeserStabLvl.SelectedIndex = 0;
            mage_geheimstabschmiedLvl.SelectedIndex = 0;
            mage_geheimstabLvl.SelectedIndex = 0;
            mage_grossergeheimstabLvl.SelectedIndex = 0;
            mage_gottesstabLvl.SelectedIndex = 0;
            mage_HeiligenstabschmiedLvl.SelectedIndex = 0;
            mage_heiligenstabLvl.SelectedIndex = 0;
            mage_grosserheiligenstabLvl.SelectedIndex = 0;
            mage_hoellenstabLvl.SelectedIndex = 0;
            mage_FeuerstabschmiedLvl.SelectedIndex = 0;
            mage_feuerstabLvl.SelectedIndex = 0;
            mage_grosserfeuerstabLvl.SelectedIndex = 0;
            craft_ToolsSpitzhackeLvl.SelectedIndex = 0;
            craft_ToolsAbbruchhammerLvl.SelectedIndex = 0;
            craft_ToolsSichelLvl.SelectedIndex = 0;
            craft_ToolsAbhaeutemesserLvl.SelectedIndex = 0;
            craft_ToolsAxtLvl.SelectedIndex = 0;
            craft_ToolsSteinhammerLvl.SelectedIndex = 0;
            alchi_VerlangsamungsfeldLvl.SelectedIndex = 0;
            craft_AccessUmhangschneider.SelectedIndex = 0;
            craft_AccessTaschenschneider.SelectedIndex = 0;
            alchi_Lvl.SelectedIndex = 0;
            alchi_schmugglerLvl.SelectedIndex = 0;
            alchi_reinigungsbrauerLvl.SelectedIndex = 0;
            alchi_AbklingzeitbrauerLvl.SelectedIndex = 0;
            alchi_UmschlagvorbereiterLvl.SelectedIndex = 0;
            alchi_SteinhautbrauerLvl.SelectedIndex = 0;
            alchi_WiederbelebungsbrauerLvl.SelectedIndex = 0;
            alchi_EnergiebrauerLvl.SelectedIndex = 0;
            cook_SuppenkochLvl.SelectedIndex = 0;
            cook_PastetenkochLvl.SelectedIndex = 0;
            cook_OmelettKochLvl.SelectedIndex = 0;
            cook_SalatkochLvl.SelectedIndex = 0;
            cook_EintopfkochLvl.SelectedIndex = 0;
            cook_MetzgereiLvl.SelectedIndex = 0;
            cook_MuellerLvl.SelectedIndex = 0;
            cook_SandwichkochLvl.SelectedIndex = 0;
            hirteLvl.SelectedIndex = 0;
            warrior_SchildschmiedLvl.SelectedIndex = 0;
            hunter_FackelschmiedLvl.SelectedIndex = 0;
            mage_buchbinderLvl.SelectedIndex = 0;
            nutzpflanzenbauerLvl.SelectedIndex = 0;
            kraut_ErnterLvl.SelectedIndex = 0;

        }
        #endregion

        private void combodontedit()
        #region comboboxDONTEDIT
        {
            gath_erzLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            gath_holzLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            gath_wolleLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            gath_fellLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            gath_steinLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            refine_metallstangeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            refine_plankeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            refine_stoffLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            refine_lederLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            refine_steinblockLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_weaponName.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_weaponLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_offHandName.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_offHandLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_headName.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_headLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_chestName.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_chestLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_shoesName.DropDownStyle = ComboBoxStyle.DropDownList;
            equip_shoesLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateHeadLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateHeadName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateChestLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateChestName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateShoesLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_SchwertschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_HellebardeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_BreitschwertLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_AxtschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_PlateShoesName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherHeadLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherHeadName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherChestLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherChestName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherShoesLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_ClaymoreLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_KriegsAxtLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_ZweischwerterLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_GrossaxtLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_LeatherShoesName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothHeadLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothHeadName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothChestLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothChestName.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothShoesLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_FlegelLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_KeulenschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_KeuleLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_schwereKeuleLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ClothShoesName.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_GrosshammerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_HammerschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_HammerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_HammerstangenwaffeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_einhandArmbrustLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_ArmbrustschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_ArmbrustLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_schwereArmbrustLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_DoppelklingenstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_KampfstabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_kampfstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_eisenpanzerstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_klauenpaarLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_DolchschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_DolchLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_dolchpaarLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_wildstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_NaturstabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_naturstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_grosserNaturstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_glefeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_SpeerschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_speerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_pikenLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_LangbogenLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_BogenmacherLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_BogenLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_KriegsbogenLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_daemonstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_cursedStabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_cursedStabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_grosserCursedstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_GletscherstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_froststabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_froststabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_grosserFroststabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_mysterioeserStabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_geheimstabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_geheimstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_grossergeheimstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_gottesstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_HeiligenstabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_heiligenstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_grosserheiligenstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_hoellenstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_FeuerstabschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_feuerstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_grosserfeuerstabLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsSpitzhackeLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsAbbruchhammerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsSichelLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsAbhaeutemesserLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsAxtLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_ToolsSteinhammerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_VerlangsamungsfeldLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_AccessUmhangschneider.DropDownStyle = ComboBoxStyle.DropDownList;
            craft_AccessTaschenschneider.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_Lvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_schmugglerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_reinigungsbrauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_AbklingzeitbrauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_UmschlagvorbereiterLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_SteinhautbrauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_WiederbelebungsbrauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            alchi_EnergiebrauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            koch_Lvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_SuppenkochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_PastetenkochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_OmelettKochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_SalatkochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_EintopfkochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_MetzgereiLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_MuellerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            cook_SandwichkochLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hirteLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            warrior_SchildschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            hunter_FackelschmiedLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            mage_buchbinderLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            nutzpflanzenbauerLvl.DropDownStyle = ComboBoxStyle.DropDownList;
            kraut_ErnterLvl.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDB.Open();
            /*
             MySqlCommand cmdUpdateTank = new MySqlCommand("update albionprogram.playerattribute set attr_tank = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateDDsgleMelee = new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateDDaoeMelee = new MySqlCommand("update albionprogram.playerattribute set attr_ddaoemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateDDsgleRange = new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglerange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateDDaoeRange = new MySqlCommand("update albionprogram.playerattribute set attr_ddaorrange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateSupport = new MySqlCommand("update albionprogram.playerattribute set attr_support = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateSingleHeal = new MySqlCommand("update albionprogram.playerattribute set attr_singleheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             MySqlCommand cmdUpdateAoeHeal = new MySqlCommand("update albionprogram.playerattribute set attr_aoeheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB);
             */
            updatefunction(tabControl1.SelectedIndex);

            connectDB.Close();
            this.Close();
        }

        private void updatefunction(TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                //Gathering & Refining
                case 0:
                    #region gathering
                    new MySqlCommand("update albionprogram.playergathering set erz ='" + Convert.ToInt32(gath_erzLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set holz ='" + Convert.ToInt32(gath_holzLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set wolle ='" + Convert.ToInt32(gath_wolleLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set fell ='" + Convert.ToInt32(gath_fellLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set stein ='" + Convert.ToInt32(gath_steinLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set metall ='" + Convert.ToInt32(refine_metallstangeLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set planke ='" + Convert.ToInt32(refine_plankeLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set stoff ='" + Convert.ToInt32(refine_stoffLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set leder ='" + Convert.ToInt32(refine_lederLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set steinblock ='" + Convert.ToInt32(refine_steinblockLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    #endregion

                    break;
                //Ausrüstung (tragbar)
                case 1:
                    //TANK
                    if (cB_Tank.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_tank = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_tank = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-SINGLE-MELEE
                    if (cB_DD_Single_Melee.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglemelee = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-AOE-MELEE
                    if (cB_DD_AoE_Melee.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaoemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaoemelee = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-SINGLE-RANGE
                    if (cB_DD_Single_Range.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglerange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglerange = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-AOE-RANGE
                    if (cB_DD_AoE_Range.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaorrange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaorrange = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //SUPPORT
                    if (cB_Support.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_support = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_support = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //SINGLE-HEAL
                    if (cB_single_Healer.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_singleheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_singleheal = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //AOE-HEAL
                    if (cB_AoE_Healer.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_aoeheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_aoeheal = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }

                    new MySqlCommand("update albionprogram.playerattribute set attr_waffe ='" + equip_weaponName.SelectedItem.ToString() + " t" + equip_weaponLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_offhand ='" + equip_offHandName.SelectedItem.ToString() + " t" + equip_offHandLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_kopf ='" + equip_headName.SelectedItem.ToString() + " t" + equip_headLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_brust ='" + equip_chestName.SelectedItem.ToString() + " t" + equip_chestLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_fuss ='" + equip_shoesName.SelectedItem.ToString() + " t" + equip_shoesLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Rüstung
                case 2:
                    new MySqlCommand("update albionprogram.craftingarmor set plattekopf ='" + craft_PlateHeadName.SelectedItem.ToString() + " t" + craft_PlateHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set plattebrust ='" + craft_PlateChestName.SelectedItem.ToString() + " t" + craft_PlateChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set plattestiefel ='" + craft_PlateShoesName.SelectedItem.ToString() + " t" + craft_PlateShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingarmor set lederkopf ='" + craft_LeatherHeadName.SelectedItem.ToString() + " t" + craft_LeatherHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set lederbrust ='" + craft_LeatherChestName.SelectedItem.ToString() + " t" + craft_LeatherChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set lederstiefel ='" + craft_LeatherShoesName.SelectedItem.ToString() + " t" + craft_LeatherShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingarmor set stoffkopf ='" + craft_ClothHeadName.SelectedItem.ToString() + " t" + craft_ClothHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set stoffbrust ='" + craft_ClothChestName.SelectedItem.ToString() + " t" + craft_ClothChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set stoffstiefel ='" + craft_ClothShoesName.SelectedItem.ToString() + " t" + craft_ClothShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Kriegerwaffen
                case 3:
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwertschmiedstufe ='" + warrior_SchwertschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set breitschwert ='" + warrior_BreitschwertLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set claymore ='" + warrior_ClaymoreLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set zweischwerter ='" + warrior_ZweischwerterLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set axtschmiedstufe ='" + warrior_AxtschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set kriegsaxt ='" + warrior_KriegsAxtLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set großaxt ='" + warrior_GrossaxtLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hellebarde ='" + warrior_HellebardeLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set keulenschmiedstufe ='" + warrior_KeulenschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set keule ='" + warrior_KeuleLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwerekeule ='" + warrior_schwereKeuleLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set flegel ='" + warrior_FlegelLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammerschmiedstufe ='" + warrior_HammerschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammer ='" + warrior_HammerLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammerstangenwaffen ='" + warrior_HammerstangenwaffeLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set grosshammer ='" + warrior_GrosshammerLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set armbrustschmiedstufe ='" + warrior_ArmbrustschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set armbrust ='" + warrior_ArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwerearmbrust ='" + warrior_schwereArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set einhandarmbrust ='" + warrior_einhandArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schildschmiedstufe ='" + warrior_SchildschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Jägerwaffen
                case 4:
                    new MySqlCommand("update albionprogram.craftingweaponhunter set bogenmacherstufe ='" + hunter_BogenmacherLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set bogen ='" + hunter_BogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set kriegsbogen ='" + hunter_KriegsbogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set langbogen ='" + hunter_LangbogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set speerschmiedstufe ='" + hunter_SpeerschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set speer ='" + hunter_speerLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set piken ='" + hunter_pikenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set glefe ='" + hunter_glefeLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set naturstabschmiedstufe ='" + hunter_NaturstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set naturstab ='" + hunter_naturstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set grossernaturstab ='" + hunter_grosserNaturstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set wildstab ='" + hunter_wildstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolchschmiedstufe ='" + hunter_DolchschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolch ='" + hunter_DolchLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolchpaar ='" + hunter_dolchpaarLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set klauenpaar ='" + hunter_klauenpaarLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set kampfstabschmiedstufe ='" + hunter_KampfstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set kampfstab ='" + hunter_kampfstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set eisenpanzerstab ='" + hunter_eisenpanzerstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set doppelklingenstab ='" + hunter_DoppelklingenstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set fackelschmiedstufe ='" + hunter_FackelschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Magierwaffen
                case 5:
                    new MySqlCommand("update albionprogram.craftingweaponmage set feuerstabschmiedstufe ='" + mage_FeuerstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set feuerstab ='" + mage_feuerstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserfeuerstab ='" + mage_grosserfeuerstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set hoellenstab ='" + mage_hoellenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set heiligenstabschmiedstufe ='" + mage_HeiligenstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set heiligenstab ='" + mage_heiligenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserheiligenstab ='" + mage_grosserheiligenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set gottesstab ='" + mage_gottesstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set geheimstabschmiedstufe ='" + mage_geheimstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set geheimstab ='" + mage_geheimstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grossergeheimstab ='" + mage_grossergeheimstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set mysterioeserstab ='" + mage_mysterioeserStabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set froststabschmiedstufe ='" + mage_froststabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set froststab ='" + mage_froststabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserfroststab ='" + mage_grosserFroststabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set gletscherstab ='" + mage_GletscherstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set verfluchterstabschmiedstufe ='" + mage_cursedStabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set verfluchterstab ='" + mage_cursedStabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserverfluchterstab ='" + mage_grosserCursedstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set daemonenstab ='" + mage_daemonstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set buchbinderstufe ='" + mage_buchbinderLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Werkzeug & Accessoire
                case 6:
                    new MySqlCommand("update albionprogram.craftingtools set abbruchhammer ='" + craft_ToolsAbbruchhammerLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set sichel ='" + craft_ToolsSichelLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set abhäutemesser ='" + craft_ToolsAbhaeutemesserLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set spitzhacke ='" + craft_ToolsSpitzhackeLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set steinhammer ='" + craft_ToolsSteinhammerLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set axt ='" + craft_ToolsAxtLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingtools set umhangschneider ='" + craft_AccessUmhangschneider.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set taschenschneider ='" + craft_AccessTaschenschneider.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Alchemist
                case 7:
                    new MySqlCommand("update albionprogram.playerfarming set alchimiststufe ='" + alchi_Lvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set schmuggler ='" + alchi_schmugglerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set reinigungsbrauer ='" + alchi_reinigungsbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set abklingzeitbrauer ='" + alchi_AbklingzeitbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set verlangsamungsfeldbrauer ='" + alchi_VerlangsamungsfeldLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set steinhautbrauer ='" + alchi_SteinhautbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set wiederbelebungsbrauer ='" + alchi_WiederbelebungsbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set energiebrauer ='" + alchi_EnergiebrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set umschlagvorbereiter ='" + alchi_UmschlagvorbereiterLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Koch
                case 8:
                    new MySqlCommand("update albionprogram.playerfarming set kochstufe ='" + koch_Lvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set metzgerei ='" + cook_MetzgereiLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set mueller ='" + cook_MuellerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set sandwichkoch ='" + cook_SandwichkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set eintopfkoch ='" + cook_EintopfkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set pastetenkoch ='" + cook_PastetenkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set omelettkoch ='" + cook_OmelettKochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set salatkoch ='" + cook_SalatkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set suppenkoch ='" + cook_SuppenkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Nutz- & Reittiere
                case 9:
                    new MySqlCommand("update albionprogram.playerfarming set kraeuterarztstufe ='" + kraut_ErnterLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set nutzpflanzenbauer ='" + nutzpflanzenbauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set hirte ='" + hirteLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    break;
                default:
                    break;
            }
        }

        private void updatefunction(int i)
        {
            switch (i)
            {
                //Gathering & Refining
                case 0:
                    #region gathering
                    new MySqlCommand("update albionprogram.playergathering set erz ='" + Convert.ToInt32(gath_erzLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set holz ='" + Convert.ToInt32(gath_holzLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set wolle ='" + Convert.ToInt32(gath_wolleLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set fell ='" + Convert.ToInt32(gath_fellLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set stein ='" + Convert.ToInt32(gath_steinLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set metall ='" + Convert.ToInt32(refine_metallstangeLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set planke ='" + Convert.ToInt32(refine_plankeLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set stoff ='" + Convert.ToInt32(refine_stoffLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set leder ='" + Convert.ToInt32(refine_lederLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playergathering set steinblock ='" + Convert.ToInt32(refine_steinblockLvl.SelectedItem) + "' where gath_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    #endregion

                    break;
                //Ausrüstung (tragbar)
                case 1:
                    //TANK
                    if (cB_Tank.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_tank = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_tank = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-SINGLE-MELEE
                    if (cB_DD_Single_Melee.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglemelee = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-AOE-MELEE
                    if (cB_DD_AoE_Melee.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaoemelee = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaoemelee = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-SINGLE-RANGE
                    if (cB_DD_Single_Range.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglerange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddsinglerange = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //DD-AOE-RANGE
                    if (cB_DD_AoE_Range.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaorrange = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_ddaorrange = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //SUPPORT
                    if (cB_Support.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_support = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_support = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //SINGLE-HEAL
                    if (cB_single_Healer.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_singleheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_singleheal = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    //AOE-HEAL
                    if (cB_AoE_Healer.Checked)
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_aoeheal = 'X' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("update albionprogram.playerattribute set attr_aoeheal = '-' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    }

                    new MySqlCommand("update albionprogram.playerattribute set attr_waffe ='" + equip_weaponName.SelectedItem.ToString() + " t" + equip_weaponLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_offhand ='" + equip_offHandName.SelectedItem.ToString() + " t" + equip_offHandLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_kopf ='" + equip_headName.SelectedItem.ToString() + " t" + equip_headLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_brust ='" + equip_chestName.SelectedItem.ToString() + " t" + equip_chestLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerattribute set attr_fuss ='" + equip_shoesName.SelectedItem.ToString() + " t" + equip_shoesLvl.SelectedItem.ToString() + "' where attr_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Rüstung
                case 2:
                    new MySqlCommand("update albionprogram.craftingarmor set plattekopf ='" + craft_PlateHeadName.SelectedItem.ToString() + " t" + craft_PlateHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set plattebrust ='" + craft_PlateChestName.SelectedItem.ToString() + " t" + craft_PlateChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set plattestiefel ='" + craft_PlateShoesName.SelectedItem.ToString() + " t" + craft_PlateShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingarmor set lederkopf ='" + craft_LeatherHeadName.SelectedItem.ToString() + " t" + craft_LeatherHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set lederbrust ='" + craft_LeatherChestName.SelectedItem.ToString() + " t" + craft_LeatherChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set lederstiefel ='" + craft_LeatherShoesName.SelectedItem.ToString() + " t" + craft_LeatherShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingarmor set stoffkopf ='" + craft_ClothHeadName.SelectedItem.ToString() + " t" + craft_ClothHeadLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set stoffbrust ='" + craft_ClothChestName.SelectedItem.ToString() + " t" + craft_ClothChestLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingarmor set stoffstiefel ='" + craft_ClothShoesName.SelectedItem.ToString() + " t" + craft_ClothShoesLvl.SelectedItem.ToString() + "' where craftarmor_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Kriegerwaffen
                case 3:
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwertschmiedstufe ='" + warrior_SchwertschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set breitschwert ='" + warrior_BreitschwertLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set claymore ='" + warrior_ClaymoreLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set zweischwerter ='" + warrior_ZweischwerterLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set axtschmiedstufe ='" + warrior_AxtschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set kriegsaxt ='" + warrior_KriegsAxtLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set großaxt ='" + warrior_GrossaxtLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hellebarde ='" + warrior_HellebardeLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set keulenschmiedstufe ='" + warrior_KeulenschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set keule ='" + warrior_KeuleLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwerekeule ='" + warrior_schwereKeuleLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set flegel ='" + warrior_FlegelLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammerschmiedstufe ='" + warrior_HammerschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammer ='" + warrior_HammerLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set hammerstangenwaffen ='" + warrior_HammerstangenwaffeLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set grosshammer ='" + warrior_GrosshammerLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set armbrustschmiedstufe ='" + warrior_ArmbrustschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set armbrust ='" + warrior_ArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schwerearmbrust ='" + warrior_schwereArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponwarrior set einhandarmbrust ='" + warrior_einhandArmbrustLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponwarrior set schildschmiedstufe ='" + warrior_SchildschmiedLvl.SelectedItem.ToString() + "' where craftweaponwarrior_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Jägerwaffen
                case 4:
                    new MySqlCommand("update albionprogram.craftingweaponhunter set bogenmacherstufe ='" + hunter_BogenmacherLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set bogen ='" + hunter_BogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set kriegsbogen ='" + hunter_KriegsbogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set langbogen ='" + hunter_LangbogenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set speerschmiedstufe ='" + hunter_SpeerschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set speer ='" + hunter_speerLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set piken ='" + hunter_pikenLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set glefe ='" + hunter_glefeLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set naturstabschmiedstufe ='" + hunter_NaturstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set naturstab ='" + hunter_naturstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set grossernaturstab ='" + hunter_grosserNaturstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set wildstab ='" + hunter_wildstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolchschmiedstufe ='" + hunter_DolchschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolch ='" + hunter_DolchLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set dolchpaar ='" + hunter_dolchpaarLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set klauenpaar ='" + hunter_klauenpaarLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set kampfstabschmiedstufe ='" + hunter_KampfstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set kampfstab ='" + hunter_kampfstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set eisenpanzerstab ='" + hunter_eisenpanzerstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponhunter set doppelklingenstab ='" + hunter_DoppelklingenstabLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponhunter set fackelschmiedstufe ='" + hunter_FackelschmiedLvl.SelectedItem.ToString() + "' where craftingweaponhunter_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Magierwaffen
                case 5:
                    new MySqlCommand("update albionprogram.craftingweaponmage set feuerstabschmiedstufe ='" + mage_FeuerstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set feuerstab ='" + mage_feuerstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserfeuerstab ='" + mage_grosserfeuerstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set hoellenstab ='" + mage_hoellenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set heiligenstabschmiedstufe ='" + mage_HeiligenstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set heiligenstab ='" + mage_heiligenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserheiligenstab ='" + mage_grosserheiligenstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set gottesstab ='" + mage_gottesstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set geheimstabschmiedstufe ='" + mage_geheimstabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set geheimstab ='" + mage_geheimstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grossergeheimstab ='" + mage_grossergeheimstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set mysterioeserstab ='" + mage_mysterioeserStabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set froststabschmiedstufe ='" + mage_froststabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set froststab ='" + mage_froststabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserfroststab ='" + mage_grosserFroststabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set gletscherstab ='" + mage_GletscherstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set verfluchterstabschmiedstufe ='" + mage_cursedStabschmiedLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set verfluchterstab ='" + mage_cursedStabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set grosserverfluchterstab ='" + mage_grosserCursedstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingweaponmage set daemonenstab ='" + mage_daemonstabLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingweaponmage set buchbinderstufe ='" + mage_buchbinderLvl.SelectedItem.ToString() + "' where craftingweaponmage_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Crafting Werkzeug & Accessoire
                case 6:
                    new MySqlCommand("update albionprogram.craftingtools set abbruchhammer ='" + craft_ToolsAbbruchhammerLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set sichel ='" + craft_ToolsSichelLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set abhäutemesser ='" + craft_ToolsAbhaeutemesserLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set spitzhacke ='" + craft_ToolsSpitzhackeLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set steinhammer ='" + craft_ToolsSteinhammerLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set axt ='" + craft_ToolsAxtLvl.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    new MySqlCommand("update albionprogram.craftingtools set umhangschneider ='" + craft_AccessUmhangschneider.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.craftingtools set taschenschneider ='" + craft_AccessTaschenschneider.SelectedItem.ToString() + "' where craftingtools_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Alchemist
                case 7:
                    new MySqlCommand("update albionprogram.playerfarming set alchimiststufe ='" + alchi_Lvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set schmuggler ='" + alchi_schmugglerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set reinigungsbrauer ='" + alchi_reinigungsbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set abklingzeitbrauer ='" + alchi_AbklingzeitbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set verlangsamungsfeldbrauer ='" + alchi_VerlangsamungsfeldLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set steinhautbrauer ='" + alchi_SteinhautbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set wiederbelebungsbrauer ='" + alchi_WiederbelebungsbrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set energiebrauer ='" + alchi_EnergiebrauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set umschlagvorbereiter ='" + alchi_UmschlagvorbereiterLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Koch
                case 8:
                    new MySqlCommand("update albionprogram.playerfarming set kochstufe ='" + koch_Lvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set metzgerei ='" + cook_MetzgereiLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set mueller ='" + cook_MuellerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set sandwichkoch ='" + cook_SandwichkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set eintopfkoch ='" + cook_EintopfkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set pastetenkoch ='" + cook_PastetenkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set omelettkoch ='" + cook_OmelettKochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set salatkoch ='" + cook_SalatkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set suppenkoch ='" + cook_SuppenkochLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();

                    break;
                //Nutz- & Reittiere
                case 9:
                    new MySqlCommand("update albionprogram.playerfarming set kraeuterarztstufe ='" + kraut_ErnterLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set nutzpflanzenbauer ='" + nutzpflanzenbauerLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    new MySqlCommand("update albionprogram.playerfarming set hirte ='" + hirteLvl.SelectedItem.ToString() + "' where farm_playername ='" + globalVariable.name + "';", connectDB).ExecuteNonQuery();
                    break;
            }
        }

        private void tabControl1_Deselected(object sender, TabControlEventArgs e)
        {
            try
            {
                connectDB.Open();
                updatefunction(e);
                connectDB.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            #region gathering
            //gathering
            string cbErzStatement = "select erz from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbholzStatement = "select holz from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbwolleStatement = "select wolle from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbfellStatement = "select fell from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbsteinStatement = "select stein from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";

            MySqlCommand cBErzCommand = new MySqlCommand(cbErzStatement, connectDB);
            MySqlCommand cBholzCommand = new MySqlCommand(cbholzStatement, connectDB);
            MySqlCommand cBwolleCommand = new MySqlCommand(cbwolleStatement, connectDB);
            MySqlCommand cBfellCommand = new MySqlCommand(cbfellStatement, connectDB);
            MySqlCommand cBsteinCommand = new MySqlCommand(cbsteinStatement, connectDB);
            #endregion 

            #region refining
            //refining
            string cbMetallStatement = "select metall from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbPlankeStatement = "select planke from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbStoffStatement = "select stoff from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbLederStatement = "select leder from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";
            string cbSteinblockStatement = "select steinblock from albionprogram.playergathering where gath_playername ='" + globalVariable.name + "';";

            MySqlCommand cBMetallCommand = new MySqlCommand(cbMetallStatement, connectDB);
            MySqlCommand cBPlankeCommand = new MySqlCommand(cbPlankeStatement, connectDB);
            MySqlCommand cBStoffCommand = new MySqlCommand(cbStoffStatement, connectDB);
            MySqlCommand cBLederCommand = new MySqlCommand(cbLederStatement, connectDB);
            MySqlCommand cBSteinblockCommand = new MySqlCommand(cbSteinblockStatement, connectDB);
            #endregion

            #region Crafting_warrior
            string cbschwertschmiedStatement = "select schwertschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbbreitschwertStatement = "select breitschwert from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbclaymoreStatement = "select claymore from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbzweischwerterStatement = "select zweischwerter from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBSchwertschmiedCommand = new MySqlCommand(cbschwertschmiedStatement, connectDB);
            MySqlCommand cBBreitschwertCommand = new MySqlCommand(cbbreitschwertStatement, connectDB);
            MySqlCommand cBClaymoreCommand = new MySqlCommand(cbclaymoreStatement, connectDB);
            MySqlCommand cBZweischwerterCommand = new MySqlCommand(cbzweischwerterStatement, connectDB);

            string cbaxtschmiedStatement = "select axtschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbkriegsaxtStatement = "select kriegsaxt from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbgrossaxtStatement = "select großaxt from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbhellebardeStatement = "select hellebarde from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBAxtschmiedCommand = new MySqlCommand(cbaxtschmiedStatement, connectDB);
            MySqlCommand cBKriegsaxtCommand = new MySqlCommand(cbkriegsaxtStatement, connectDB);
            MySqlCommand cBGrossaxtCommand = new MySqlCommand(cbgrossaxtStatement, connectDB);
            MySqlCommand cBHellebardeCommand = new MySqlCommand(cbhellebardeStatement, connectDB);

            string cbkeulenschmiedStatement = "select keulenschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbkeuleStatement = "select keule from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbschwerekeuleStatement = "select schwerekeule from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbflegelStatement = "select flegel from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBKeulenschmiedCommand = new MySqlCommand(cbkeulenschmiedStatement, connectDB);
            MySqlCommand cBKeulenCommand = new MySqlCommand(cbkeuleStatement, connectDB);
            MySqlCommand cBschwereKeuleCommand = new MySqlCommand(cbschwerekeuleStatement, connectDB);
            MySqlCommand cBFlegelCommand = new MySqlCommand(cbflegelStatement, connectDB);

            string cbhammerschmiedStatement = "select hammerschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbhammerStatement = "select hammer from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbhammerstangenwaffenStatement = "select hammerstangenwaffen from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbgrosshammerStatement = "select grosshammer from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBHammerschmiedCommand = new MySqlCommand(cbhammerschmiedStatement, connectDB);
            MySqlCommand cBHammerCommand = new MySqlCommand(cbhammerStatement, connectDB);
            MySqlCommand cBHammerstangenwaffenCommand = new MySqlCommand(cbhammerstangenwaffenStatement, connectDB);
            MySqlCommand cBGrosshammerCommand = new MySqlCommand(cbgrosshammerStatement, connectDB);

            string cbarmbrustschmiedStatement = "select armbrustschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbarmbrustStatement = "select armbrust from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbschwerearmbrustStatement = "select schwerearmbrust from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";
            string cbeinhandarmbrustStatement = "select einhandarmbrust from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBArmbrustschmiedCommand = new MySqlCommand(cbarmbrustschmiedStatement, connectDB);
            MySqlCommand cBArmbrustCommand = new MySqlCommand(cbarmbrustStatement, connectDB);
            MySqlCommand cBSchwereArmbrustCommand = new MySqlCommand(cbschwerearmbrustStatement, connectDB);
            MySqlCommand cBEinhandarmbrustCommand = new MySqlCommand(cbeinhandarmbrustStatement, connectDB);

            string cbschildschmiedStatement = "select schildschmiedstufe from albionprogram.craftingweaponwarrior where craftweaponwarrior_playername ='" + globalVariable.name + "';";

            MySqlCommand cBSchildschmiedCommand = new MySqlCommand(cbschildschmiedStatement, connectDB);

            #endregion

            #region Crafting_hunter
            string cbbogenmacherStatement = "select bogenmacherstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbbogenStatement = "select bogen from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbkriegsbogenStatement = "select kriegsbogen from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cblangbogenStatement = "select langbogen from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBBogenmacherCommand = new MySqlCommand(cbbogenmacherStatement, connectDB);
            MySqlCommand cBBogenCommand = new MySqlCommand(cbbogenStatement, connectDB);
            MySqlCommand cBKriegsbogenCommand = new MySqlCommand(cbkriegsbogenStatement, connectDB);
            MySqlCommand cBLangbogenCommand = new MySqlCommand(cblangbogenStatement, connectDB);

            string cbspeerschmiedStatement = "select speerschmiedstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbspeerStatement = "select speer from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbpikenStatement = "select piken from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbglefeStatement = "select glefe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBSpeerschmiedCommand = new MySqlCommand(cbspeerschmiedStatement, connectDB);
            MySqlCommand cBSpeerCommand = new MySqlCommand(cbspeerStatement, connectDB);
            MySqlCommand cBPikenCommand = new MySqlCommand(cbpikenStatement, connectDB);
            MySqlCommand cBGlefeCommand = new MySqlCommand(cbglefeStatement, connectDB);

            string cbnaturstabschmiedStatement = "select naturstabschmiedstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbnaturstabStatement = "select naturstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbgrossernaturstabStatement = "select grossernaturstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbwildstabStatement = "select wildstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBNaturstabschmiedCommand = new MySqlCommand(cbnaturstabschmiedStatement, connectDB);
            MySqlCommand cBNaturstabCommand = new MySqlCommand(cbnaturstabStatement, connectDB);
            MySqlCommand cBgrosserNaturstabCommand = new MySqlCommand(cbgrossernaturstabStatement, connectDB);
            MySqlCommand cBWildstabCommand = new MySqlCommand(cbwildstabStatement, connectDB);

            string cbdolchschmiedStatement = "select dolchschmiedstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbdolchStatement = "select dolch from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbdolchpaarStatement = "select dolchpaar from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbklauenpaarStatement = "select klauenpaar from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBDolchschmiedCommand = new MySqlCommand(cbdolchschmiedStatement, connectDB);
            MySqlCommand cBDolchCommand = new MySqlCommand(cbdolchStatement, connectDB);
            MySqlCommand cBDolchpaarCommand = new MySqlCommand(cbdolchpaarStatement, connectDB);
            MySqlCommand cBKlauenpaarCommand = new MySqlCommand(cbklauenpaarStatement, connectDB);

            string cbkampfstabschmiedStatement = "select kampfstabschmiedstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbkampfstabStatement = "select kampfstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbeisenpanzerstabStatement = "select eisenpanzerstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";
            string cbdoppelklingenstabStatement = "select doppelklingenstab from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBKampfstabschmiedCommand = new MySqlCommand(cbkampfstabschmiedStatement, connectDB);
            MySqlCommand cBKampfstabCommand = new MySqlCommand(cbkampfstabStatement, connectDB);
            MySqlCommand cBEisenpanzerstabCommand = new MySqlCommand(cbeisenpanzerstabStatement, connectDB);
            MySqlCommand cBDoppelklingenstabCommand = new MySqlCommand(cbdoppelklingenstabStatement, connectDB);

            string cbfackelschmiedStatement = "select fackelschmiedstufe from albionprogram.craftingweaponhunter where craftingweaponhunter_playername ='" + globalVariable.name + "';";

            MySqlCommand cBFackelschmiedCommand = new MySqlCommand(cbfackelschmiedStatement, connectDB);
            #endregion

            #region Crafting_mage

            string cbfeuerstabschmiedstufeStatement = "select feuerstabschmiedstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbfeuerstabStatement = "select feuerstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgrosserfeuerstabStatement = "select grosserfeuerstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbhoellenstabStatement = "select hoellenstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBFeuerstabschmiedstufeCommand = new MySqlCommand(cbfeuerstabschmiedstufeStatement, connectDB);
            MySqlCommand cBFeuerstabCommand = new MySqlCommand(cbfeuerstabStatement, connectDB);
            MySqlCommand cBgrosserFeuerstabCommand = new MySqlCommand(cbgrosserfeuerstabStatement, connectDB);
            MySqlCommand cBHoellenstabCommand = new MySqlCommand(cbhoellenstabStatement, connectDB);

            string cbheiligenstabschmiedstufeStatement = "select heiligenstabschmiedstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbheiligenstabStatement = "select heiligenstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgrosserheiligenstabStatement = "select grosserheiligenstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgottesstabStatement = "select gottesstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBHeiligenstabschmiedstufeCommand = new MySqlCommand(cbheiligenstabschmiedstufeStatement, connectDB);
            MySqlCommand cBHeiligenstabCommand = new MySqlCommand(cbheiligenstabStatement, connectDB);
            MySqlCommand cBgrosserHeiligenstabCommand = new MySqlCommand(cbgrosserheiligenstabStatement, connectDB);
            MySqlCommand cBGottesstabCommand = new MySqlCommand(cbgottesstabStatement, connectDB);

            string cbgeheimstabschmiedstufeStatement = "select geheimstabschmiedstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgeheimstabStatement = "select geheimstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgrossergeheimstabStatement = "select grossergeheimstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbmysterioeserstabStatement = "select mysterioeserstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBGeheimstabschmiedstufeCommand = new MySqlCommand(cbgeheimstabschmiedstufeStatement, connectDB);
            MySqlCommand cBGeheimstabCommand = new MySqlCommand(cbgeheimstabStatement, connectDB);
            MySqlCommand cBgrosserGeheimstabCommand = new MySqlCommand(cbgrossergeheimstabStatement, connectDB);
            MySqlCommand cBMysterioeserstabCommand = new MySqlCommand(cbmysterioeserstabStatement, connectDB);

            string cbfroststabschmiedstufeStatement = "select froststabschmiedstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbfroststabStatement = "select froststab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgrosserfroststabStatement = "select grosserfroststab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgletscherstabStatement = "select gletscherstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBFroststabschmiedstufeCommand = new MySqlCommand(cbfroststabschmiedstufeStatement, connectDB);
            MySqlCommand cBFroststabCommand = new MySqlCommand(cbfroststabStatement, connectDB);
            MySqlCommand cBgrosserFroststabCommand = new MySqlCommand(cbgrosserfroststabStatement, connectDB);
            MySqlCommand cBGletscherstabCommand = new MySqlCommand(cbgletscherstabStatement, connectDB);

            string cbverfluchterstabschmiedstufeStatement = "select verfluchterstabschmiedstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbverfluchterstabStatement = "select verfluchterstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbgrosserverfluchterstabStatement = "select grosserverfluchterstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";
            string cbdaemonenstabStatement = "select daemonenstab from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBverfluchterStabschmiedstufeCommand = new MySqlCommand(cbverfluchterstabschmiedstufeStatement, connectDB);
            MySqlCommand cBVerfluchterstabCommand = new MySqlCommand(cbverfluchterstabStatement, connectDB);
            MySqlCommand cBgrosserVerfluchterstabCommand = new MySqlCommand(cbgrosserverfluchterstabStatement, connectDB);
            MySqlCommand cBDaemonenstabCommand = new MySqlCommand(cbdaemonenstabStatement, connectDB);

            string cbbuchbinderstufeStatement = "select buchbinderstufe from albionprogram.craftingweaponmage where craftingweaponmage_playername ='" + globalVariable.name + "';";

            MySqlCommand cBBuchbinderstufeCommand = new MySqlCommand(cbbuchbinderstufeStatement, connectDB);

            #endregion

            #region Craftion_tools

            string cbabbruchhammerStatement = "select abbruchhammer from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbsichelStatement = "select sichel from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbabhaeutemesserStatement = "select abhäutemesser from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbspitzhackeStatement = "select spitzhacke from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbsteinhammerStatement = "select steinhammer from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbaxtStatement = "select axt from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";

            string cbumhangschneiderStatement = "select umhangschneider from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";
            string cbtaschenschneiderStatement = "select taschenschneider from albionprogram.craftingtools where craftingtools_playername ='" + globalVariable.name + "';";

            MySqlCommand cBAbbruchhammerCommand = new MySqlCommand(cbabbruchhammerStatement, connectDB);
            MySqlCommand cBSichelCommand = new MySqlCommand(cbsichelStatement, connectDB);
            MySqlCommand cBAbhaeutemesserCommand = new MySqlCommand(cbabhaeutemesserStatement, connectDB);
            MySqlCommand cBSpitzhackeCommand = new MySqlCommand(cbspitzhackeStatement, connectDB);
            MySqlCommand cBSteinhammerCommand = new MySqlCommand(cbsteinhammerStatement, connectDB);
            MySqlCommand cBAxtCommand = new MySqlCommand(cbaxtStatement, connectDB);

            MySqlCommand cBUmhangschneiderCommand = new MySqlCommand(cbumhangschneiderStatement, connectDB);
            MySqlCommand cBTaschenschneiderCommand = new MySqlCommand(cbtaschenschneiderStatement, connectDB);

            #endregion

            #region alchimist

            string cbkraeuterarztstufeStatement = "select alchimiststufe from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbschmugglerStatement = "select schmuggler from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbreinigungsbrauerStatement = "select reinigungsbrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbabklingzeitbrauerStatement = "select abklingzeitbrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbverlangsamungsfeldbrauerStatement = "select verlangsamungsfeldbrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbsteinhautbrauerStatement = "select steinhautbrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbwiederbelebungsbrauerStatement = "select wiederbelebungsbrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbenergiebrauerStatement = "select energiebrauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbumschlagvorbereiterStatement = "select umschlagvorbereiter from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";

            MySqlCommand cBKraeuterarztstufeCommand = new MySqlCommand(cbkraeuterarztstufeStatement, connectDB);
            MySqlCommand cBSchmugglerCommand = new MySqlCommand(cbschmugglerStatement, connectDB);
            MySqlCommand cBReinigungsbrauerCommand = new MySqlCommand(cbreinigungsbrauerStatement, connectDB);
            MySqlCommand cBAbklingzeitbrauerCommand = new MySqlCommand(cbabklingzeitbrauerStatement, connectDB);
            MySqlCommand cBVerlangsamungsfeldbrauerCommand = new MySqlCommand(cbverlangsamungsfeldbrauerStatement, connectDB);
            MySqlCommand cBSteinhautbrauerCommand = new MySqlCommand(cbsteinhautbrauerStatement, connectDB);
            MySqlCommand cBWiederbelebungsbrauerCommand = new MySqlCommand(cbwiederbelebungsbrauerStatement, connectDB);
            MySqlCommand cBEnergiebrauerCommand = new MySqlCommand(cbenergiebrauerStatement, connectDB);
            MySqlCommand cBUmschlagvorbereiterCommand = new MySqlCommand(cbumschlagvorbereiterStatement, connectDB);

            #endregion

            #region koch

            string cbkochstufeStatement = "select kochstufe from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbmetzgereiStatement = "select metzgerei from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbmuellerStatement = "select mueller from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbsandwichkochStatement = "select sandwichkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbeintopfkochStatement = "select eintopfkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbpastetenkochStatement = "select pastetenkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbomelettkochStatement = "select omelettkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbsalatkochStatement = "select salatkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbsuppenkochStatement = "select suppenkoch from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            

            MySqlCommand cBKochstufeCommand = new MySqlCommand(cbkochstufeStatement, connectDB);
            MySqlCommand cBMetzgereiCommand = new MySqlCommand(cbmetzgereiStatement, connectDB);
            MySqlCommand cBMuellerCommand = new MySqlCommand(cbmuellerStatement, connectDB);
            MySqlCommand cBSandwichkochCommand = new MySqlCommand(cbsandwichkochStatement, connectDB);
            MySqlCommand cBEintopfkochCommand = new MySqlCommand(cbeintopfkochStatement, connectDB);
            MySqlCommand cBPastetenkochCommand = new MySqlCommand(cbpastetenkochStatement, connectDB);
            MySqlCommand cBOmelettkochCommand = new MySqlCommand(cbomelettkochStatement, connectDB);
            MySqlCommand cBSalatkochCommand = new MySqlCommand(cbsalatkochStatement, connectDB);
            MySqlCommand cBSuppenkochCommand = new MySqlCommand(cbsuppenkochStatement, connectDB);
            
            #endregion

            #region ernter
            string cbernterstufeStatement = "select kraeuterarztstufe from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbnutzpflanzenStatement = "select nutzpflanzenbauer from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";
            string cbhirteStatement = "select hirte from albionprogram.playerfarming where farm_playername ='" + globalVariable.name + "';";

            MySqlCommand cBErnterstufeCommand = new MySqlCommand(cbernterstufeStatement, connectDB);
            MySqlCommand cBNutzpflanzenCommand = new MySqlCommand(cbnutzpflanzenStatement, connectDB);
            MySqlCommand cBHirteCommand = new MySqlCommand(cbhirteStatement, connectDB);
            #endregion

            #region equipment

            string cbWeaponStatement = "select attr_waffe from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbOffhandStatement = "select attr_offhand from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbHeadStatement = "select attr_kopf from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbChestStatement = "select attr_brust from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbShoesStatement = "select attr_fuss from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            
            MySqlCommand cBWeaponCommand = new MySqlCommand(cbWeaponStatement, connectDB);
            MySqlCommand cBOffhandCommand = new MySqlCommand(cbOffhandStatement, connectDB);
            MySqlCommand cBHeadCommand = new MySqlCommand(cbHeadStatement, connectDB);
            MySqlCommand cBChestCommand = new MySqlCommand(cbChestStatement, connectDB);
            MySqlCommand cBShoesCommand = new MySqlCommand(cbShoesStatement, connectDB);

            string cbTankStatement = "select attr_tank from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbSingleMeleeStatement = "select attr_ddsinglemelee from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbSingleRangeStatement = "select attr_ddsinglerange from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbSingleHealStatement = "select attr_singleheal from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbAoEMeleeStatement = "select attr_ddaoemelee from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbAoERangeStatement = "select attr_ddaorrange from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbAoEHealStatement = "select attr_aoeheal from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";
            string cbSupportStatement = "select attr_support from albionprogram.playerattribute where attr_playername ='" + globalVariable.name + "';";

            MySqlCommand cBTankCommand = new MySqlCommand(cbTankStatement, connectDB);
            MySqlCommand cBSingleMeleeCommand = new MySqlCommand(cbSingleMeleeStatement, connectDB);
            MySqlCommand cBSingleRangeCommand = new MySqlCommand(cbSingleRangeStatement, connectDB);
            MySqlCommand cBSingleHealCommand = new MySqlCommand(cbSingleHealStatement, connectDB);
            MySqlCommand cBAoEMeleeCommand = new MySqlCommand(cbAoEMeleeStatement, connectDB);
            MySqlCommand cBAoERangeCommand = new MySqlCommand(cbAoERangeStatement, connectDB);
            MySqlCommand cBAoEHealCommand = new MySqlCommand(cbAoEHealStatement, connectDB);
            MySqlCommand cBSupportCommand = new MySqlCommand(cbSupportStatement, connectDB);


            #endregion

            #region Crafting_Armor

            string cbplateheadStatement = "select plattekopf from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbplatechestStatement = "select plattebrust from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbplateshoestatement = "select plattestiefel from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";

            string cbleadherheadStatement = "select lederkopf from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbleadherchestStatement = "select lederbrust from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbleadhershoesStatement = "select lederstiefel from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";

            string cbclothheadStatement = "select stoffkopf from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbclothchestStatement = "select stoffbrust from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";
            string cbclothshoesStatement = "select stoffstiefel from albionprogram.craftingarmor where craftarmor_playername ='" + globalVariable.name + "';";

            MySqlCommand cBPlateHeadCommand = new MySqlCommand(cbplateheadStatement, connectDB);
            MySqlCommand cBPlateChestCommand = new MySqlCommand(cbplatechestStatement, connectDB);
            MySqlCommand cBPlateShoesCommand = new MySqlCommand(cbplateshoestatement, connectDB);

            MySqlCommand cBLeadherHeadCommand = new MySqlCommand(cbleadherheadStatement, connectDB);
            MySqlCommand cBLeadherChestCommand = new MySqlCommand(cbleadherchestStatement, connectDB);
            MySqlCommand cBLeadherShoesCommand = new MySqlCommand(cbleadhershoesStatement, connectDB);

            MySqlCommand cBClothHeadCommand = new MySqlCommand(cbclothheadStatement, connectDB);
            MySqlCommand cBClothChestCommand = new MySqlCommand(cbclothchestStatement, connectDB);
            MySqlCommand cBClothShoesCommand = new MySqlCommand(cbclothshoesStatement, connectDB);

            #endregion
            connectDB.Open();
            try 
            {
                switch(e.TabPageIndex)
                {
                    case 0:
                    
                      //gathering
                        gath_erzLvl.SelectedIndex = Convert.ToInt32(cBErzCommand.ExecuteScalar().ToString());
                        gath_holzLvl.SelectedIndex = Convert.ToInt32(cBholzCommand.ExecuteScalar().ToString());
                        gath_wolleLvl.SelectedIndex = Convert.ToInt32(cBwolleCommand.ExecuteScalar().ToString());
                        gath_fellLvl.SelectedIndex = Convert.ToInt32(cBfellCommand.ExecuteScalar().ToString());
                        gath_steinLvl.SelectedIndex = Convert.ToInt32(cBsteinCommand.ExecuteScalar().ToString());

                      //refining
                        refine_metallstangeLvl.SelectedIndex = Convert.ToInt32(cBMetallCommand.ExecuteScalar().ToString());
                        refine_plankeLvl.SelectedIndex = Convert.ToInt32(cBPlankeCommand.ExecuteScalar().ToString());
                        refine_stoffLvl.SelectedIndex = Convert.ToInt32(cBStoffCommand.ExecuteScalar().ToString());
                        refine_lederLvl.SelectedIndex = Convert.ToInt32(cBLederCommand.ExecuteScalar().ToString());
                        refine_steinblockLvl.SelectedIndex = Convert.ToInt32(cBSteinblockCommand.ExecuteScalar().ToString());

                        break;
                    case 1:
                        String[] resultWeapon = cBWeaponCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        equip_weaponName.SelectedItem = resultWeapon[0];
                        equip_weaponLvl.SelectedIndex = Convert.ToInt32(resultWeapon[1].TrimStart(new char[] { 't' }));

                        String[] resultOffhand = cBOffhandCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        equip_offHandName.SelectedItem = resultOffhand[0];
                        equip_offHandLvl.SelectedIndex = Convert.ToInt32(resultOffhand[1].TrimStart(new char[] { 't' }));

                        String[] resultHead = cBHeadCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        equip_headName.SelectedItem = resultHead[0];
                        equip_headLvl.SelectedIndex = Convert.ToInt32(resultHead[1].TrimStart(new char[] { 't' }));

                        String[] resultChest = cBChestCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        equip_chestName.SelectedItem = resultChest[0];
                        equip_chestLvl.SelectedIndex = Convert.ToInt32(resultChest[1].TrimStart(new char[] { 't' }));

                        String[] resultShoes = cBShoesCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        equip_shoesName.SelectedItem = resultShoes[0];
                        equip_shoesLvl.SelectedIndex = Convert.ToInt32(resultShoes[1].TrimStart(new char[] { 't' }));

                        if (cBTankCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_Tank.Checked = true;
                        if (cBSingleMeleeCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_DD_Single_Melee.Checked = true;
                        if (cBSingleRangeCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_DD_Single_Range.Checked = true;
                        if (cBSingleHealCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_single_Healer.Checked = true;
                        if (cBAoEMeleeCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_DD_AoE_Melee.Checked = true;
                        if (cBAoERangeCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_DD_AoE_Range.Checked = true;
                        if (cBAoEHealCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_AoE_Healer.Checked = true;
                        if (cBSupportCommand.ExecuteScalar().ToString().Equals("X"))
                            cB_Support.Checked = true;

                        break;
                    case 2:

                        String[] resultplatehead = cBPlateHeadCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_PlateHeadName.SelectedItem = resultplatehead[0];
                        craft_PlateHeadLvl.SelectedIndex = Convert.ToInt32(resultplatehead[1].TrimStart(new char[] { 't' }));

                        String[] resultplatechest = cBPlateChestCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_PlateChestName.SelectedItem = resultplatechest[0];
                        craft_PlateChestLvl.SelectedIndex = Convert.ToInt32(resultplatechest[1].TrimStart(new char[] { 't' }));

                        String[] resultplateshoes = cBPlateShoesCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_PlateShoesName.SelectedItem = resultplateshoes[0];
                        craft_PlateShoesLvl.SelectedIndex = Convert.ToInt32(resultplateshoes[1].TrimStart(new char[] { 't' }));


                        String[] resultleadherhead = cBLeadherHeadCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_LeatherHeadName.SelectedItem = resultleadherhead[0];
                        craft_LeatherHeadLvl.SelectedIndex = Convert.ToInt32(resultleadherhead[1].TrimStart(new char[] { 't' }));

                        String[] resultleadherchest = cBLeadherChestCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        craft_LeatherChestName.SelectedItem = resultleadherchest[0];
                        craft_LeatherChestLvl.SelectedIndex = Convert.ToInt32(resultleadherchest[1].TrimStart(new char[] { 't' }));

                        String[] resultleadhershoes = cBLeadherShoesCommand.ExecuteScalar().ToString().Split(new char[] { ' ' });
                        craft_LeatherShoesName.SelectedItem = resultleadhershoes[0];
                        craft_LeatherShoesLvl.SelectedIndex = Convert.ToInt32(resultleadhershoes[1].TrimStart(new char[] { 't' }));


                        String[] resultclothhead = cBClothHeadCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_ClothHeadName.SelectedItem = resultclothhead[0];
                        craft_ClothHeadLvl.SelectedIndex = Convert.ToInt32(resultclothhead[1].TrimStart(new char[] { 't' }));

                        String[] resultclothchest = cBClothChestCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_ClothChestName.SelectedItem = resultclothchest[0];
                        craft_ClothChestLvl.SelectedIndex = Convert.ToInt32(resultclothchest[1].TrimStart(new char[] { 't' }));

                        String[] resultclothshoes = cBClothShoesCommand.ExecuteScalar().ToString().Split(new char[] {' '});
                        craft_ClothShoesName.SelectedItem = resultclothshoes[0];
                        craft_ClothShoesLvl.SelectedIndex = Convert.ToInt32(resultclothshoes[1].TrimStart(new char[] { 't' }));

                        break;
                    case 3:
                    
                        warrior_SchwertschmiedLvl.SelectedIndex = Convert.ToInt32(cBSchwertschmiedCommand.ExecuteScalar().ToString());
                        warrior_BreitschwertLvl.SelectedIndex = Convert.ToInt32(cBBreitschwertCommand.ExecuteScalar().ToString());
                        warrior_ClaymoreLvl.SelectedIndex = Convert.ToInt32(cBClaymoreCommand.ExecuteScalar().ToString());
                        warrior_ZweischwerterLvl.SelectedIndex = Convert.ToInt32(cBZweischwerterCommand.ExecuteScalar().ToString());

                        warrior_AxtschmiedLvl.SelectedIndex = Convert.ToInt32(cBAxtschmiedCommand.ExecuteScalar().ToString());
                        warrior_KriegsAxtLvl.SelectedIndex = Convert.ToInt32(cBKriegsaxtCommand.ExecuteScalar().ToString());
                        warrior_GrossaxtLvl.SelectedIndex = Convert.ToInt32(cBGrossaxtCommand.ExecuteScalar().ToString());
                        warrior_HellebardeLvl.SelectedIndex = Convert.ToInt32(cBHellebardeCommand.ExecuteScalar().ToString());

                        warrior_KeulenschmiedLvl.SelectedIndex = Convert.ToInt32(cBKeulenschmiedCommand.ExecuteScalar().ToString());
                        warrior_KeuleLvl.SelectedIndex = Convert.ToInt32(cBKeulenCommand.ExecuteScalar().ToString());
                        warrior_schwereKeuleLvl.SelectedIndex = Convert.ToInt32(cBschwereKeuleCommand.ExecuteScalar().ToString());
                        warrior_FlegelLvl.SelectedIndex = Convert.ToInt32(cBFlegelCommand.ExecuteScalar().ToString());

                        warrior_HammerschmiedLvl.SelectedIndex = Convert.ToInt32(cBHammerschmiedCommand.ExecuteScalar().ToString());
                        warrior_HammerLvl.SelectedIndex = Convert.ToInt32(cBHammerCommand.ExecuteScalar().ToString());
                        warrior_HammerstangenwaffeLvl.SelectedIndex = Convert.ToInt32(cBHammerstangenwaffenCommand.ExecuteScalar().ToString());
                        warrior_GrosshammerLvl.SelectedIndex = Convert.ToInt32(cBGrosshammerCommand.ExecuteScalar().ToString());

                        warrior_ArmbrustschmiedLvl.SelectedIndex = Convert.ToInt32(cBArmbrustschmiedCommand.ExecuteScalar().ToString());
                        warrior_ArmbrustLvl.SelectedIndex = Convert.ToInt32(cBArmbrustCommand.ExecuteScalar().ToString());
                        warrior_schwereArmbrustLvl.SelectedIndex = Convert.ToInt32(cBSchwereArmbrustCommand.ExecuteScalar().ToString());
                        warrior_einhandArmbrustLvl.SelectedIndex = Convert.ToInt32(cBEinhandarmbrustCommand.ExecuteScalar().ToString());

                        warrior_SchildschmiedLvl.SelectedIndex = Convert.ToInt32(cBSchildschmiedCommand.ExecuteScalar().ToString());
                    
                        break;
                    case 4:

                        hunter_BogenmacherLvl.SelectedIndex = Convert.ToInt32(cBBogenmacherCommand.ExecuteScalar().ToString());
                        hunter_BogenLvl.SelectedIndex = Convert.ToInt32(cBBogenCommand.ExecuteScalar().ToString());
                        hunter_KriegsbogenLvl.SelectedIndex = Convert.ToInt32(cBKriegsbogenCommand.ExecuteScalar().ToString());
                        hunter_LangbogenLvl.SelectedIndex = Convert.ToInt32(cBLangbogenCommand.ExecuteScalar().ToString());

                        hunter_SpeerschmiedLvl.SelectedIndex = Convert.ToInt32(cBSpeerschmiedCommand.ExecuteScalar().ToString());
                        hunter_speerLvl.SelectedIndex = Convert.ToInt32(cBSpeerCommand.ExecuteScalar().ToString());
                        hunter_pikenLvl.SelectedIndex = Convert.ToInt32(cBPikenCommand.ExecuteScalar().ToString());
                        hunter_glefeLvl.SelectedIndex = Convert.ToInt32(cBGlefeCommand.ExecuteScalar().ToString());

                        hunter_NaturstabschmiedLvl.SelectedIndex = Convert.ToInt32(cBNaturstabschmiedCommand.ExecuteScalar().ToString());
                        hunter_naturstabLvl.SelectedIndex = Convert.ToInt32(cBNaturstabCommand.ExecuteScalar().ToString());
                        hunter_grosserNaturstabLvl.SelectedIndex = Convert.ToInt32(cBgrosserNaturstabCommand.ExecuteScalar().ToString());
                        hunter_wildstabLvl.SelectedIndex = Convert.ToInt32(cBWildstabCommand.ExecuteScalar().ToString());

                        hunter_DolchschmiedLvl.SelectedIndex = Convert.ToInt32(cBDolchschmiedCommand.ExecuteScalar().ToString());
                        hunter_DolchLvl.SelectedIndex = Convert.ToInt32(cBDolchCommand.ExecuteScalar().ToString());
                        hunter_dolchpaarLvl.SelectedIndex = Convert.ToInt32(cBDolchpaarCommand.ExecuteScalar().ToString());
                        hunter_klauenpaarLvl.SelectedIndex = Convert.ToInt32(cBKlauenpaarCommand.ExecuteScalar().ToString());

                        hunter_KampfstabschmiedLvl.SelectedIndex = Convert.ToInt32(cBKampfstabschmiedCommand.ExecuteScalar().ToString());
                        hunter_kampfstabLvl.SelectedIndex = Convert.ToInt32(cBKampfstabCommand.ExecuteScalar().ToString());
                        hunter_eisenpanzerstabLvl.SelectedIndex = Convert.ToInt32(cBEisenpanzerstabCommand.ExecuteScalar().ToString());
                        hunter_DoppelklingenstabLvl.SelectedIndex = Convert.ToInt32(cBDoppelklingenstabCommand.ExecuteScalar().ToString());

                        hunter_FackelschmiedLvl.SelectedIndex = Convert.ToInt32(cBFackelschmiedCommand.ExecuteScalar().ToString());

                        break;
                    case 5:
                        mage_FeuerstabschmiedLvl.SelectedIndex = Convert.ToInt32(cBFeuerstabschmiedstufeCommand.ExecuteScalar().ToString());
                        mage_feuerstabLvl.SelectedIndex = Convert.ToInt32(cBFeuerstabCommand.ExecuteScalar().ToString());
                        mage_grosserfeuerstabLvl.SelectedIndex = Convert.ToInt32(cBgrosserFeuerstabCommand.ExecuteScalar().ToString());
                        mage_hoellenstabLvl.SelectedIndex = Convert.ToInt32(cBHoellenstabCommand.ExecuteScalar().ToString());

                        mage_HeiligenstabschmiedLvl.SelectedIndex = Convert.ToInt32(cBHeiligenstabschmiedstufeCommand.ExecuteScalar().ToString());
                        mage_heiligenstabLvl.SelectedIndex = Convert.ToInt32(cBHeiligenstabCommand.ExecuteScalar().ToString());
                        mage_grosserheiligenstabLvl.SelectedIndex = Convert.ToInt32(cBgrosserHeiligenstabCommand.ExecuteScalar().ToString());
                        mage_gottesstabLvl.SelectedIndex = Convert.ToInt32(cBGottesstabCommand.ExecuteScalar().ToString());

                        mage_geheimstabschmiedLvl.SelectedIndex = Convert.ToInt32(cBGeheimstabschmiedstufeCommand.ExecuteScalar().ToString());
                        mage_geheimstabLvl.SelectedIndex = Convert.ToInt32(cBGeheimstabCommand.ExecuteScalar().ToString());
                        mage_grossergeheimstabLvl.SelectedIndex = Convert.ToInt32(cBgrosserGeheimstabCommand.ExecuteScalar().ToString());
                        mage_mysterioeserStabLvl.SelectedIndex = Convert.ToInt32(cBMysterioeserstabCommand.ExecuteScalar().ToString());

                        mage_froststabschmiedLvl.SelectedIndex = Convert.ToInt32(cBFroststabschmiedstufeCommand.ExecuteScalar().ToString());
                        mage_froststabLvl.SelectedIndex = Convert.ToInt32(cBFroststabCommand.ExecuteScalar().ToString());
                        mage_grosserFroststabLvl.SelectedIndex = Convert.ToInt32(cBgrosserFroststabCommand.ExecuteScalar().ToString());
                        mage_GletscherstabLvl.SelectedIndex = Convert.ToInt32(cBGletscherstabCommand.ExecuteScalar().ToString());

                        mage_cursedStabschmiedLvl.SelectedIndex = Convert.ToInt32(cBverfluchterStabschmiedstufeCommand.ExecuteScalar().ToString());
                        mage_cursedStabLvl.SelectedIndex = Convert.ToInt32(cBVerfluchterstabCommand.ExecuteScalar().ToString());
                        mage_grosserCursedstabLvl.SelectedIndex = Convert.ToInt32(cBgrosserVerfluchterstabCommand.ExecuteScalar().ToString());
                        mage_daemonstabLvl.SelectedIndex = Convert.ToInt32(cBDaemonenstabCommand.ExecuteScalar().ToString());

                        mage_buchbinderLvl.SelectedIndex = Convert.ToInt32(cBBuchbinderstufeCommand.ExecuteScalar().ToString());
                        break;
                    case 6:

                        craft_ToolsAbbruchhammerLvl.SelectedIndex = Convert.ToInt32(cBAbbruchhammerCommand.ExecuteScalar().ToString());
                        craft_ToolsSichelLvl.SelectedIndex = Convert.ToInt32(cBSichelCommand.ExecuteScalar().ToString());
                        craft_ToolsAbhaeutemesserLvl.SelectedIndex = Convert.ToInt32(cBAbhaeutemesserCommand.ExecuteScalar().ToString());
                        craft_ToolsSpitzhackeLvl.SelectedIndex = Convert.ToInt32(cBSpitzhackeCommand.ExecuteScalar().ToString());
                        craft_ToolsSteinhammerLvl.SelectedIndex = Convert.ToInt32(cBSteinhammerCommand.ExecuteScalar().ToString());
                        craft_ToolsAxtLvl.SelectedIndex = Convert.ToInt32(cBAxtCommand.ExecuteScalar().ToString());

                        craft_AccessUmhangschneider.SelectedIndex = Convert.ToInt32(cBUmhangschneiderCommand.ExecuteScalar().ToString());
                        craft_AccessTaschenschneider.SelectedIndex = Convert.ToInt32(cBTaschenschneiderCommand.ExecuteScalar().ToString());

                        break;
                    case 7:

                        alchi_Lvl.SelectedIndex = Convert.ToInt32(cBKraeuterarztstufeCommand.ExecuteScalar().ToString());
                        alchi_schmugglerLvl.SelectedIndex = Convert.ToInt32(cBSchmugglerCommand.ExecuteScalar().ToString());
                        alchi_reinigungsbrauerLvl.SelectedIndex = Convert.ToInt32(cBReinigungsbrauerCommand.ExecuteScalar().ToString());
                        alchi_AbklingzeitbrauerLvl.SelectedIndex = Convert.ToInt32(cBAbklingzeitbrauerCommand.ExecuteScalar().ToString());
                        alchi_VerlangsamungsfeldLvl.SelectedIndex = Convert.ToInt32(cBVerlangsamungsfeldbrauerCommand.ExecuteScalar().ToString());
                        alchi_SteinhautbrauerLvl.SelectedIndex = Convert.ToInt32(cBSteinhautbrauerCommand.ExecuteScalar().ToString());
                        alchi_WiederbelebungsbrauerLvl.SelectedIndex = Convert.ToInt32(cBWiederbelebungsbrauerCommand.ExecuteScalar().ToString());
                        alchi_EnergiebrauerLvl.SelectedIndex = Convert.ToInt32(cBEnergiebrauerCommand.ExecuteScalar().ToString());
                        alchi_UmschlagvorbereiterLvl.SelectedIndex = Convert.ToInt32(cBUmschlagvorbereiterCommand.ExecuteScalar().ToString());

                        break;
                    case 8:

                        koch_Lvl.SelectedIndex = Convert.ToInt32(cBKochstufeCommand.ExecuteScalar().ToString());
                        cook_MetzgereiLvl.SelectedIndex = Convert.ToInt32(cBMetzgereiCommand.ExecuteScalar().ToString());
                        cook_MuellerLvl.SelectedIndex = Convert.ToInt32(cBMuellerCommand.ExecuteScalar().ToString());
                        cook_SandwichkochLvl.SelectedIndex = Convert.ToInt32(cBSandwichkochCommand.ExecuteScalar().ToString());
                        cook_EintopfkochLvl.SelectedIndex = Convert.ToInt32(cBEintopfkochCommand.ExecuteScalar().ToString());
                        cook_PastetenkochLvl.SelectedIndex = Convert.ToInt32(cBPastetenkochCommand.ExecuteScalar().ToString());
                        cook_OmelettKochLvl.SelectedIndex = Convert.ToInt32(cBOmelettkochCommand.ExecuteScalar().ToString());
                        cook_SalatkochLvl.SelectedIndex = Convert.ToInt32(cBSalatkochCommand.ExecuteScalar().ToString());
                        cook_SuppenkochLvl.SelectedIndex = Convert.ToInt32(cBSuppenkochCommand.ExecuteScalar().ToString());
                        
                        break;
                    case 9:
                        kraut_ErnterLvl.SelectedIndex = Convert.ToInt32(cBErnterstufeCommand.ExecuteScalar().ToString());
                        nutzpflanzenbauerLvl.SelectedIndex = Convert.ToInt32(cBNutzpflanzenCommand.ExecuteScalar().ToString());
                        hirteLvl.SelectedIndex = Convert.ToInt32(cBHirteCommand.ExecuteScalar().ToString());
                        break;
                    default:
                        break;

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc);
            }

            connectDB.Close();
        }

    }
}
