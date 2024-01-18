using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMLiveDemo23.Enums;
using MVVMLiveDemo23.Models;
using MVVMLiveDemo23.Services;

namespace MVVMLiveDemo23.ViewModels;

public class MainViewModel : ObservableObject
{
    private readonly DemoNavigationService _demoNavigationService;

    public ObservableObject CurrentViewModel => _demoNavigationService.CurrentViewModel;

    public IRelayCommand NavigateDemoCommand { get; }
    public IRelayCommand NavigatePeopleCommand { get; }

    public MainViewModel(DemoNavigationService demoNavigationService)
    {
        _demoNavigationService = demoNavigationService;

        NavigateDemoCommand = new RelayCommand(NavigateDemoCommandExecute);
        NavigatePeopleCommand = new RelayCommand(NavigatePeopleCommandExecute);

        _demoNavigationService.CurrentViewModelChanged += DemoNavigationServiceOnCurrentViewModelChanged;
    }

    private void NavigatePeopleCommandExecute()
    {
        _demoNavigationService.ChangeCurrentViewModel(ViewTypes.People);
    }

    private void NavigateDemoCommandExecute()
    {
        _demoNavigationService.ChangeCurrentViewModel(ViewTypes.Demo);
    }

    private void DemoNavigationServiceOnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}