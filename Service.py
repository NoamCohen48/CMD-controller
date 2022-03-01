import socket
import string
import subprocess
from utils import *

PORT = 12345
TIMEOUT = 1


def execute_command(command: str) -> str:
    try:
        result = subprocess.run(args=command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT,
                                text=True, shell=True, timeout=TIMEOUT)
        return result.stdout

    except subprocess.TimeoutExpired:
        return "<timeout>\n"

    except Exception as e:
        raise e


def handle_client(client_sock: socket.socket):
    # TODO: add to run command and send answer
    # processing client request and answering
    data = receive_message(client_sock)
    while data != ServiceSettings.end:
        result = execute_command(data)
        send_message(client_sock, result)
        data = receive_message(client_sock)


def run_server():
    # open server socket
    server_sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    # server_sock.settimeout(1)
    server_sock.bind(("", PORT))
    server_sock.listen(1)

    while True:
        try:
            # open a client handler with a new thread
            client_sock, address = server_sock.accept()
            handle_client(client_sock)
        except socket.timeout:
            pass
        except Exception as e:
            raise e

    # the executor wait here for all to finish


if __name__ == '__main__':
    # execute_command("nslookup www.google.com")
    run_server()
