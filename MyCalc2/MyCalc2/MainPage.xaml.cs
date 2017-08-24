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
            //int i = int.Parse(InputTextBox.Text);
            //OutputBox.Text = Convert.ToString(i);
            int selectedIndexOrg = OriginComboBox.SelectedIndex;
            int selectedIndexTarg = TargetComboBox.SelectedIndex;
            var selectedCountryOrg = OriginComboBox.SelectedItem;
            var selectedCountryTrag = TargetComboBox.SelectedItem;

            // OutputBox.Text = string.Concat(Convert.ToString(selectedIndexOrg) , Convert.ToString(selectedIndexTarg) , Convert.ToString(selectedCountryOrg) , Convert.ToString(selectedCountryTrag));
            ratesCombo.SelectedIndex = selectedIndexTarg;
            OutputBox.Text = Convert.ToString(ratesCombo.SelectedItem);
            if 
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            string[] currancyArray = new string[6];
            currancyArray[0] = "Dollar";
            currancyArray[1] = "Euro";
            currancyArray[2] = "Yen";
            currancyArray[3] = "Peso";
            currancyArray[4] = "Rupee";
            currancyArray[5] = "BitCoin";


            for (int i = 0; i < 6; i++)
            {
                OriginComboBox.Items.Add(currancyArray[i]);
            }

            for (int i = 0; i < 6; i++)
            {
                TargetComboBox.Items.Add(currancyArray[i]);
            }

            double[] exchangeRate = new double[6];
            exchangeRate[0] = 1;
            exchangeRate[1] = 0.8514;
            exchangeRate[2] = 109.2040;
            exchangeRate[3] = 17.7920;
            exchangeRate[4] = 64.1000;
            exchangeRate[5] = 0.0002;

            for (int i = 0; i < 6; i++)
            {
                ratesCombo.Items.Add(exchangeRate[i]);
            }
        }

        private void ratesCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBoxItem;
            var selectedItem = TargetComboBox.SelectedItem;

        }

        private void TargetComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

