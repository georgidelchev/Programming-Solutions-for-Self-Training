import socket 
import threading
import pickle

#Create custom protocol
HEADER = 1024
PORT = 5050
SERVER = "127.0.0.1"
ADDR = (SERVER, PORT)
FORMAT = 'utf-8'
DISCONNECT_MESSAGE = "!DISCONNECT"

#Initialze socket as server
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(ADDR)
msg_list = []

def handle_client(conn, addr):
    print(f"[NEW CONNECTION] {addr} connected.")
    
    #Client handler infinte loop recieves data and prints
    connected = True
    while connected:
        #Receive first msg lenght from client
        msg_length = conn.recv(HEADER).decode(FORMAT)
        if msg_length:
            msg_length = int(msg_length)
            msg = conn.recv(msg_length).decode(FORMAT)
            msg_list.append(msg)
            if msg == DISCONNECT_MESSAGE:
                connected = False
            print(f"[{addr}] {msg}")

            conn.send(b"recieved")
    conn.close()
        

def start():
    #start server
    server.listen()
    print(f"[LISTENING] Server is listening on {SERVER}")
    while True:
        conn, addr = server.accept()
        #Start new processro thread for each client
        thread = threading.Thread(target=handle_client, args=(conn, addr))
        thread.start()
        print(f"[ACTIVE CONNECTIONS] {threading.activeCount() - 1}")


print("[STARTING] server is starting...")
start()
