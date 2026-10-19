using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;
public interface IMatchRepository : IGenericRepository<Match>

{
    // Returns active matches with both teams loaded.
    // status: optional filter by match status.
    // search: optional text to look for in the home or away team name.
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);

}