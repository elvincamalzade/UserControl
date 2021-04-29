using Microsoft.Maps.MapControl.WPF;
using System;
using System.Configuration;
using System.Net;
using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ApplicationIdCredentialsProvider Provider { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // var appId = "PGgXDxXtbqJFb22FYOW4~V9ZWj-mMArtwhcHO7OXOyA~Amvufht9v-dLEV-Fp360l5Jk0Lwhvc8UUO9DNGeO0BMQj3ziwsNsDQADV1M-iewb";

            var appId = ConfigurationManager.AppSettings["BingToken"];
            var serverId = IPAddress.Parse(ConfigurationManager.AppSettings["ServerIp"]);
            this.DataContext = this;
            Provider = new ApplicationIdCredentialsProvider(appId);
        }
    }
}
