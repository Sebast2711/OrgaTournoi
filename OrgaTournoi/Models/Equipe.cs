﻿namespace OrgaTournoi.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Image { get; set; }
        public string? Description { get; set; }
        public string CashpriceTotal { get; set; }

        // Reference au pays
        public int PaysId { get; set; }
        public Pays Pays { get; set; }
    
        // Reference n vers n Joueur
        public ICollection<Joueur> Joueurs { get; set; }

        // Reference n vers n Match
        public ICollection<Match> Matchs { get; set; }

        // Reference n vers n Classement
        public ICollection<Classement> Classements { get; set; }
    }
}
