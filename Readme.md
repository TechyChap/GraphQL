# Star Wars GraphQL Query Example

I put this together from a selection of references I found on the web. None of which seemed to give the whole picture or were overly complex.

A .Net Core 3.0 application using the ASP Middleware to respond to HTTP requests.
Configured for graphql queries.
Listening on the end point /graphql, ports configured in the appsettings.json

Uses the [Graphql Dot Net](https://github.com/graphql-dotnet/graphql-dotnet) package and [server](https://github.com/graphql-dotnet/server) package

## Example Queries

* graphql?Query={ jedis { name, side } }

### Expected Response

    {
        "data": {
            "jedis": [
              {
                  "name": "Luke",
                  "side": "Light"
              },
              {
                  "name": "Yoda",
                  "side": "Light"
              },
              {
                  "name": "Darth Vader",
                  "side": "Dark"
              }
            ]
        }
     }

* graphql?Query={ jedi(id: 1) { name } }

### Expected Response

    {
        "data": {
            "jedi": {
                "name": "Luke"
                    }
                }
    }

## Reference:
* https://dev.to/dotnet/learn-how-you-can-use-graphql-in-net-core-and-c-4h96
* https://github.com/graphql-dotnet/server
* https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b
* https://developer.okta.com/blog/2019/04/16/graphql-api-with-aspnetcore
* https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core
