public class AbsenceController : Controller
{
    private readonly SchoolContext _context;

    public AbsenceController(SchoolContext context)
    {
        _context = context;
    }

    // Afficher les absences d'un étudiant
    public IActionResult Index(int id)
    {
        var absences = _context.Absences.Include(a => a.Etudiant)
                                        .Include(a => a.Cours)
                                        .Where(a => a.EtudiantID == id)
                                        .ToList();
        return View(absences);
    }
}
