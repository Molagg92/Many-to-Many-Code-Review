using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Factory.Models;

namespace Factory.Controllers
{
    public class MachineController : Controller
    {
       private readonly FactoryContext _db;
        public MachineController(FactoryContext db)
        {
            _db = db;
        }
    public ActionResult Index()
        {
        List<Machine> model = _db.Machines.ToList();
        return View(model);
        }

    }
}