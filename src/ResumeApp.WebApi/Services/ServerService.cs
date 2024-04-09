using Microsoft.EntityFrameworkCore.Diagnostics;
using ResumeApp.Data;
using ResumeApp.WebApi.Dtos;

namespace ResumeApp.WebApi.Services
{
    public interface IServerService
    {
        ICollection<ServerDto> GetAll();
    }

    public class ServerService : IServerService
    {
        public ServerService(ResumeAppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public ResumeAppDbContext DbContext { get; }

        public ICollection<ServerDto> GetAll()
        {
            var data = this.DbContext.Servers.Select(x => new ServerDto()
            {
                ServerId = x.ServerId,
                ServerName = x.ServerName,
            })
            .ToList();

            return data;
        }
    }
}
