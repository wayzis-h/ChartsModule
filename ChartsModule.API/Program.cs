
using System.Reflection;

namespace ChartsModule.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v0.1",
                    Title = "Charts module",
                    Description = "Open-source trades data storage service.",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Progect's GitHub page",
                        Url = new Uri("https://github.com/wayzis-h/ChartsModule")
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Licensed under GNU Affero General Public License v3.0",
                        Url = new Uri("https://www.gnu.org/licenses/agpl-3.0.html")
                    }
                });
                var xmlDocFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlDocFilename));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}