using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public partial class InventoryForm : Form
    {
        public InventoryForm(List<Character> characters, Vault vault)
        {
            InitializeComponent();
            InventoryControl inventoryControl = new InventoryControl(characters, vault)
            {
                Dock = DockStyle.Fill
            };
            inventoryControl.CloseInventoryRequested += InventoryControl_CloseInventoryRequested; // Subscribe to the event
            Controls.Add(inventoryControl);

            // Set to full screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Set background image
            //this.BackgroundImage = Image.FromFile("C:\\Users\\emoco\\Downloads\\A_geometric_low-poly_background_for_PVRL_compatible_3k.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InventoryControl_CloseInventoryRequested(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
        }

        private void InventoryForm_Load(object sender, System.EventArgs e)
        {
        }
    }
}
