import threading
import time
import Serial_Monitor

PORT = 'COM3'

device = Serial_Monitor.Serial_Monitor(PORT)

def run_serial_monitor():
    while True:
        device.write('there')
        time.sleep(2)

if __name__ == '__main__':
    thread = threading.Thread(target=device.read_and_print)
    thread.start()
    run_serial_monitor()