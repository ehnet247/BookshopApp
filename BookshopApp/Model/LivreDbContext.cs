using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Model
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
                        Ean = 9782359103144,
                        Titre = "City Hall, Tome 2",
                        Auteurs = "Guillaume Lapeyre, Rémi Guérin",
                        Fournisseur = "",
                        Stock = 1,
                        Editeur = "",
                        Categorie = "Manga",
                        DatePublication = new DateTime(2012, 09, 27),
                        Disponibilite = "Disponible",
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
                        Ean = 9782809714470,
                        Titre = "Un sandwich à Ginza",
                        Auteurs = "Yôko Hiramatsu, Jirô Taniguchi",
                        Fournisseur = "",
                        Stock = 1,
                        Editeur = "Piquier",
                        Categorie = "Essai, chronique culinaire",
                        DatePublication = new DateTime(2021, 10, 03),
                        Disponibilite = "Disponible",
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
