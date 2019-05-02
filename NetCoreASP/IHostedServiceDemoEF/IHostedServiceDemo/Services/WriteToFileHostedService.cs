using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IHostedServiceDemo.Services
{
    public class WriteToFileHostedService : IHostedService, IDisposable//limpia recursos del timer
    {
        private readonly IHostingEnvironment enviroment;
        private readonly string fileName = "File 1.txt";
        private Timer timer;

        public WriteToFileHostedService(IHostingEnvironment _enviroment)
        {
            this.enviroment = _enviroment;
        }

        //se ejecuta cuando se monta la aplicacion o se sube
        public Task StartAsync(CancellationToken cancellationToken)
        {
            WriteToFile("WriteToFileHostedService: Process Started");
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            WriteToFile("WriteToFileHostedService: Haciendo un trabajo a: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
        }

        //se ejecuta cuando se detiene la aplicacion
        public Task StopAsync(CancellationToken cancellationToken)
        {
            WriteToFile("WriteToFileHostedService: Process Stopped");
            timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void WriteToFile(string message)
        {
            var path = $@"{enviroment.ContentRootPath}\wwwroot\{fileName}";
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(message);
            }
        }

        public void Dispose()
        {
            //liberar recursos del timer, se ejecuta siempre y cuando el timer no sea null
            timer?.Dispose();
        }
    }
}
