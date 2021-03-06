﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace URGE
{
    public partial class Enter_PIN : Form
    {
        public Enter_PIN()
        {

        }

        public Enter_PIN(string authurl)
        {
            InitializeComponent();
            webTwitterAuth.Navigate(authurl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "")
            {
                MessageBox.Show("PIN must not be empty!");
            }
            else {
                Properties.Settings.Default.pin = txtPin.Text;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void webTwitterAuth_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.picLoadScreen.Visible = false;
        }
    }
}
