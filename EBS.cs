using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GoogleAlertBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var options = new FirefoxOptions();
            options.AddArguments("-profile=" + textBox2.Text);

            FirefoxDriver drv = new FirefoxDriver(options);

            drv.Navigate().GoToUrl("https://www.ebubekirbastama.com");
            //Bi Teşekkür edersiniz :) :)

        }

    }
}
