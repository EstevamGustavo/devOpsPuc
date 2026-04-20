using devOpsPuc.DTOs;

namespace devOpsPuc.Services
{
    public class GameService : IGameService
    {
        private static List<string> games = new List<string>
        {
            "Game 1",
            "Game 2"
        };

        public List<string> GetAll()
        {
            return games;
        }

        public string GetByIndex(int index)
        {
            if (index < 0 || index >= games.Count)
                return null;

            return games[index];
        }

        public List<string> Add(GameDto dto)
        {
            games.Add(dto.Name);
            return games;
        }

        public List<string> Delete(int index)
        {
            if (index < 0 || index >= games.Count)
                return games;

            games.RemoveAt(index);
            return games;
        }

        public List<string> Update(int index, GameDto dto)
        {
            if (index < 0 || index >= games.Count)
                return games;

            games[index] = dto.Name;
            return games;
        }
    }
}