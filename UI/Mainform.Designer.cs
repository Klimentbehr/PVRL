namespace PVRL
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button characterCreationButton;
        private Button manageCharacterButton;
        private Button playButton; // Changed from pveButton to playButton
        private Button exitButton;
        private Label label1;
        private CustomTabControl mainTabControl;
        private TabPage homeTabPage;
        private TabPage manageCharacterTabPage;
        private ManageCharacterControl manageCharacterControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            characterCreationButton = new Button();
            manageCharacterButton = new Button();
            playButton = new Button(); // Changed from pveButton to playButton
            exitButton = new Button();
            label1 = new Label();
            mainTabControl = new CustomTabControl();
            homeTabPage = new TabPage();
            manageCharacterTabPage = new TabPage();
            manageCharacterControl = new ManageCharacterControl();
            mainTabControl.SuspendLayout();
            homeTabPage.SuspendLayout();
            manageCharacterTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // characterCreationButton
            // 
            characterCreationButton.Location = new Point(480, 132);
            characterCreationButton.Name = "characterCreationButton";
            characterCreationButton.Size = new Size(150, 54);
            characterCreationButton.TabIndex = 0;
            characterCreationButton.Text = "Create Character";
            characterCreationButton.UseVisualStyleBackColor = true;
            characterCreationButton.Click += CharacterCreationButton_Click;
            // 
            // manageCharacterButton
            // 
            manageCharacterButton.Location = new Point(324, 132);
            manageCharacterButton.Name = "manageCharacterButton";
            manageCharacterButton.Size = new Size(150, 54);
            manageCharacterButton.TabIndex = 1;
            manageCharacterButton.Text = "Manage Character";
            manageCharacterButton.UseVisualStyleBackColor = true;
            manageCharacterButton.Click += ManageCharacterButton_Click;
            // 
            // playButton
            // 
            playButton.Location = new Point(12, 132);
            playButton.Name = "playButton";
            playButton.Size = new Size(150, 54);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += PlayButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(168, 132);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 54);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 12);
            label1.Name = "label1";
            label1.Size = new Size(443, 145);
            label1.TabIndex = 4;
            label1.Text = "PVRL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainTabControl
            // 
            mainTabControl.Alignment = TabAlignment.Bottom;
            mainTabControl.Controls.Add(homeTabPage);
            mainTabControl.Controls.Add(manageCharacterTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            mainTabControl.ItemSize = new Size(100, 30);
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 600);
            mainTabControl.SizeMode = TabSizeMode.Fixed;
            mainTabControl.TabIndex = 5;
            mainTabControl.SelectedIndexChanged += mainTabControl_SelectedIndexChanged;
            // 
            // homeTabPage
            // 
            homeTabPage.BackColor = Color.Transparent;
            homeTabPage.BackgroundImage = (Image)resources.GetObject("homeTabPage.BackgroundImage");
            homeTabPage.Controls.Add(characterCreationButton);
            homeTabPage.Controls.Add(manageCharacterButton);
            homeTabPage.Controls.Add(playButton); // Changed from pveButton to playButton
            homeTabPage.Controls.Add(exitButton);
            homeTabPage.Controls.Add(label1);
            homeTabPage.Location = new Point(4, 4);
            homeTabPage.Name = "homeTabPage";
            homeTabPage.Padding = new Padding(3);
            homeTabPage.Size = new Size(792, 562);
            homeTabPage.TabIndex = 0;
            homeTabPage.Text = "Home";
            homeTabPage.Click += homeTabPage_Click;
            // 
            // manageCharacterTabPage
            // 
            manageCharacterTabPage.BackColor = Color.Transparent;
            manageCharacterTabPage.Controls.Add(manageCharacterControl);
            manageCharacterTabPage.Location = new Point(4, 4);
            manageCharacterTabPage.Name = "manageCharacterTabPage";
            manageCharacterTabPage.Padding = new Padding(3);
            manageCharacterTabPage.Size = new Size(792, 562);
            manageCharacterTabPage.TabIndex = 1;
            manageCharacterTabPage.Text = "Manage Character";
            // 
            // manageCharacterControl
            // 
            manageCharacterControl.BackgroundImage = (Image)resources.GetObject("manageCharacterControl.BackgroundImage");
            manageCharacterControl.BackgroundImageLayout = ImageLayout.Stretch;
            manageCharacterControl.Dock = DockStyle.Fill;
            manageCharacterControl.Location = new Point(3, 3);
            manageCharacterControl.Margin = new Padding(4, 3, 4, 3);
            manageCharacterControl.Name = "manageCharacterControl";
            manageCharacterControl.Size = new Size(786, 556);
            manageCharacterControl.TabIndex = 0;
            manageCharacterControl.InventoryButtonClicked += ManageCharacterControl_InventoryButtonClicked;
            manageCharacterControl.SkillsButtonClicked += ManageCharacterControl_SkillsButtonClicked;
            manageCharacterControl.CraftingButtonClicked += ManageCharacterControl_CraftingButtonClicked;
            manageCharacterControl.StoreButtonClicked += ManageCharacterControl_StoreButtonClicked;
            // 
            // MainForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(mainTabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "PVRL";
            WindowState = FormWindowState.Maximized;
            Resize += MainForm_Resize;
            mainTabControl.ResumeLayout(false);
            homeTabPage.ResumeLayout(false);
            manageCharacterTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
