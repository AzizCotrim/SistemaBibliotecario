namespace Sistema_de_Biblioteca.Application.DTOs.Usuario
{
    internal class UsuarioCreateRequest
    {
        public string Name { get; }
        public string Login { get; }
        private byte[] _Salt { get; }
        private string _Hash { get; }
        public int Permission { get; }
    }
}
