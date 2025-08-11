namespace CalculadoraLib
{
    public class Calculadora
    {
        private readonly ILogger _logger;
        private readonly IRepositorio _repositorio;

        
        public Calculadora(ILogger logger, IRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            _logger.Registrar($"Soma: {a} + {b} = {resultado}");
            _repositorio.Salvar("Soma", resultado);
            return resultado;
        }

       
        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            _logger.Registrar($"Subtração: {a} - {b} = {resultado}");
            _repositorio.Salvar("Subtracao", resultado);
            return resultado;
        }

     
        public bool EhPar(int numero)
        {
            bool resultado = numero % 2 == 0;
            _logger.Registrar($"EhPar: {numero} = {resultado}");
            
            return resultado;
        }
    }
}