using System;
using System.Collections.Generic;

namespace PVRL.Functions
{
    public class SkillNode
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public string Branch { get; set; }
        public bool IsUnlocked { get; set; }
        public string StatName { get; set; }
        public int StatBonus { get; set; }
        public Action<Character> Effect { get; set; }
        public List<SkillNode> Prerequisites { get; private set; }

        public SkillNode(string name, string description, int cost, string branch, string statName, int statBonus, Action<Character> effect)
        {
            Name = name;
            Description = description;
            Cost = cost;
            Branch = branch;
            StatName = statName;
            StatBonus = statBonus;
            Effect = effect;
            Prerequisites = new List<SkillNode>();
            IsUnlocked = false;
        }

        public void Unlock(Character character)
        {
            Effect?.Invoke(character);
            IsUnlocked = true;
        }
    }
}
