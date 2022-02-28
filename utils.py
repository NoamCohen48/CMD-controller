import socket
import string


class ServiceSettings:
    end = "Server.end"
    close = "Server.close"


def fix_message(message: string) -> string:
    output = message.split('\n')
    result = ""
    for cell in output:
        if cell:
            result += f"{cell}\n"

    if result:
        return result + '\n'

    # if result is empty
    return '<empty>\n\n'


def receive_message(sock: socket.socket) -> string:
    # receiving a message
    data: bytes = sock.recv(1)
    while not data.endswith(b'\n\n'):
        data += sock.recv(1)
    return data.decode().rstrip('\n\n')


def send_message(sock: socket.socket, message: string):
    sock.send(fix_message(message).encode())
