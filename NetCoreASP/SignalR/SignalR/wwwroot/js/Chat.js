const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
//.withUrl("/chatHub", signalR.HttpTransportType.ServerSentEvents).build();//en caso que no se quiera usar WebSokets
//.withUrl("/chatHub", signalR.HttpTransportType.LongPolling).build();//en caso que no se quiera usar WebSokets

//para chat entre grupos
//var urlParams = new URLSearchParams(window.location.search);
//const group = urlParams.get('group') || "Chat_Home";
//document.getElementById('titulo-sala').innerText = group;


//This method receive the message and Append to our list  
connection.on("ReceiveMessage", (user, message) => {
    const msg = message.replace(/&/g, "&").replace(/</g, "<").replace(/>/g, ">");
    //const msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    const fecha = new Date().toLocaleTimeString();
    //const mensajeAMostrar = fecha + " <strong>" + user + "</strong>:" + msg;
    const encodedMsg = fecha + " " + user + " :: " + msg;
    const li = document.createElement("li");
    li.textContent = encodedMsg;
    //li.textContent = mensajeAMostrar;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().catch(err => console.error(err.toString()));

//connection.start().then(() => {
//    //se ejecuta cuando se establece c onexion con el servidor
//    connection.invoke("AddToGroup", group)
//}).catch(err => {
//    console.error(err.toString());
//    event.target.disabled = false;
//});

//Send the message  

//document.getElementById("connect").addEventListener("click", event => {

//    connection.start().then(() => {
//        //se ejecuta cuando se establece c onexion con el servidor
//        connection.invoke("AddToGroup", group)
//    }).catch(err => {
//        console.error(err.toString());
//        event.target.disabled = false;
//    });

//    event.target.disabled = false;
//});


document.getElementById("sendButton").addEventListener("click", event => {

    //1 = conectado
    //if (connection.connection.connectionState !== 1) {
    //    alert("usted no esta conectado con el servicio");
    //    return;
    //}

    const user = document.getElementById("userInput").value;
    const message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));
    event.preventDefault();
});

//const connection = new signalR.HubConnectionBuilder()
//    .withUrl("/chatHub")
//    .build();

////This method receive the message and Append to our list  
//connection.on("ReceiveMessage", (user, message) => {
//    const msg = message.replace(/&/g, "&").replace(/</g, "<").replace(/>/g, ">");
//    const encodedMsg = user + " :: " + msg;
//    const li = document.createElement("li");
//    li.textContent = encodedMsg;
//    document.getElementById("messagesList").appendChild(li);
//});

//connection.start().catch(err => console.error(err.toString()));

////Send the message  

//document.getElementById("sendMessage").addEventListener("click", event => {
//    const user = document.getElementById("userName").value;
//    const message = document.getElementById("userMessage").value;
//    connection.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));
//    event.preventDefault();
//});   