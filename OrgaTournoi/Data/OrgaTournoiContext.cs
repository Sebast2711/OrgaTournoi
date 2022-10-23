using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrgaTournoi.Models;

namespace OrgaTournoi.Data
{
    public class OrgaTournoiContext : DbContext
    {
        public OrgaTournoiContext (DbContextOptions<OrgaTournoiContext> options)
            : base(options)
        {
        }

        public DbSet<OrgaTournoi.Models.Classement> Classement { get; set; } = default!;

        public DbSet<OrgaTournoi.Models.Equipe> Equipe { get; set; }

        public DbSet<OrgaTournoi.Models.Evenement> Evenement { get; set; }

        public DbSet<OrgaTournoi.Models.Fabricant> Fabricant { get; set; }

        public DbSet<OrgaTournoi.Models.Jeu> Jeu { get; set; }

        public DbSet<OrgaTournoi.Models.Joueur> Joueur { get; set; }

        public DbSet<OrgaTournoi.Models.Match> Match { get; set; }

        public DbSet<OrgaTournoi.Models.Pays> Pays { get; set; }

        public DbSet<OrgaTournoi.Models.Personnage> Personnage { get; set; }
    }
}
