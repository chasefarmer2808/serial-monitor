import serial


class Serial_Monitor(object):
    def __init__(self, port):
        self._monitor = serial.Serial(port)

    def readline(self):
        return self._monitor.readline().decode()

    def write(self, data):
        print data
        self._monitor.write(data)

    def read_and_print(self):
        while True:
            print self._monitor.readline().decode()