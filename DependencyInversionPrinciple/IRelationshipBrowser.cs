using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface IRelationshipBrowser
    {
        IEnumerable<PersonAfter> FindALlChildrenOf(string name);
    }
}
