using System;
using System.Collections.Generic;

namespace PVRL.Functions
{
    public class SkillTreeGenerator
    {
        private Random random;

        public SkillTreeGenerator(int seed)
        {
            random = new Random(seed);
        }

        public SkillTree GenerateSkillTree()
        {
            SkillTree skillTree = new SkillTree();

            // Generate skills for each branch
            GenerateBranchSkills(skillTree, "Offense", character => character.Strength += 1, 5);
            GenerateBranchSkills(skillTree, "Defense", character => character.Dexterity += 1, 5);
            GenerateBranchSkills(skillTree, "Support", character => character.Intelligence += 1, 5);

            return skillTree;
        }

        private void GenerateBranchSkills(SkillTree skillTree, string branch, Action<Character> effect, int skillCount)
        {
            SkillNode previousSkill = null;
            for (int i = 1; i <= skillCount; i++)
            {
                string statChange = branch switch
                {
                    "Offense" => $"Strength +{i}",
                    "Defense" => $"Dexterity +{i}",
                    "Support" => $"Intelligence +{i}",
                    _ => ""
                };

                string skillName = $"{branch}_{i} ({statChange})";
                string description = $"Increases {branch.ToLower()} by {i}.";

                SkillNode skillNode = new SkillNode(skillName, description, i, branch, branch, i, effect);

                skillTree.AddNode(skillNode);
                if (previousSkill != null)
                {
                    skillTree.AddPrerequisite(skillNode, previousSkill);
                }
                previousSkill = skillNode;
            }
        }
    }
}
