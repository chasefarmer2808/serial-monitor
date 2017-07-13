import serial
import threading

PORT = 'COM3'

device = serial.Serial(PORT)


def handle_data(data):
    print data


def read_from_port(dev):
    while True:
        reading = dev.readline().decode()
        handle_data(reading)

thread = threading.Thread(target=read_from_port, args=(device,))
thread.start()