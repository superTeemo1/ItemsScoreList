using GRMTestApp.Models;

namespace GRMTestApp.Repository
{
    public interface IAppRepository
    {
        Task MatchesInitial();
        Task<List<Item>> GetAllItems();
        Task<List<Match>> GetAllMatches();
        Task<List<Item>> GetNextMatch();
    }
}