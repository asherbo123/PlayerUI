namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            custmizeDesign();
        }

        private void custmizeDesign()
        {
            panelMediaSubmenu.Visible= false;
            panelPlaylistSubmenu.Visible= false;
            panelToolsSubmenu.Visible= false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible= false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible= false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible= false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
        #endregion
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }
        #region playlistSubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }
        #region ToolsSubMenu
        private void button15_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}