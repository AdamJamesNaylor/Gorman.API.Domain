

namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class Map
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("activities_url")]
        public string ActivitiesUrl { get; set; }

        [JsonProperty("actors_url")]
        public string ActorsUrl { get; set; }

        [JsonProperty("tile_url")]
        public string TileUrl { get; set; }

    }
}