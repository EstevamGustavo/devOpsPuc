using devOpsPuc.Services;
using devOpsPuc.DTOs;
using Xunit;

namespace devOpsPuc.Tests
{
    public class GameServiceTests
    {
        private readonly GameService _service;

        public GameServiceTests()
        {
            _service = new GameService();
        }

        [Fact]
        public void Add_ShouldAddGame()
        {
            var dto = new GameDto { Name = "Novo Game" };

            var result = _service.Add(dto);

            Assert.Contains("Novo Game", result);
        }

        [Fact]
        public void GetByIndex_ShouldReturnNull_WhenInvalid()
        {
            var result = _service.GetByIndex(999);

            Assert.Null(result);
        }

        [Fact]
        public void Delete_ShouldNotCrash_WhenInvalidIndex()
        {
            var result = _service.Delete(999);

            Assert.NotNull(result);
        }

        [Fact]
        public void Update_ShouldUpdateGame()
        {
            var dto = new GameDto { Name = "Atualizado" };

            _service.Update(0, dto);

            var result = _service.GetByIndex(0);

            Assert.Equal("Atualizado", result);
        }
    }
}