using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PVRL.Functions;

namespace PVRL
{
    public partial class SkillForm : Form
    {
        private List<Character> characters;
        private Character character;
        private SkillTree skillTree;

        public SkillForm(List<Character> characters, Character character)
        {
            InitializeComponent();
            this.characters = characters;
            this.character = character;
            PopulateCharacterComboBox();
            InitializeSkillTree();
        }

        private void PopulateCharacterComboBox()
        {
            characterComboBox.Items.Clear();
            foreach (var charItem in characters)
            {
                characterComboBox.Items.Add(charItem.Name);
            }
            if (characters.Count > 0)
            {
                characterComboBox.SelectedItem = character.Name;
            }
        }

        private void InitializeSkillTree()
        {
            SkillTreeGenerator generator = new SkillTreeGenerator(character.SkillSeed);
            skillTree = generator.GenerateSkillTree();
            DisplayInitialSkills();
            UpdateSkillPointsLabel();
        }

        private void DisplayInitialSkills()
        {
            offenseTabPage.Controls.Clear();
            defenseTabPage.Controls.Clear();
            supportTabPage.Controls.Clear();

            DisplaySkills(offenseTabPage, "Offense");
            DisplaySkills(defenseTabPage, "Defense");
            DisplaySkills(supportTabPage, "Support");
        }

        private void DisplaySkills(CustomTabPage tabPage, string branch)
        {
            int yOffset = 10;
            var branchSkills = skillTree.Nodes.Where(node => node.Branch == branch && !character.UnlockedSkills.Contains(node.Name)).Take(5).ToList();

            foreach (var node in branchSkills)
            {
                Button skillButton = new Button
                {
                    Text = $"{node.Name} (Cost: {node.Cost})",
                    Tag = node,
                    Location = new Point(10, yOffset),
                    Width = 500,
                    Height = 70,
                    Font = new Font("Segoe UI", 14)
                };
                skillButton.Click += SkillButton_Click;

                tabPage.Controls.Add(skillButton);
                yOffset += 80;
            }
        }

        private void SkillButton_Click(object sender, EventArgs e)
        {
            Button skillButton = sender as Button;
            SkillNode skillNode = skillButton.Tag as SkillNode;

            if (skillTree.CanUnlock(skillNode) && character.SkillPoints >= skillNode.Cost)
            {
                skillNode.Unlock(character);
                character.SkillPoints -= skillNode.Cost;
                character.UnlockedSkills.Add(skillNode.Name);
                skillButton.Enabled = false;
                MessageBox.Show($"{skillNode.Name} unlocked!");
                UpdateSkillPointsLabel();
                CheckAndAddNextSkill(skillNode.Branch);
                SaveCharacter(); // Save character after unlocking skill
            }
            else
            {
                MessageBox.Show($"Cannot unlock {skillNode.Name}. Make sure all prerequisites are met and you have enough skill points.");
            }
        }

        private void CheckAndAddNextSkill(string branch)
        {
            var branchSkills = skillTree.Nodes.Where(node => node.Branch == branch && !node.IsUnlocked && !character.UnlockedSkills.Contains(node.Name)).ToList();
            if (branchSkills.Count == 0) return;

            var unlockedSkills = skillTree.Nodes.Where(node => node.Branch == branch && node.IsUnlocked).Count();
            if (unlockedSkills >= 5 && unlockedSkills < branchSkills.Count)
            {
                var nextSkill = branchSkills[unlockedSkills - 5];
                AddNextSkillButton(nextSkill);
            }
        }

        private void AddNextSkillButton(SkillNode skillNode)
        {
            Button skillButton = new Button
            {
                Text = $"{skillNode.Name} (Cost: {skillNode.Cost})",
                Tag = skillNode,
                Location = new Point(10, 10 + 80 * (skillNode.Cost - 1)),
                Width = 500,
                Height = 70,
                Font = new Font("Segoe UI", 14)
            };
            skillButton.Click += SkillButton_Click;

            if (skillNode.Branch == "Offense")
                offenseTabPage.Controls.Add(skillButton);
            else if (skillNode.Branch == "Defense")
                defenseTabPage.Controls.Add(skillButton);
            else if (skillNode.Branch == "Support")
                supportTabPage.Controls.Add(skillButton);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSkillPointsLabel()
        {
            skillPointsLabel.Text = $"Skill Points: {character.SkillPoints}";
            UpdateCharacterInfoLabel();
        }

        private void UpdateCharacterInfoLabel()
        {
            characterInfoLabel.Text = $"Character Info:\n" +
                                      $"Name: {character.Name}\n" +
                                      $"Race: {character.Race}\n" +
                                      $"Age: {character.Age}\n" +
                                      $"Strength: {character.Strength}\n" +
                                      $"Dexterity: {character.Dexterity}\n" +
                                      $"Intelligence: {character.Intelligence}\n" +
                                      $"Wisdom: {character.Wisdom}\n" +
                                      $"Charisma: {character.Charisma}\n" +
                                      $"Skill Points: {character.SkillPoints}\n" +
                                      $"Health: {character.Health}\n" +
                                      $"Defense: {character.Defense}\n";
        }

        private void CharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCharacterName = characterComboBox.SelectedItem.ToString();
            character = characters.FirstOrDefault(c => c.Name == selectedCharacterName);
            InitializeSkillTree();
        }

        private void SaveCharacter()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Characters", $"{character.Name}.txt");
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, Newtonsoft.Json.JsonConvert.SerializeObject(character));
        }
    }
}
