using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList3
{
    /// <summary>
    /// Interaction logic for ShoppingListDisplay.xaml
    /// </summary>
    public partial class ShoppingListDisplay : UserControl
    {
        public ShoppingListDisplay()
        {
            InitializeComponent();
        }

        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is ShoppingListData data)
            {
                if (sender is Button button)
                {
                    data.Remove(button.DataContext.ToString());
                }
            }
        }
    }
}
