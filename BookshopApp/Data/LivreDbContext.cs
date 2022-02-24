using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Data
{
    public class LivreDbContext : DbContext
    {
        public LivreDbContext(DbContextOptions<LivreDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Livre> Livres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre>().HasData(GetLivres());
            base.OnModelCreating(modelBuilder);
        }

        private Livre[] GetLivres()
        {
            return new Livre[]
                {
                    new Livre
                    {
                        Ean = 1,
                        Titre = "",
                        Auteurs = "",
                        Fournisseur = "",
                        Stock = 1,
                        Editeur = "",
                        Categorie = "",
                        DatePublication = new DateTime(2022, 01, 01),
                        Disponibilite = "",
                        Poids = 76,
                        PrixVente = 0,
                        PrixNeuf = 0,
                        TvaTaux = 5.5f,
                        TvaMontant = 0,
                        Occasion = true,
                        CollEditoriale = "",
                        CoupDeCoeur = false,
                        AvisLibraire = ""
                    },
                    new Livre
                    {
                        Ean = 2,
                        Titre = "",
                        Auteurs = "",
                        Fournisseur = "",
                        Stock = 1,
                        Editeur = "",
                        Categorie = "",
                        DatePublication = new DateTime(2022, 01, 01),
                        Disponibilite = "",
                        Poids = 80,
                        PrixVente = 0,
                        PrixNeuf = 0,
                        TvaTaux = 5.5f,
                        TvaMontant = 0,
                        Occasion = true,
                        CollEditoriale = "",
                        CoupDeCoeur = false,
                        AvisLibraire = ""
                    }
                };
                }
    }
}
