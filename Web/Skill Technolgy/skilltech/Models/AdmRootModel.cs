using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace skilltech.Models
{
    public class AdmRootModel
    {
       public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        private readonly string AdminEmail = "sime@adm.com";
        private readonly string AdminSenha = "sime1234";

        // Método para validar se as credenciais fornecidas são iguais às credenciais padrão do administrador
        public bool IsValidAdmin()
        {
            return Email == AdminEmail && Senha == AdminSenha;
        }
    }
}
