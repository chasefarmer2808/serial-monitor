import Queue

from Tkinter import Frame, Scrollbar, Text, Button, BOTH, RIGHT, Y, DISABLED, NORMAL, LEFT, RAISED

from SerialMonitor import SerialMonitor

class App(Frame):
    def __init__(self, parent):
        Frame.__init__(self, parent, background="white")

        self.monitor = SerialMonitor()

        self.parent = parent

        self.frame = Frame(parent, relief=RAISED, borderwidth=1)

        self.scrollbar = Scrollbar(parent)

        self.receive_box = Text(parent, width=10, height=10, takefocus=0)
        self.transmit_box = Text(parent, width=10, height=10, takefocus=0)

        self.send_button = Button(parent, text="Send", command=self.send_message)

        self.initUI()
        self.process_serial_input()
        #self.send_message()


    def initUI(self):
        self.parent.title("Serial Monitor")

        self.frame.pack(fill=BOTH, expand=True)

        self.pack(fill=BOTH, expand=1)

        self.scrollbar.pack(side=RIGHT, fill=Y)

        self.receive_box.pack(side=LEFT)
        self.receive_box.config(yscrollcommand=self.scrollbar.set, state=DISABLED)

        self.transmit_box.pack()

        self.scrollbar.config(command=self.receive_box.yview)

        self.send_button.pack(side=RIGHT, padx=5, pady=5)

    def process_serial_input(self):
        while self.monitor.available():
            try:
                self.receive_box.config(state=NORMAL)
                self.receive_box.insert('end', self.monitor.queue.get())
                self.receive_box.config(state=DISABLED)

            except Queue.Empty:
                pass
        self.after(100, self.process_serial_input)

    def send_message(self):
        message = self.transmit_box.get(1.0, 'end')
        self.monitor.write(message)
