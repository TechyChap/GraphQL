using GraphQL;
using GraphQL.Types;

namespace App
{

    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<StarWarsQuery>();
            //Can also add Mutator here
        }

    }
}