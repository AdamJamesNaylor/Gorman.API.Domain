namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class ActorSummary
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}