import sys
import socket
import string
from utils import *

SERVER_IP = "127.0.0.1"
PORT = 12345
CLOSE_MESSAGE = "exit"


def handle_server(sock: socket.socket):
    print(f">> is send, << is received.\nenter \"{CLOSE_MESSAGE}\" to exit.")
    data = input(">> ")
    while data != CLOSE_MESSAGE:
        send_message(sock, data)
        print(f"<< {receive_message(sock)}")
        data = input(">> ")
    send_message(sock, ServiceSettings.end)


def start_conversation():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.connect((SERVER_IP, PORT))

    handle_server(sock)

    sock.close()


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    start_conversation()
