using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        UdpClient udpClient = new UdpClient();
        IPAddress serverIP = IPAddress.Parse("127.0.0.1");
        int serverPort = 5155;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxCommand.Text == "" || textBoxParams.Text == "")
            {
                labelError.Text = "Не всі поля заповнені!";
            }
            else if (textBoxCommand.Text == "get time")
            {
                string command = textBoxCommand.Text;
                string parameters = textBoxParams.Text + " " + DateTime.Now;
                string message = command + "|" + parameters;
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, new IPEndPoint(serverIP, serverPort));
                textBoxSend.AppendText(command + Environment.NewLine + parameters + Environment.NewLine);
                textBoxCommand.Text = "";
                textBoxParams.Text = "";
                labelError.Text = "";
            }
            else
            {
                string command = textBoxCommand.Text;
                string parameters = textBoxParams.Text;
                string message = command + "|" + parameters;
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, new IPEndPoint(serverIP, serverPort));
                textBoxSend.AppendText(command + Environment.NewLine + parameters + Environment.NewLine);
                textBoxCommand.Text = "";
                textBoxParams.Text = "";
                labelError.Text = "";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            udpClient.Close();
        }
    }
}