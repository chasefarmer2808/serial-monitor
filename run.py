from Tkinter import Tk

from classes import App


def run_app():
    app = Tk()
    app.geometry("250x150+300+300")
    gui = App.App(app)
    app.mainloop()

if __name__ == '__main__':
    run_app()