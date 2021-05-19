using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Algorithm
{
    public partial class AlgorithmForm : Form
    {
        IOManager IOManager { get; set; }

        object[] commandData;

        public AlgorithmForm(IOManager io)
        {
            InitializeComponent();
            IOManager = io;
            IOManager.SendCommand += CommandSendedHere;
        }

        private void CommandSendedHere(IOManager.Command command, object[] data)
        {
            commandData = data;
            if (command == IOManager.Command.Write)
            {
                consoleView.Text += (string)data[0];
                IOManager.SendCommandResultBack(command, null);
            }
        }

        private void inputFld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && IOManager.CurrentCommand == IOManager.Command.Read)
            {
                consoleView.Text += (string)commandData[0] + inputFld.Text + (string)commandData[1];
                IOManager.SendCommandResultBack(IOManager.Command.Read, new object[] { inputFld.Text });
                inputFld.Text = "";
            }
        }

        private void AlgorithmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void OnGraphPartSelectionChanged(string graphPartStr)
        {
            if (IOManager.CurrentCommand == IOManager.Command.Read)
            {
                consoleView.Text += (string)commandData[0] + graphPartStr + (string)commandData[1];
                IOManager.SendCommandResultBack(IOManager.Command.Read, new object[] { graphPartStr });
            }
        }

        public void OnAlgorithmOpened(BaseAlgorithm algorithm)
        {
            Text = "Алгоритм - " + algorithm.Description;
            consoleView.Clear();
        }
    }
}
