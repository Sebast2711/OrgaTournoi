using System.Globalization;

namespace OrgaTournoi.Models
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public Pays pays { get; set; }
        public string? Description { get; set; }
        public string CashprizeTotal { get; set; }
        public int Age { get; set; }

    }
}
