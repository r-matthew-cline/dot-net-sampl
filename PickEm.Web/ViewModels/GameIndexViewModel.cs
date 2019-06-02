using System.Collections.Generic;
using PickEm.Models;

namespace PickEm.ViewModels
{
    public class GameIndexViewModel    {
        public IEnumerable<TeamModel> Teams { get; set; }
        public IEnumerable<GameModel> Games { get; set; }
    }
}