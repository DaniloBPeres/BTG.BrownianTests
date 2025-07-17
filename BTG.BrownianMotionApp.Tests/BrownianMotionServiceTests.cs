using BTG.BrownianMotianApp.Core.Service;
using BTG.BrownianTests.Core.Interface;
using BTG.BrownianTests.Core.Models;
using FluentAssertions;

namespace BTG.BrownianMotionApp.Tests
{
    public class BrownianMotionServiceTests
    {
        private readonly IBrownianMotionService _service;

        public BrownianMotionServiceTests()
        {
            _service = new BrownianMotionService();
        }

        [Fact]
        public void Generate_ShouldReturnValidPaths_WhenCalledWithValidParameters()
        {
            var parameters = new BrownianParameters
            {
                InitialPrice = 100,
                Volatility = 0.2,
                MeanReturn = 0.05,
                Duration = 10,
                Paths = 5
            };

            var result = _service.Generate(parameters);

            result.Should().NotBeNull();
            result.Paths.Should().NotBeEmpty();
            result.Paths.Count.Should().Be(parameters.Paths);
            foreach (var path in result.Paths)
            {
                path.Should().NotBeEmpty();
                path.Count.Should().Be(parameters.Duration + 1);
            }
        }

        [Theory]
        [InlineData(0, 100)] // InitialPrice inválido
        [InlineData(100, 0)] // Paths inválido
        [InlineData(100, -1)] // Paths negativo
        public void Generate_WithInvalidParameters_ShouldReturnEmpty(double initialPrice, int paths)
        {
            var parameters = new BrownianParameters
            {
                InitialPrice = initialPrice,
                Volatility = 0.2,
                MeanReturn = 0.05,
                Duration = 50,
                Paths = paths
            };

            var result = _service.Generate(parameters);

            result.Paths.Should().BeEmpty("os parâmetros inválidos devem impedir a geração da simulação");
        }
    }
}
