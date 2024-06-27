using System.Collections.Generic;

namespace PVRL.Functions
{
    public class SkillTree
    {
        public List<SkillNode> Nodes { get; private set; }

        public SkillTree()
        {
            Nodes = new List<SkillNode>();
        }

        public void AddNode(SkillNode node)
        {
            Nodes.Add(node);
        }

        public void AddPrerequisite(SkillNode node, SkillNode prerequisite)
        {
            node.Prerequisites.Add(prerequisite);
        }

        public bool CanUnlock(SkillNode node)
        {
            foreach (var prerequisite in node.Prerequisites)
            {
                if (!prerequisite.IsUnlocked)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
