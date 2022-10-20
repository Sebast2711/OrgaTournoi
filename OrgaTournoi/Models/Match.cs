namespace OrgaTournoi.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Evenement Evenement { get; set; }
        public string LienStreaming { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Score { get; set; }

    }
}
