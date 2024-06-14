namespace PVRL
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button characterCreationButton;
        private Button manageCharacterButton;
        private Button pveButton;
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
            pveButton = new Button();
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
            characterCreationButton.Location = new Point(12, 12);
            characterCreationButton.Name = "characterCreationButton";
            characterCreationButton.Size = new Size(150, 54);
            characterCreationButton.TabIndex = 0;
            characterCreationButton.Text = "Create Character";
            characterCreationButton.UseVisualStyleBackColor = true;
            characterCreationButton.Click += CharacterCreationButton_Click;
            // 
            // manageCharacterButton
            // 
            manageCharacterButton.Location = new Point(12, 72);
            manageCharacterButton.Name = "manageCharacterButton";
            manageCharacterButton.Size = new Size(150, 54);
            manageCharacterButton.TabIndex = 1;
            manageCharacterButton.Text = "Manage Character";
            manageCharacterButton.UseVisualStyleBackColor = true;
            manageCharacterButton.Click += ManageCharacterButton_Click;
            // 
            // pveButton
            // 
            pveButton.Location = new Point(12, 132);
            pveButton.Name = "pveButton";
            pveButton.Size = new Size(150, 54);
            pveButton.TabIndex = 2;
            pveButton.Text = "PvE";
            pveButton.UseVisualStyleBackColor = true;
            pveButton.Click += PveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 192);
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
            label1.Location = new Point(12, 260);
            label1.Name = "label1";
            label1.Size = new Size(760, 54);
            label1.TabIndex = 4;
            label1.Text = "PVRL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(homeTabPage);
            mainTabControl.Controls.Add(manageCharacterTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 600);
            mainTabControl.TabIndex = 5;
            // 
            // homeTabPage
            // 
            homeTabPage.BackColor = Color.Transparent;
            homeTabPage.BackgroundImage = (Image)resources.GetObject("homeTabPage.BackgroundImage");
            homeTabPage.BackgroundImageLayout = ImageLayout.Stretch;
            homeTabPage.Controls.Add(characterCreationButton);
            homeTabPage.Controls.Add(manageCharacterButton);
            homeTabPage.Controls.Add(pveButton);
            homeTabPage.Controls.Add(exitButton);
            homeTabPage.Controls.Add(label1);
            homeTabPage.Location = new Point(4, 25);
            homeTabPage.Name = "homeTabPage";
            homeTabPage.Padding = new Padding(3);
            homeTabPage.Size = new Size(792, 571);
            homeTabPage.TabIndex = 0;
            homeTabPage.Text = "Home";
            // 
            // manageCharacterTabPage
            // 
            manageCharacterTabPage.BackColor = Color.Transparent;
            manageCharacterTabPage.Controls.Add(manageCharacterControl);
            manageCharacterTabPage.Location = new Point(4, 25);
            manageCharacterTabPage.Name = "manageCharacterTabPage";
            manageCharacterTabPage.Padding = new Padding(3);
            manageCharacterTabPage.Size = new Size(792, 571);
            manageCharacterTabPage.TabIndex = 1;
            manageCharacterTabPage.Text = "Manage Character";
            // 
            // manageCharacterControl
            // 
            manageCharacterControl.BackColor = Color.Transparent;
            manageCharacterControl.Dock = DockStyle.Fill;
            manageCharacterControl.Location = new Point(3, 3);
            manageCharacterControl.Margin = new Padding(4, 3, 4, 3);
            manageCharacterControl.Name = "manageCharacterControl";
            manageCharacterControl.Size = new Size(786, 565);
            manageCharacterControl.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(mainTabControl);
            Name = "MainForm";
            Text = "PVRL";
            mainTabControl.ResumeLayout(false);
            homeTabPage.ResumeLayout(false);
            manageCharacterTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
