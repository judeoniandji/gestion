public class EtudiantController : Controller
{
    private readonly SchoolContext _context;

    public EtudiantController(SchoolContext context)
    {
        _context = context;
    }

    // Afficher la liste des étudiants
    public IActionResult Index()
    {
        var etudiants = _context.Etudiants.ToList();
        return View(etudiants);
    }

    // Afficher les absences d'un étudiant
    public IActionResult Absences(int id)
    {
        var etudiant = _context.Etudiants.Include(e => e.Absences)
                                        .ThenInclude(a => a.Cours)
                                        .FirstOrDefault(e => e.EtudiantID == id);
        return View(etudiant);
    }
}
