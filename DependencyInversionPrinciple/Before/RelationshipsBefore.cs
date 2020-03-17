using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class RelationshipsBefore
    {
        private List<(PersonBefore, RelationshipBefore, PersonBefore)> relations = new List<(PersonBefore, RelationshipBefore, PersonBefore)>();
        public void AddParentAndChild(PersonBefore parent, PersonBefore child)
        {
            relations.Add((parent, RelationshipBefore.Parent, child));
            relations.Add((child, RelationshipBefore.Child, parent));
        }
        public List<(PersonBefore, RelationshipBefore, PersonBefore)> Relations => relations;
    }
}
