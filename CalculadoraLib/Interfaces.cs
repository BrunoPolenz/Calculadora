namespace CalculadoraLib
{
    public interface ILogger
    {
        void Registrar(string mensagem);
    }

    public interface IRepositorio
    {
        void Salvar(string operacao, int valor);
    }
}