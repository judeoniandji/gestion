public class Classe
{
    public int ClasseID { get; set; }
    public string Libelle { get; set; }
    public string Filiere { get; set; }

    // Relation avec Cours
    public ICollection<ClasseCours> ClasseCours { get; set; }
}
