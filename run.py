import threading
import time

from Tkinter import Tk

from classes import Serial_Monitor, Window

PORT = 'COM3'

device = Serial_Monitor.Serial_Monitor(PORT)

if __name__ == '__main__':
    thread = threading.Thread(target=device.read)
    thread.start()

    app = Tk()
    app.geometry("250x150+300+300")
    gui = Window.Window(app, device)
    app.mainloop()