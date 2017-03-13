namespace Gorman.API.Domain {
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Action
        : BaseResource {

        [JsonProperty("actor_id")]
        public long ActorId { get; set; }

        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        [JsonProperty("parameters")]
        public List<ActionParameter> Parameters { get; set; }
    }
}