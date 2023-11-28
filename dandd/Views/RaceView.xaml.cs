using dandd.ViewModels;
using dandd.Models;
using dandd.Views;

namespace dandd.Views;

public partial class RaceView : ContentPage
{
	public RaceView()
	{
		InitializeComponent();
        BindingContext = new PostViewModel();
    }
}

