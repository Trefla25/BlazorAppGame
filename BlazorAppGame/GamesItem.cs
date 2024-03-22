using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppGame
{
    public class GamesItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;

    }
}


