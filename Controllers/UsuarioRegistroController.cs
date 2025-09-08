using Microsoft.AspNetCore.Mvc;
using smart_stock.Dto;
using smart_stock.Interfaces;
using smart_stock.Models;
using System.Linq;

namespace smart_stock.Controllers
{
    public class UsuarioRegistroController : ControllerBase
    {
        private readonly IUsuarioRegistroService _usuarioRegistroService;

    }
}
