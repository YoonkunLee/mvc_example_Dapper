const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();

connection.on("ForwardToClients", (user, message) => {
    const msg = user + ": " + message;
    //const encoding = user + " says: " + msg;
    const li = document.createElement("li");
    li.textContent = msg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().catch(err => console.error(err.toString()));

document.getElementById("sendButton").addEventListener("click", event => {
    const user = document.getElementById("userInput").value;
    const message = document.getElementById("messageInput").value;

    connection.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));
    event.preventDefault();
});

document.getElementById("sendButton1").addEventListener("click", event => {
    const cusName = document.getElementById("cusName").value;
    console.log(cusName);
    const cusGender = document.getElementById("cusGender").value;
    const cusEmail = document.getElementById("cusEmail").value;
    const cusDate = document.getElementById("cusDate").value;

    connection.invoke("SendMessage1", cusName, cusGender, cusEmail, cusDate).catch(err => console.error(err.toString()));
    event.preventDefault();
});