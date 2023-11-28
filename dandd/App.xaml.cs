using dandd.Models;
using dandd.Models.dandd.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Input;

namespace dandd;

public partial class App : ContentPage
{
	public App(View mainPage)
    {
        InitializeComponent();
        MainPage = new View();
        MainPage = mainPage;
    }
    
}


