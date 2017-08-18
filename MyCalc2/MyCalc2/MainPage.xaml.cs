using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyCalc2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            string[] currancyArray = new string[5];
            currancyArray[0] = "Dollar";
            currancyArray[1] = "Euro";
            currancyArray[2] = "Yen";
            currancyArray[3] = "Peso";
            currancyArray[4] = "Rupee";
            currancyArray[5] = "BitCoin";
            
        }

        private void OriginComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(InputTextBox.Text);    
            OutputBox.Text = Convert.ToString(i);
        }
    }
}
