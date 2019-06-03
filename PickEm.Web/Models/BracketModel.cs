using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickEm.Models
{
    public class BracketModel
    {
        public int Id { get; set; }
        
        public virtual List<GameModel> Games { get; set; }

        public int CorrectPicks { get; set; }

    }
}