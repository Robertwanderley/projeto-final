﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroElogin.Controllers
{
    public class VagasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}