using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PickEm.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        
        [Display(Name="Home Team")]
        public int? HomeTeamId { get; set; }

        [Display(Name="Away Team")]
        public  int? AwayTeamId { get; set; }

        [Display(Name="Home Score")]
        public int? HomeScore { get; set; }

        [Display(Name="Away Score")]
        public int? AwayScore { get; set; }

        [Display(Name="Home Wins")]
        public bool? Prediction { get; set; }

        public virtual TeamModel HomeTeam { get; set; }
        public virtual TeamModel AwayTeam { get; set; }
    }
}