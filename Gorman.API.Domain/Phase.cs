
namespace Gorman.API.Domain {
    using System.Collections.Generic;

    public class Phase {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public ICollection<Action> Actions { get; set; }
    }
}