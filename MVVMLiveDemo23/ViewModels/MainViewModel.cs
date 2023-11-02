using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMLiveDemo23.ViewModels;

public class MainViewModel
{
    public ObservableObject CurrentViewModel { get; }

    public MainViewModel(ObservableObject currentViewModel)
    {
        CurrentViewModel = currentViewModel;
    }
}