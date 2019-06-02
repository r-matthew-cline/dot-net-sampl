using System;
using System.Collections.Generic;

namespace PickEm.Models
{
    public class BracketModel
    {
        public int Id { get; set; }

        public virtual ICollection<GameModel> Games { get; set; }

        public int CorrectPicks { get; set; }

    }
}