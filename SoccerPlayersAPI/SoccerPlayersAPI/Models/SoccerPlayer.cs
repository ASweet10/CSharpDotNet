namespace SoccerPlayersAPI.Models
{
    public class SoccerPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string HomeCountry { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
    }
}
