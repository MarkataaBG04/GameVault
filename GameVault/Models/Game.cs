namespace GameVault.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Platform { get; set; } = string.Empty;

        public  GameStatus Status { get; set; }

        public int? Rating { get; set; }

        public string? Notes { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
