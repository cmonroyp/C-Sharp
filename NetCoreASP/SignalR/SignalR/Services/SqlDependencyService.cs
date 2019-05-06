using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Services
{
    public interface IDatabaseChangeNotificationService
    {
        void Config();
    }
    public class SqlDependencyService : IDatabaseChangeNotificationService
    {

        private readonly IConfiguration configuration;
        private readonly IHubContext<ChatHub> chatHub;
        //IHubContext indica a signalr cada vez que haya un cambio en la tabla de sqlserver
        public SqlDependencyService(IConfiguration configuration, IHubContext<ChatHub> chatHub)
        {
            this.configuration = configuration;
            this.chatHub = chatHub;
        }

        public void Config()
        {
            SuscribirseAlosCambiosDeLaTablaPersonas();
        }

        private void SuscribirseAlosCambiosDeLaTablaPersonas()
        {
            string connString = configuration.GetConnectionString("defaultConnection");
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                //no funciona con select *
                using (var cmd = new SqlCommand(@"SELECT Nombre FROM [dbo].Personas", conn))
                {
                    cmd.Notification = null;
                    SqlDependency dependency = new SqlDependency(cmd);
                    dependency.OnChange += Personas_Cambio;
                    SqlDependency.Start(connString);
                    cmd.ExecuteReader();//hay que correr el query
                }

            }
        }

        private void Personas_Cambio(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                string mesanje = ObtenerMensajeAMostar(e);
                chatHub.Clients.All.SendAsync("ReceiveMessage", "Admin", mesanje);
            }

            SuscribirseAlosCambiosDeLaTablaPersonas();//hay que volver a suscribirse para cualquier cambio de nuevo en la tabla.
        }

        private string ObtenerMensajeAMostar(SqlNotificationEventArgs e)
        {
            switch (e.Info)
            {
                //case SqlNotificationInfo.Truncate:
                //    break;
                case SqlNotificationInfo.Insert:
                    return "Un registro ha sido Insertado";
                case SqlNotificationInfo.Update:
                    return "Un registro ha sido Actualizado";
                case SqlNotificationInfo.Delete:
                    return "Un registro ha sido Borrado";
                //case SqlNotificationInfo.Drop:
                //    break;
                //case SqlNotificationInfo.Alter:
                //    break;
                //case SqlNotificationInfo.Restart:
                //    break;
                //case SqlNotificationInfo.Error:
                //    break;
                //case SqlNotificationInfo.Query:
                //    break;
                //case SqlNotificationInfo.Invalid:
                //    break;
                //case SqlNotificationInfo.Options:
                //    break;
                //case SqlNotificationInfo.Isolation:
                //    break;
                //case SqlNotificationInfo.Expired:
                //    break;
                //case SqlNotificationInfo.Resource:
                //    break;
                //case SqlNotificationInfo.PreviousFire:
                //    break;
                //case SqlNotificationInfo.TemplateLimit:
                //    break;
                //case SqlNotificationInfo.Merge:
                //    break;
                //case SqlNotificationInfo.Unknown:
                //    break;
                //case SqlNotificationInfo.AlreadyChanged:
                //    break;
                default:
                    return "Un cambio desconocido ha ocurrido";
            }
        }
    }
}
