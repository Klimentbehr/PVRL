using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public partial class CraftingForm : Form
    {
        public CraftingForm(List<Character> characters, Vault vault)
        {
            InitializeComponent();
            CraftingControl craftingControl = new CraftingControl(characters, vault)
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(craftingControl);

            // Set to full screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Set background image
           // this.BackgroundImage = Image.FromFile("C:\\Users\\emoco\\Downloads\\A_geometric_low-poly_background_for_PVRL_compatible_3k.png");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // CraftingForm
            // 
            ClientSize = new Size(1285, 450);
            Name = "CraftingForm";
            Load += CraftingForm_Load;
            ResumeLayout(false);
        }

        private void CraftingForm_Load(object sender, EventArgs e)
        {
        }
    }
}
