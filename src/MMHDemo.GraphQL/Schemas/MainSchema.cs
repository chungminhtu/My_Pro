using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using MMHDemo.Queries.Container;

namespace MMHDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}