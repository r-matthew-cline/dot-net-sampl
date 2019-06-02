using System.ComponentModel.DataAnnotations;

namespace PickEm.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        [Display(Name="Team Id")]
        public int TeamId { get; set; }
        public string Name { get; set; }

        [Display(Name="Score Per Game")]
        public decimal AvgScore { get; set; }

        [Display(Name="Opponent Score Per Game")]
        public decimal AvgOppScore { get; set; }

        [Display(Name="Offensive Rebounds Per Game")]
        public decimal AvgOffReb { get; set; }

        [Display(Name="Defensive Rebounds Per Game")]
        public decimal AvgDefReb { get; set; }

        [Display(Name="Steals Per Game")]
        public decimal AvgStl { get; set; }

        [Display(Name="Blocks Per Game")]
        public decimal AvgBlk { get; set; }
        public int Seed { get; set; }

    }
}