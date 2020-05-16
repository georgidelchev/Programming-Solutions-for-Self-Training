import socket
import threading
import pickle

#Custom protocol
HEADER = 1024
PORT = 5050
FORMAT = 'utf-8'
DISCONNECT_MESSAGE = "!DISCONNECT"
SERVER = "127.0.0.1"
ADDR = (SERVER, PORT)

#define client
client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect(ADDR)

def send(msg):
    message = msg.encode(FORMAT)
    msg_length = len(message)
    #send msg lenght
    send_length = str(msg_length).encode(FORMAT)
    send_length += b' ' * (HEADER - len(send_length))
    #send msg
    client.send(send_length)
    client.send(message)
    print(client.recv(2048).decode(FORMAT))
    
#infinte loop to read msgs and send
while True:
    msg = input("> ")
    if msg == " ":
        send(DISCONNECT_MESSAGE)
    send(msg)
