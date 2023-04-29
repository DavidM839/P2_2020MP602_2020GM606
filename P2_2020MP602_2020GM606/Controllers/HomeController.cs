using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020MP602_2020GM606.Models;
using System.Diagnostics;

namespace P2_2020MP602_2020GM606.Controllers
{
    public class HomeController : Controller
    {
        private readonly BDcovContext _db;

        public HomeController(BDcovContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewData["generos"] = new SelectList(listarGeneros(), "id_genero", "genero");
            ViewData["departamentos"] = new SelectList(listarDepartamentos(), "id_departamento", "Nombre_dep");
            ViewData["casosReportados"] = listarCasos();

            return View();
        }
        public IActionResult CrearRegistro(CasosReportados casoAgregar)
        {
            _db.casosReportados.Add(casoAgregar);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // UTILS 
        public List<Generos> listarGeneros()
        {
            var listaGeneros = (from g in _db.Generos select g).ToList();

            return listaGeneros;
        }

        public List<Departamentos> listarDepartamentos()
        {
            var listaDepartamentos = (from d in _db.Departamentos select d).ToList();

            return listaDepartamentos;
        }

        public List<object> listarCasos()
        {
            var listadoCasos = (from casos in _db.casosReportados
                                join depa in _db.Departamentos on casos.departamento_id equals depa.id_departamento                                join genero in _db.Generos on casos.genero_id equals genero.id_genero
                                select new
                                {
                                    departamento = depa.Nombre_dep,
                                    genero = genero.genero,
                                    confirmados = casos.confirmados,
                                    recuperados = casos.recuperados,
                                    fallecidos = casos.fallecidos
                                }).ToList<object>();

            return listadoCasos;
        }
    }
}