using Microsoft.AspNetCore.Mvc;
using UserRegister.Models;

namespace UserRegister.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Salvar([FromBody] User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.CPF))
            {
                return BadRequest("Nome e CPF são obrigatórios.");
            }

            string code = user.CPF.Substring(0, 4);
            return Ok($"Pessoa cadastrada com sucesso, código: {code}");
        }
    }
}
