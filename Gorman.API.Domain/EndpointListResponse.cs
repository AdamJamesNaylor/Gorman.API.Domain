
namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class EndpointListResponse {
        [JsonProperty("map_url")]
        public string MapUrl { get; set; }
    }
}