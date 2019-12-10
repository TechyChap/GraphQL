

using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IDependencyResolver>(x =>
                new FuncDependencyResolver(x.GetRequiredService));

            services.AddScoped<JediType>();
            services.AddScoped<StarWarsQuery>();
            services.AddScoped<StarWarsSchema>();
            services.AddScoped<StarWarsDB>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, StarWarsDB db)
        {
            app.UseDeveloperExceptionPage();

            app.UseGraphQL<StarWarsSchema>("/graphql");

            // Create a very simple page with 2 links on it to demo the API. 
            // These are not required for the API to work
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("<html><body><a href=\"graphql?Query={ jedis { name, side } }\" > Get All</a><br /><a href=\"graphql?Query={ jedi(id: 1) { name } }\" > Get Luke</a><br /></body></html>");
                });
            });
        }
    }
}
