import Queue

from Tkinter import Frame, Scrollbar, Text, BOTH, RIGHT, Y

from SerialMonitor import SerialMonitor

class App(Frame):
    def __init__(self, parent):
        Frame.__init__(self, parent, background="white")

        self.monitor = SerialMonitor()

        self.parent = parent
        self.scrollbar = Scrollbar(parent)
        self.logbox = Text(parent, width=30, height=30, takefocus=0)

        self.initUI()
        self.process_serial_input()


    def initUI(self):
        self.parent.title("Serial Monitor")
        self.pack(fill=BOTH, expand=1)
        self.scrollbar.pack(side=RIGHT, fill=Y)
        self.logbox.pack()
        self.logbox.config(yscrollcommand=self.scrollbar.set)
        self.scrollbar.config(command=self.logbox.yview)

    def process_serial_input(self):
        while self.monitor.available():
            try:
                self.logbox.insert('end', self.monitor.queue.get())
            except Queue.Empty:
                pass
        self.after(100, self.process_serial_input)
