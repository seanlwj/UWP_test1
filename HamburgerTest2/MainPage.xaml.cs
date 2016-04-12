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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace HamburgerTest2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListBoxItem.IsSelected)
            {
                FinancialTextBlock.Visibility = Visibility.Visible;
                FoodStackPanel.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Financial));
            }
            else if (FoodListBoxItem.IsSelected)
            {
                FinancialTextBlock.Visibility = Visibility.Collapsed;
                FoodStackPanel.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Food));
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            HomeListBoxItem.IsSelected = true;
        }
    }
}
