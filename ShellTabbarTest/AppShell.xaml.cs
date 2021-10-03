using System;
using System.Collections.Generic;
using ShellTabbarTest.ViewModels;
using ShellTabbarTest.Views;
using Xamarin.Forms;

namespace ShellTabbarTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
