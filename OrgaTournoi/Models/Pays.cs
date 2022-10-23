using System.Globalization;

namespace OrgaTournoi.Models
{
    public class Pays
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }

        // Reference 1 vers n Joueur
        public ICollection<Joueur> Joueurs { get; set; }

        // Reference 1 vers n Equipe
        public ICollection<Equipe> Equipes { get; set; }

        // Reference 1 vers n Evenement
        public ICollection<Evenement> Evenements { get; set; }
    }
}
