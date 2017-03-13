
namespace Gorman.API.Domain {
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Activity
        : BaseResource {

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("map_id")]
        public long MapId { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("actions_url")]
        public string ActionsUrl { get; set; }

        [JsonProperty("actions")]
        public List<ActionSummary> Actions { get; set; }

        [JsonProperty("activities_url")]
        public string ActivitiesUrl { get; set; }

        [JsonProperty("activities")]
        public List<ActivitySummary> Activities { get; set; }

        [JsonProperty("actors_url")]
        public string ActorsUrl { get; set; }

        [JsonProperty("actors")]
        public List<ActorSummary> Actors { get; set; }
    }
}