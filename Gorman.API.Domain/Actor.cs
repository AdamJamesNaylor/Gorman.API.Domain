namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class Actor
        : BaseResource {

        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        [JsonProperty("position_x")]
        public long PositionX { get; set; }

        [JsonProperty("position_y")]
        public long PositionY { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}