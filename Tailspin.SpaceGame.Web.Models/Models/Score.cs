using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Score : Model
    {
        // The ID of the player profile associated with this score.
        [JsonPropertyName("profileId")]
        public string ProfileId { get; set; }

        // The score value.
        [JsonPropertyName("score")]
        public int HighScore { get; set; }

        // The game mode the score is associated with.
        [JsonPropertyName("gameMode")]
        public string GameMode { get; set; }

        // The game region (map) the score is associated with.
        [JsonPropertyName("gameRegion")]
        public string GameRegion { get; set; }

<<<<<<< HEAD
        // The game style (difficulty) the score is associated with.
=======
         // The game style (difficulty) the score is associated with.
>>>>>>> a9e3829bee0f06b00f856aa7b4746c86e28f525e
        [JsonPropertyName("gameStyle")]
        public string GameStyle { get; set; }
    }
}