using Microsoft.AspNetCore.Mvc;
using SoulMV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulMV.Controllers
{
    public class EstoquesController : Controller
    {
        public IActionResult Index()
        {
            List<Estoque> list = new List<Estoque>();
            list.Add(new Estoque { Codigo = 1, Nome = "Almox Central" });
            list.Add(new Estoque { Codigo = 2, Nome = "Almox Medicamento" });


            return View(list);
        }
    }
}
