using CommunityToolkit.Mvvm.ComponentModel;
using MVVMLiveDemo23.Models;

namespace MVVMLiveDemo23.ViewModels.Locator;

public class ViewModelLocator
{
    public ObservableObject DemoViewModel { get; set; } = new DemoViewModel(new DemoModel());
    public ObservableObject PeopleViewModel { get; set; } = new PeopleViewModel();
}