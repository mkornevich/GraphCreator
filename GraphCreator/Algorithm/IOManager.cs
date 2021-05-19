using System.Threading;
using System.Windows.Threading;

namespace GraphCreator.Algorithm
{
    public class IOManager
    {
        public delegate void SendCommandHandler(Command command, object[] data);

        public event SendCommandHandler SendCommand;

        Dispatcher dispatcher;

        AutoResetEvent blockHandler = new AutoResetEvent(false);

        public Command CurrentCommand { get; private set; } = Command.None;
        
        public enum Command
        {
            Read,
            Write,
            None,
        }

        public IOManager(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        object[] resultData;
        public void SendCommandResultBack(Command command, object[] data = null)
        {
            if (command != CurrentCommand) return;
            CurrentCommand = Command.None;
            resultData = data;
            blockHandler.Set();
        }

        private object[] SendCommandAndWait(Command command, object[] data = null)
        {
            CurrentCommand = command;
            dispatcher.Invoke(() => SendCommand?.Invoke(command, data));
            blockHandler.WaitOne();
            return resultData;
        }

        public string Read(string append = "", string prepend = "")
        {
            return (string)SendCommandAndWait(Command.Read, new object[] { prepend, append })[0];
        }

        public void Write(string text)
        {
            SendCommandAndWait(Command.Write, new object[] { text });
        }
    }
}
