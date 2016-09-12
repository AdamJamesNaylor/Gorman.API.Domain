
namespace Gorman.API.Domain {
    using System.Collections.ObjectModel;
    using Newtonsoft.Json;

    public class Response<T> {
        public T Data { get; set; }
        public ErrorResponse Error { get; set; }
    }

    public class ErrorResponse {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public ReadOnlyCollection<Error> Errors { get; set; }
    }

    public class Error {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

}