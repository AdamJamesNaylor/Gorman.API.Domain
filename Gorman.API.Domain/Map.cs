

namespace Gorman.API.Domain {
    using System.Collections.ObjectModel;

    public class Map
        : BaseResource {

        public int Id { get; set; }

        public string Name { get; set; }
        public string TileUrl { get; set; }
        public string Privacy { get; set; }

        public Collection<Activity> Activities { get; set; }

        public Map() {
            Activities = new Collection<Activity>();
        }
    }
}