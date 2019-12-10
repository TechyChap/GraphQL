# Star Wars GraphQL Query Example

I put this together from a selection of references I found on the web. None of which seemed to give the whole picture or were overly complex.

A .Net Core app using the ASP Middleware to respond to HTTP requests.
Configured for graphql queries.
Listening on the end point /graphql, ports configured in the appsettings.json

## Example Queries

* graphql?Query={ jedi(id: 1) { name } }
* graphql?Query={ jedis { name, side } }

## Reference:
https://dev.to/dotnet/learn-how-you-can-use-graphql-in-net-core-and-c-4h96
https://github.com/graphql-dotnet/server
https://medium.com/volosoft/building-graphql-apis-with-asp-net-core-419b32a5305b
https://developer.okta.com/blog/2019/04/16/graphql-api-with-aspnetcore
https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core
