import serial

PORT = 'COM3'

device = serial.Serial(PORT)

while True:
    if device.in_waiting:
        line = device.readline()
        print line

