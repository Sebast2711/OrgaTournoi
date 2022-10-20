namespace OrgaTournoi.Models
{
    public class Evenement
    {
        public int Id { get; set; }
        public Jeu jeu { get; set; }
        public Classement classement { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public string Lieu { get; set; }
        public Pays pays { get; set; }
        public DateTime DateDebut {get; set; }
        public DateTime DateFin {get; set; }
        public string Cashprize { get; set; }
    }
}
