public class Professeur
{
    public int ProfesseurID { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Specialite { get; set; }
    public string Grade { get; set; }

    // Relation avec Cours
    public ICollection<Cours> Cours { get; set; }
}
