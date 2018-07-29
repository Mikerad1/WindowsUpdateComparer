using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsUpdateComparer
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

        private async void btnAddServerName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddServerName.Text) || string.IsNullOrWhiteSpace(txtAddServerName.Text))
                {
                    MessageDialog messageDialog = new MessageDialog("You need to type in a server name to add it to the list.", "Problem Adding Server");
                    await messageDialog.ShowAsync();
                    txtAddServerName.Text = "";
                }
                else
                {
                    lboxServerList.Items.Add(txtAddServerName.Text);
                    txtAddServerName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog($@"The following error occured: {ex.Message} ", "Problem Adding Server");
                await messageDialog.ShowAsync();
            }
           
        }
    }
}
