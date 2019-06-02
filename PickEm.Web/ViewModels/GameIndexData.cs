using System.Collections.Generic;
using PickEm.Models;

namespace PickEm.ViewModels
{
    public class GameIndexData
    {
        public IEnumerable<TeamModel> Teams { get; set; }
        public IEnumerable<GameModel> Games { get; set; }

        public GameModel gameModel { get; set; }

        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }
    }
}