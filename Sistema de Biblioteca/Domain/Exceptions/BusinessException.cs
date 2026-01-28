namespace Sistema_de_Biblioteca.Domain.Exceptions
{
    internal class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}
