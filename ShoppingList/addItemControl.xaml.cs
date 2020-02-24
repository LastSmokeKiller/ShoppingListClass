using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for addItemControl.xaml
    /// </summary>
    public partial class addItemControl : UserControl
    {
        

        public addItemControl()
        {
            InitializeComponent();
            AddButton.Click += OnAddItemButtonClick;
        }
        protected void OnAddItemButtonClick(object sender, RoutedEventArgs args)
        {
       
        
            if(DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }

    
}
