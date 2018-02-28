﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Avavaade
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Opetajate_nimekiri : Page
    {
        public Opetajate_nimekiri()
        {
            this.InitializeComponent();
            LaeGrupid();
        }
        public async void LaeGrupid()
        {
            var http = new HttpClient();
            var response = await http.GetAsync("https://vikk.siseveeb.ee/veebilehe_andmed/tootajad?section=ATO");
            var result = await response.Content.ReadAsStringAsync();

            var jsondata = JsonConvert.DeserializeObject<RootObject>(result);

            GroupView.ItemsSource = jsondata.employees;

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }	
    }
}
