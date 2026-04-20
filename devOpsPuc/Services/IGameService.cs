using devOpsPuc.DTOs;

namespace devOpsPuc.Services
{
    public interface IGameService
    {
        List<string> GetAll();
        string GetByIndex(int index);
        List<string> Add(GameDto dto);
        List<string> Delete(int index);
        List<string> Update(int index, GameDto dto);
    }
}