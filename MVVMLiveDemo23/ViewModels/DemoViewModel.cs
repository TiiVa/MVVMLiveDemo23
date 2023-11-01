using MVVMLiveDemo23.Models;

namespace MVVMLiveDemo23.ViewModels;

public class DemoViewModel : ViewModelBase
{
    private readonly DemoModel _demoModel;

    public string MyText
    {
        get { return _demoModel.MyText; }
        set
        {
            _demoModel.MyText = value;
            OnPropertyChanged();
        }
    }

    public DemoViewModel(DemoModel demoModel)
    {
        _demoModel = demoModel;
    }
}