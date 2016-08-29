namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public abstract class BaseResource {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}