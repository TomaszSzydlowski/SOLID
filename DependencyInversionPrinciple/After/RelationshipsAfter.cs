using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class RelationshipsAfter:IRelationshipBrowser
    {
        private List<(PersonAfter, RelationshipAfter, PersonAfter)> relations = new List<(PersonAfter, RelationshipAfter, PersonAfter)>();
        public void AddParentAndChild(PersonAfter parent, PersonAfter child)
        {
            relations.Add((parent, RelationshipAfter.Parent, child));
            relations.Add((child, RelationshipAfter.Child, parent));
        }

        public IEnumerable<PersonAfter> FindALlChildrenOf(string name)
        {
            foreach(var r in relations.Where(
                x=>x.Item1.Name==name &&
                x.Item2==RelationshipAfter.Parent
                ))
            {
                yield return r.Item3;
            }
        }

        public List<(PersonAfter, RelationshipAfter, PersonAfter)> Relations => relations;
    }
}
