using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCCSampleSenderApplication
{
    public partial class MainForm : Form
    {
        private CommentServerClient client;

        public MainForm()
        {
            InitializeComponent();

            // 初期化
            client = new CommentServerClient();
            client.Connect();
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            client.Send(TextBox_Name.Text, TextBox_Comment.Text);

            RichTextBox_Log.Text = $"{TextBox_Name.Text} : {TextBox_Comment.Text}\n{RichTextBox_Log.Text}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
