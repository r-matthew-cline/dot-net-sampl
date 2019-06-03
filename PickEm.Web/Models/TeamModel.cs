using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PickEm.Models
{
    public class TeamModel
    {
        [Key]
        [Display(Name="Team Id")]
        public int TeamId { get; set; }
        public string Name { get; set; }

        [Display(Name="Points")]
        public decimal AvgScore { get; set; }

        [Display(Name="Points Allowed")]
        public decimal AvgOppScore { get; set; }

        [Display(Name="Offensive Rebounds")]
        public decimal AvgOffReb { get; set; }

        [Display(Name="Defensive Rebounds")]
        public decimal AvgDefReb { get; set; }

        [Display(Name="Steals")]
        public decimal AvgStl { get; set; }

        [Display(Name="Blocks")]
        [DisplayFormat(DataFormatString = "{0:000:#}", ApplyFormatInEditMode = true)]
        public decimal AvgBlk { get; set; }
        [Display(Name="Assists")]
        public decimal AvgAst { get; set; }
        public int Seed { get; set; }

        public virtual List<GameModel> HomeGames { get; set; }
        public virtual List<GameModel> AwayGames { get; set; }
    }
}