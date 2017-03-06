
namespace Gorman.API.Domain {
    using System.Collections.Generic;
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

        [JsonProperty("actions")]
        public IEnumerable<Action> Actions { get; set; }

        [JsonProperty("actors")]
        public IEnumerable<Actor> Actors { get; set; }
    }
}