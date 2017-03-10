
namespace Gorman.API.Domain {
    using Newtonsoft.Json;

    public class ActivitySummary
        : BaseResource {

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}