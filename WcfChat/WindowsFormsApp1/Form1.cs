using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, ServiceReference1.IChatServiceCallback
    {
        ChatServiceClient proxy;

        public Form1()
        {
            InitializeComponent();
        }

        public void Receive(ChatMessage message)
        {
            MessageBox.Show(message.Message, message.Sender);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await proxy.RegisterAsync("Én");
            await proxy.SendAsync(new ChatMessage { Sender = "Én", Target = "Én", Message = "Hello" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new ChatServiceClient(new InstanceContext(this));
        }
    }
}
