namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class EndpointList {
        [JsonProperty("maps_url")]
        public string MapsUrl { get; set; }

        [JsonProperty("activities_url")]
        public string ActivitiesUrl { get; set; }

        [JsonProperty("actors_url")]
        public string ActorsUrl { get; set; }

        [JsonProperty("actions_url")]
        public string ActionsUrl { get; set; }
    }
}