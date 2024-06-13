using Domain.Entities;

namespace Domain.Interfaces;

public interface IGithubService
{
    /// <summary>
    /// Get Five Oldest Csharp Repositories
    /// </summary>
    /// <returns> List of Github Response </returns>
    Task<List<GithubResponse>> GetFiveOldestCsharpReposAsync();
}
