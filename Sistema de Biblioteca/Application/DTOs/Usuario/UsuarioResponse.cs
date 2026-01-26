using Sistema_de_Biblioteca.Application.DTOs.Permissao;

namespace Sistema_de_Biblioteca.Application.DTOs.Usuario
{
    internal class UsuarioResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PermissaoResponse Permissao { get; set; }
    }
}
