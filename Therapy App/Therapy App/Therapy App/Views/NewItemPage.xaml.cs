using System;
using System.Collections.Generic;
using System.ComponentModel;
using Therapy_App.Models;
using Therapy_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Therapy_App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}