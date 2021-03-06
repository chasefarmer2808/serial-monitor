import serial
import Queue
import threading

PORT = 'COM3'


class SerialMonitor(object):
    def __init__(self):
        self._monitor = serial.Serial(PORT)
        self.queue = Queue.Queue()
        self.thread = threading.Thread(target=self.read)
        self.thread.start()

    def readline(self, bytes):
        return self._monitor.read(bytes)

    def write(self, data):
        print data
        data = data.encode('utf-8')
        self._monitor.write(data)

    def read(self):
        while True:
            if self._monitor.in_waiting:
                message = self.readline(self._monitor.in_waiting)

                self.queue.put(message)

    def available(self):
        return self.queue.qsize() > 0