using Xunit;
using Moq;
using CalculadoraLib;

namespace CalculadoraTests
{
    public class CalculadoraIntegracaoTests
    {
        
        private readonly Mock<ILogger> _mockLogger = new Mock<ILogger>();
        private readonly Mock<IRepositorio> _mockRepositorio = new Mock<IRepositorio>();
        private readonly Calculadora _calculadora;

       
        public CalculadoraIntegracaoTests()
        {
            
            _calculadora = new Calculadora(_mockLogger.Object, _mockRepositorio.Object);
        }

        
        [Fact]
        public void Somar_DeveChamarLoggerERepositorio()
        {
            
            int resultado = _calculadora.Somar(2, 3);

            
            Assert.Equal(5, resultado);

            
            _mockLogger.Verify(
                l => l.Registrar("Soma: 2 + 3 = 5"),
                Times.Once);

            
            _mockRepositorio.Verify(
                r => r.Salvar("Soma", 5),
                Times.Once);
        }
    }
}