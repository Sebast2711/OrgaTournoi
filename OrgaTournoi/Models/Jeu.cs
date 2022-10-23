namespace OrgaTournoi.Models
{
    public class Jeu
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateSortie { get; set; }
        public string Image { get; set; }
        public string? Description { get; set; }

        // Reference 1 vers n Evenement
        public ICollection<Jeu> Jeux { get; set; }

        // Reference n vers n Fabricant
        public ICollection<Fabricant> Fabricants { get; set; }

        // Reference n vers n Personnage
        public ICollection<Personnage> Personnages { get; set; }
    }
}
