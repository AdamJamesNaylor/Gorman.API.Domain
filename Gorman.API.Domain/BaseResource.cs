namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public abstract class BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}