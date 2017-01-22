﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public ClientSettings Client { get; set; }

        public LoginForm()
        {
            Client = new ClientSettings();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client.Connected += Client_Connected;
            Client.Connect(txtIP.Text, 2014);
            Client.Send("Connect|" + txtNickname.Text + "|connected");
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            this.Invoke(Close);
        }


    }
}
