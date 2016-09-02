
namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class Activity
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("map_id")]
        public long MapId { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("actions_url")]
        public string ActionsUrl { get; set; }
    }
}