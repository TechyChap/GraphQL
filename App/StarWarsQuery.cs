using System.Collections.Generic;
using GraphQL;
using GraphQL.Types;
using System.Linq;

public class StarWarsQuery : ObjectGraphType
{
        public StarWarsQuery(StarWarsDB db)
        {
            Field<JediType>(
                 "jedi",
                 arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                 resolve: context => db.GetJedis().SingleOrDefault(j => j.Id == context.GetArgument<int>("id")));
    
            Field<ListGraphType<JediType>>(
                 "jedis",
                 resolve: context => db.GetJedis());
    }
}