using System;
using System.Linq;

namespace DependencyInversionPrinciple
{

    class Research
    {
        static void Main(string[] args)
        {
            var parentBefore = new PersonBefore { Name = "John" };
            var child1Before = new PersonBefore { Name = "Piotr" };
            var child2Before = new PersonBefore { Name = "Lucja" };

            var relationshipsBefore = new RelationshipsBefore();
            relationshipsBefore.AddParentAndChild(parentBefore, child1Before);
            relationshipsBefore.AddParentAndChild(parentBefore, child2Before);

            SearchBefore(relationshipsBefore);

            var parentAfter = new PersonAfter { Name = "John" };
            var child1After = new PersonAfter { Name = "Piotr" };
            var child2After = new PersonAfter { Name = "Lucja" };

            var relationshipsAfter = new RelationshipsAfter();
            relationshipsAfter.AddParentAndChild(parentAfter, child1After);
            relationshipsAfter.AddParentAndChild(parentAfter, child2After);

            SearchAfter(parentAfter, relationshipsAfter);
        }

        public static void SearchBefore(RelationshipsBefore relationships)
        {
            var relations = relationships.Relations;

            foreach (var r in relations.Where(
                x => x.Item1.Name == "John" &&
                x.Item2 == RelationshipBefore.Parent
                ))
            {
                Console.WriteLine($"John has a child called {r.Item3.Name}");
            }
        }

        public static void SearchAfter(PersonAfter parent, IRelationshipBrowser browser)
        {
            foreach (var r in browser.FindALlChildrenOf(parent.Name))
            {
                Console.WriteLine($"{parent.Name} has a child called {r.Name}");
            }
        }
    }
}
