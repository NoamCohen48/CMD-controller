import socket
import string


class ServiceSettings:
    end = "Server.end"
    close = "Server.close"


def fix_message(message: str) -> str:
    output = message.split('\n')
    result = ""
    for cell in output:
        if cell:
            result += f"{cell}\n"

    if result:
        return result + '\n'

    # if result is empty
    return '<empty>\n\n'


def receive_message(sock: socket.socket) -> str:
    # receiving till \n - length
    data: bytes = sock.recv(1)
    while not data.endswith(b'\n'):
        data += sock.recv(1)

    length = int(data.decode().rstrip('\n'))

    return sock.recv(length).decode().rstrip('\n')


def send_message(sock: socket.socket, message: str):
    length = str(len(message.encode()))
    sock.send(f"{length}\n{message}".encode())
