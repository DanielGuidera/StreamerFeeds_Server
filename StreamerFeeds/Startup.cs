using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace TodoApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
            //services.AddCors();
            services.AddMvc();
            //services.Configure<MvcOptions>(options => {
            //    options.Filters.Add(new CorsAuthorizationFilterFactory("AllowSpecificOrigin"));
            //});
        }

        public void Configure(IApplicationBuilder app)
        {
            //app.UseCors(builder =>
            //builder
            //.WithOrigins("http://localhost")
            //.AllowAnyHeader()
            //.AllowAnyMethod()
            //.AllowCredentials()
            //);

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            app.UseMvc();
        }
    }
}