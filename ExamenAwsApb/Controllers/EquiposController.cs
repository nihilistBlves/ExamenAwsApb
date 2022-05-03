using ExamenAwsApb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenAwsApb.Controllers {
    public class EquiposController : Controller {
        private ApplicationRepository repo;
        public EquiposController(ApplicationRepository repo) {
            this.repo = repo;
        }
        public IActionResult Index() {
            return View(this.repo.GetEquipos());
        }
    }
}
