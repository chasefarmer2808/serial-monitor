import serial
import Queue


class Serial_Monitor(object):
    def __init__(self, port):
        self._monitor = serial.Serial(port)
        self.queue = Queue.Queue()

    def readline(self, bytes):
        return self._monitor.readline(bytes).decode()

    def write(self, data):
        print data
        self._monitor.write(data)

    def read(self):
        while True:
            if self._monitor.in_waiting:
                message = self.readline(self._monitor.in_waiting).decode()
                self.queue.put(message)

    def available(self):
        return self.queue.qsize() > 0