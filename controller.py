import socket
import errno
import sys

clientip = '0.0.0.0'
serverport = 6458
clientport = 6458

c1 = socket.socket(type=socket.SOCK_DGRAM)
c1.bind((clientip, clientport))
data, adrs = c1.recvfrom(1024)
serverip = adrs[0]

c2 = socket.socket()
c2.connect((serverip, serverport))
print 'connected to {}'.format(adrs)

if len(sys.argv) == 1:
    massage = raw_input('>> ')
else:
    massage = ' '.join(sys.argv[1:])
while True:
    c2.send(massage)
    if massage == 'shutdown':
        c1.close()
        c2.close()
        break
    length = c2.recv(1024)
    c2.send('1')
    if length != '0':
        print c2.recv(int(length))
    length = c2.recv(1024)
    c2.send('1')
    if length != '0':
        print c2.recv(int(length))
    if len(sys.argv) != 1:
        break
    massage = raw_input('>> ')
