namespace OrgaTournoi.Models
{
    public class Jeu
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateSortie { get; set; }
        public string Image { get; set; }
        public string? Description { get; set; }
        public Classement classement { get; set; }
    }
}
