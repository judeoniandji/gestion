public class Absence
{
    public int AbsenceID { get; set; }
    public DateTime DateAbsence { get; set; }
    public int EtudiantID { get; set; }
    public Etudiant Etudiant { get; set; }
    public int CoursID { get; set; }
    public Cours Cours { get; set; }
}
