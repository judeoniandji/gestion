using Microsoft.EntityFrameworkCore;

namespace GestionEcole.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }
        // Ajoute d'autres DbSet ici
    }
}
