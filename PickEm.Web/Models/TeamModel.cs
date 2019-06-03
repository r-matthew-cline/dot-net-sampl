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

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Points")]
        public decimal? AvgScore { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Points Allowed")]
        public decimal? AvgOppScore { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Offensive Rebounds")]
        public decimal? AvgOffReb { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Defensive Rebounds")]
        public decimal? AvgDefReb { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Steals")]
        public decimal? AvgStl { get; set; }

        [Display(Name="Blocks")]
        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        public decimal? AvgBlk { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Display(Name="Assists")]
        public decimal? AvgAst { get; set; }
        public int Seed { get; set; }

        public virtual List<GameModel> HomeGames { get; set; }
        public virtual List<GameModel> AwayGames { get; set; }
    }
}