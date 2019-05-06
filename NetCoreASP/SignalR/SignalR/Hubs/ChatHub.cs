using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {

        public async Task SendMessage(string user, string message)
        {
            //envia informacion a todos los subscritos a mi sitio
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //a todas las personas excepto a la que envio el mensaje
            //await Clients.Others.SendAsync("ReceiveMessage", user, message);
            //Le envia el mesaje al emisor solamente
            //await Clients.Caller.SendAsync("ReceiveMessage", user, message);

            //timer para enviar cada segundo el mensaje
            //await Task.Delay(1000);
            //await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }


        //para trabajar con grupos
        //public async Task SendMessage(string user, string message, string group)
        //{
        //    //se podria enviar un mensaje a un solo usuario especifico
        //    //Clients.Client("asdddffffff").SendAsync():
        //    //Clients.User("userID")

        //    await Clients.Group(group).SendAsync("ReceiveMessage", user, message);
        //}


        //public async Task AddToGroup(string group)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, group);
        //}

        ////se ejecuta cuando el usuario se conecta
        //public override async Task OnConnectedAsync()
        //{
        //    await base.OnConnectedAsync();
        //}

        ////se ejecuta cuando el usuario se desconecta
        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    var groups = new string[] { "Chat_Home", "Chat_Sala2" };
        //    foreach (var group in groups)
        //    {
        //        await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
        //    }
        //}
    }
}
