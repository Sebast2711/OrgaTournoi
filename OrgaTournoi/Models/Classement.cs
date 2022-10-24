using System.ComponentModel.DataAnnotations.Schema;

namespace OrgaTournoi.Models
{
    public class Classement
    {
        [ForeignKey("Evenement")]
        public int Id { get; set; }

        // Reference n vers n Equipe
        public ICollection<Equipe> Equipes { get; set; }



        public Classement()
        {
            Equipes = new HashSet<Equipe>();
        }
    }
}
