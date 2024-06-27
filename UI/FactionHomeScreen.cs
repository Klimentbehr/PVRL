using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PVRL
{
    public partial class FactionHomeScreen : Form
    {
        private Character player;
        private Vault vault;
        private List<Mission> missions;

        public FactionHomeScreen(Character player, Vault vault)
        {
            this.player = player;
            this.vault = vault;
            InitializeComponent();
            LoadMissions();
            DisplayMissions();
        }

        private void LoadMissions()
        {
            missions = Mission.GenerateMissions();
        }

        private void DisplayMissions()
        {
            foreach (var mission in missions)
            {
                var missionGroupBox = new GroupBox
                {
                    Text = mission.Name,
                    AutoSize = true,
                    Margin = new Padding(10)
                };

                var missionDescription = new Label
                {
                    Text = mission.Description,
                    AutoSize = true,
                    Location = new Point(10, 20)
                };

                var missionButton = new Button
                {
                    Text = "Start Mission",
                    Tag = mission,
                    AutoSize = true,
                    Location = new Point(10, 50)
                };
                missionButton.Click += MissionButton_Click;

                var missionTimerLabel = new Label
                {
                    Text = "Time remaining: ",
                    AutoSize = true,
                    Location = new Point(10, 80)
                };

                missionGroupBox.Controls.Add(missionDescription);
                missionGroupBox.Controls.Add(missionButton);
                missionGroupBox.Controls.Add(missionTimerLabel);
                flowLayoutPanelMissions.Controls.Add(missionGroupBox);

                var missionTimer = new System.Windows.Forms.Timer { Interval = 1000 };
                missionTimer.Tick += (s, e) =>
                {
                    mission.Duration -= TimeSpan.FromSeconds(1);
                    missionTimerLabel.Text = $"Time remaining: {mission.Duration.ToString(@"hh\:mm\:ss")}";
                    if (mission.Duration <= TimeSpan.Zero)
                    {
                        missionTimer.Stop();
                        missionButton.Enabled = false;
                        missionTimerLabel.Text = "Mission expired.";
                    }
                };
                missionTimer.Start();
            }
        }

        private void MissionButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var mission = button.Tag as Mission;

            var result = MessageBox.Show($"Do you want to start the mission '{mission.Name}'?\n\n{mission.Description}", "Start Mission", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var combatForm = new CombatForm(player, mission.Difficulty, vault);
                combatForm.ShowDialog();
            }
        }

        private void BtnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnManageCharacter_Click(object sender, EventArgs e)
        {
            var manageCharacterForm = new Form
            {
                Text = "Manage Character",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterParent
            };

            var manageCharacterControl = new ManageCharacterControl();
            manageCharacterControl.SetCharacterAndVault(player, vault);
            manageCharacterControl.Dock = DockStyle.Fill;
            manageCharacterForm.Controls.Add(manageCharacterControl);

            manageCharacterForm.ShowDialog();
        }
    }
}
