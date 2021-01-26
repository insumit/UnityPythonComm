import socket

UDP_IP = "127.0.0.1"
UDP_PORT = 8881
MESSAGE = "Hello!"

print ("UDP target IP: ", UDP_IP)
print ("UDP target port: ", UDP_PORT)
print ("Message: ", MESSAGE)

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
sock.sendto(bytes(MESSAGE, "utf-8"), (UDP_IP, UDP_PORT))