using IHostedServiceDemo.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IHostedServiceDemo.Services
{
    public class ConsumeScopedService : IHostedService, IDisposable
    {
        public IServiceProvider Services { get; }
        private Timer timer;
        public ConsumeScopedService(IServiceProvider services)
        {
            Services = services;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            //WriteToFile("WriteToFileHostedService: Process Started");
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(20));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            using (var scope = Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var message = "ConsumeScopedService mensaje recibido a: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
                var log = new HostedServiceLog() { Message = message };
                context.HotedServiceLogs.Add(log);
                context.SaveChanges();
            }
        }
        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}
