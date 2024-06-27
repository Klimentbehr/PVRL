namespace PVRL
{
    partial class FactionHomeScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactionHomeScreen));
            flowLayoutPanelMissions = new FlowLayoutPanel();
            panelButtons = new Panel();
            btnReturnToMain = new Button();
            btnManageCharacter = new Button();
            mainLayoutPanel = new TableLayoutPanel();
            panelButtons.SuspendLayout();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMissions
            // 
            flowLayoutPanelMissions.BackgroundImage = (Image)resources.GetObject("flowLayoutPanelMissions.BackgroundImage");
            flowLayoutPanelMissions.Dock = DockStyle.Fill;
            flowLayoutPanelMissions.Location = new Point(3, 3);
            flowLayoutPanelMissions.Name = "flowLayoutPanelMissions";
            flowLayoutPanelMissions.Size = new Size(794, 444);
            flowLayoutPanelMissions.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackgroundImage = (Image)resources.GetObject("panelButtons.BackgroundImage");
            panelButtons.Controls.Add(btnReturnToMain);
            panelButtons.Controls.Add(btnManageCharacter);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 453);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(794, 44);
            panelButtons.TabIndex = 1;
            // 
            // btnReturnToMain
            // 
            btnReturnToMain.Location = new Point(3, 3);
            btnReturnToMain.Name = "btnReturnToMain";
            btnReturnToMain.Size = new Size(150, 38);
            btnReturnToMain.TabIndex = 0;
            btnReturnToMain.Text = "Return to Main";
            btnReturnToMain.UseVisualStyleBackColor = true;
            btnReturnToMain.Click += BtnReturnToMain_Click;
            // 
            // btnManageCharacter
            // 
            btnManageCharacter.Location = new Point(160, 3);
            btnManageCharacter.Name = "btnManageCharacter";
            btnManageCharacter.Size = new Size(150, 38);
            btnManageCharacter.TabIndex = 1;
            btnManageCharacter.Text = "Manage Character";
            btnManageCharacter.UseVisualStyleBackColor = true;
            btnManageCharacter.Click += BtnManageCharacter_Click;
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.ColumnCount = 1;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Controls.Add(flowLayoutPanelMissions, 0, 0);
            mainLayoutPanel.Controls.Add(panelButtons, 0, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 2;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayoutPanel.Size = new Size(800, 500);
            mainLayoutPanel.TabIndex = 2;
            // 
            // FactionHomeScreen
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(mainLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FactionHomeScreen";
            Text = "Faction Home Screen";
            WindowState = FormWindowState.Maximized;
            panelButtons.ResumeLayout(false);
            mainLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMissions;
        private Panel panelButtons;
        private Button btnReturnToMain;
        private Button btnManageCharacter;
        private TableLayoutPanel mainLayoutPanel;
    }
}
