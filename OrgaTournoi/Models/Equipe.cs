namespace OrgaTournoi.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public string? Description { get; set; }
        public string CashpriceTotal { get; set; }
        public Pays pays { get; set; }
    }
}
