using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace TrabSenac
{
    public class dados_pessoaisModel : PageModel
    {
        private List<Usuario> Usuarios { get; set; }
        public Usuario Usuario { get; set; }

        public dados_pessoaisModel()
        {
              Usuarios = new List<Usuario>
              {
                  new Usuario { Id = 1, Nome="Luiz Fernando" , CPF = "417.523.346-63",  Email="luiz@senac.com.br", Telefone="92645-6414" },
                  new Usuario { Id = 2, Nome="Carlos Eduardo",  CPF = "901.058.585-95",  Email="carlos@senac.com.br", Telefone="98546-1247" },
                  new Usuario { Id = 3,  Nome="Rui Renan",  CPF = "460.791.744-30",  Email="rui@senac.com.br", Telefone="97534-8574" }
              };
        }

        public void OnGet(int userid)
        {
            Usuario = Usuarios.Where(u => u.Id == userid).FirstOrDefault();
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}