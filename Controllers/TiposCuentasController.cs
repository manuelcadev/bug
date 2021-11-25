using BudgetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers;

public class TiposCuentasController: Controller
{
    public TiposCuentasController()
    {
        
    }
    
    public IActionResult Crear()
    {
        var tipoCuenta = new TipoCuenta(){Nombre = "something"};
        return View(tipoCuenta);
    }


    [HttpPost]
    public IActionResult Crear(TipoCuenta tipoCuenta)
    {
        if(!ModelState.IsValid)
        {
            return View(tipoCuenta);
        }

        return RedirectToAction("Crear");
    }
}