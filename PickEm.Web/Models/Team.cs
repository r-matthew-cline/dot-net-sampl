namespace PickEm.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AvgScore { get; set; }
        public decimal AvgOppScore { get; set; }
        public decimal AvgOffReb { get; set; }
        public decimal AvgDefReb { get; set; }
        public decimal AvgStl { get; set; }
        public decimal AvgBlk { get; set; }
        public int Seed { get; set; }

    }
}