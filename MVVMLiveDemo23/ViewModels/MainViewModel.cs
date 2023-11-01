namespace MVVMLiveDemo23.ViewModels;

public class MainViewModel
{
    public ViewModelBase CurrentViewModel { get; }

    public MainViewModel(ViewModelBase currentViewModel)
    {
        CurrentViewModel = currentViewModel;
    }
}