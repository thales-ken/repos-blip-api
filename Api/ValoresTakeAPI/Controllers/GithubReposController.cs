using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ValoresTakeAPI.Controllers;

public class GithubReposController : ControllerBase
{
    private readonly IGithubService _githubService;

    public GithubReposController(IGithubService githubService)
    {
        _githubService = githubService;
    }

    [HttpGet("five-oldest-csharp-repos")]
    public async Task<IActionResult> GetFiveOldestCsharpRepos()
    {
        var response = await _githubService.GetFiveOldestCsharpReposAsync();
        if (response.Count == 0)
        {
            return NotFound();
        }
        return Ok(response);
    }
}
