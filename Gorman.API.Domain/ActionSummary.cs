namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class ActionSummary 
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}