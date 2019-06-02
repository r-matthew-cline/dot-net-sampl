using System.Collections.Generic;
using PickEm.Models;

namespace PickEm.ViewModels
{
    public class GameCreateViewModel    {
        public IEnumerable<TeamModel> Teams { get; set; }
        public IEnumerable<GameModel> Games { get; set; }
        public GameModel gameModel { get; set; }
    }
}