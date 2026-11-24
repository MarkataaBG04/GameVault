namespace GameVault.Models
{
    public class Game
    {
        public Game(string title, string platform, GameStatus status, int? rating, string? notes, DateTime dateAdded)
        {
            Title = title;
            Platform = platform;
            Status = status;
            Rating = rating;
            Notes = notes;
            DateAdded = dateAdded;
        }

        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Platform { get; set; } = string.Empty;

        public  GameStatus Status { get; set; }

        public int? Rating { get; set; }

        public string? Notes { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
