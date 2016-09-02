namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class Action
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("actor_id")]
        public long ActorId { get; set; }

        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        [JsonProperty("type")]
        public ActionType Type { get; set; }
    }
}