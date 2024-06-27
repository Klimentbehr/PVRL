using PVRL.Functions;
using System;
using System.Collections.Generic;

namespace PVRL
{
    public class Mission
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public string Type { get; set; }
        public TimeSpan Duration { get; set; }
        public int CreditsReward { get; set; }
        public int SkillPointsReward { get; set; }

        public static List<Mission> GenerateMissions()
        {
            return new List<Mission>
            {
                new Mission
                {
                    Name = "Easy Bunker Raid",
                    Description = "An easy bunker raid mission. Rewards: 100 Credits, 1 Skill Point",
                    Difficulty = DifficultyLevel.Easy,
                    Type = "Bunker Raid",
                    Duration = TimeSpan.FromMinutes(30),
                    CreditsReward = 100,
                    SkillPointsReward = 1
                },
                new Mission
                {
                    Name = "Normal Bunker Raid",
                    Description = "A normal bunker raid mission. Rewards: 200 Credits, 2 Skill Points",
                    Difficulty = DifficultyLevel.Normal,
                    Type = "Bunker Raid",
                    Duration = TimeSpan.FromMinutes(45),
                    CreditsReward = 200,
                    SkillPointsReward = 2
                },
                new Mission
                {
                    Name = "Hard Bunker Raid",
                    Description = "A hard bunker raid mission. Rewards: 300 Credits, 3 Skill Points",
                    Difficulty = DifficultyLevel.Hard,
                    Type = "Bunker Raid",
                    Duration = TimeSpan.FromMinutes(60),
                    CreditsReward = 300,
                    SkillPointsReward = 3
                },
                new Mission
                {
                    Name = "Boss Slaughter Bunker Raid",
                    Description = "A boss slaughter bunker raid mission. Rewards: 500 Credits, 5 Skill Points",
                    Difficulty = DifficultyLevel.BossSlaughter,
                    Type = "Bunker Raid",
                    Duration = TimeSpan.FromMinutes(90),
                    CreditsReward = 500,
                    SkillPointsReward = 5
                }
            };
        }
    }
}
