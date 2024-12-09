public class Cours
{
    public int CoursID { get; set; }
    public string Libelle { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public int NombreHeures { get; set; }
    public string Semestre { get; set; }

    
    public ICollection<Absence> Absences { get; set; }
}

