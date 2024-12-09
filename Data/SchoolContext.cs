using Microsoft.EntityFrameworkCore;

namespace GestionEcole.Models
{
    public class SchoolContext : DbContext
    {
        // Constructeur de SchoolContext avec injection des options de contexte
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        // Déclaration des DbSet pour chaque entité
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }
        
        // Ajoute d'autres DbSet pour d'autres entités si nécessaire
    }
}
