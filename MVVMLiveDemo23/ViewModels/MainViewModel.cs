using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMLiveDemo23.ViewModels;

public class MainViewModel
{
    public ObservableObject DemoViewModel { get; }
    public ObservableObject PeopleViewModel { get; }

    public MainViewModel(ObservableObject demoViewModel, ObservableObject peopleViewModel)
    {
        DemoViewModel = demoViewModel;
        PeopleViewModel = peopleViewModel;
    }
}