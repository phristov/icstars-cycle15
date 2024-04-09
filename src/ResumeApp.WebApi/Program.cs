using Microsoft.EntityFrameworkCore;
using ResumeApp.Data;
using ResumeApp.WebApi.Services;

namespace ResumeApp.WebApi
{
    public class Program
    {
        const string ConnectionString = "Server=tcp:pavel.database.windows.net,1433;Initial Catalog=pavel;Persist Security Info=False;User ID=pavel;Password=password12#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ResumeAppDbContext>(x => x.UseSqlServer(ConnectionString));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "Test",policy => 
                                {
                                    policy.AllowAnyHeader()
                                        .AllowAnyOrigin()
                                        .AllowAnyMethod();
                                });
            });


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IServerService, ServerService>();
            builder.Services.AddTransient<IResumeService, ResumeService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("Test");

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
