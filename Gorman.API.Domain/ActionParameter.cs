namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class ActionParameter
        : BaseResource {

        [JsonProperty("action_id")]
        public long ActionId { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}