using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ChipGroup_GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var viewModel = (BindingContext as ViewModel);
            viewModel.SelectedItems.Add(viewModel.Languages[2]);
        }
    }
}
