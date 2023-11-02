using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMLiveDemo23.Models;

namespace MVVMLiveDemo23.ViewModels;

public class PeopleViewModel : ObservableObject
{
    #region Props

    public ObservableCollection<PersonModel> PeopleList { get; set; } = new();

    private PersonModel? _selectedPerson;

    public PersonModel? SelectedPerson
    {
        get
        {
            return _selectedPerson;
        }
        set
        {
            if (_selectedPerson == value)
            {
                return;
            }

            _selectedPerson = value;
            if (value is null)
            {
                EditFirstName = string.Empty;
                EditLastName = string.Empty;
            }
            else
            {

                EditFirstName = _selectedPerson.FirstName;
                EditLastName = _selectedPerson.LastName;
            }

            UpdateSelectedPersonCommand.NotifyCanExecuteChanged();
            OnPropertyChanged();
        }
    }

    private string _editFirstName;

    public string EditFirstName
    {
        get { return _editFirstName; }
        set
        {
            _editFirstName = value;
            OnPropertyChanged();
        }
    }

    private string _editLastName;

    public string EditLastName
    {
        get { return _editLastName; }
        set
        {
            _editLastName = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Commands

    public IRelayCommand UpdateSelectedPersonCommand { get; }

    #endregion

    public PeopleViewModel()
    {
        PeopleList.Add(new PersonModel() { FirstName = "Niklas", LastName = "Hjelm" });
        PeopleList.Add(new PersonModel() { FirstName = "Angela", LastName = "Lindqvist" });

        UpdateSelectedPersonCommand = new RelayCommand(UpdateSelectedPersonCommandExecute, UpdateSelectedPersonCommandCanExecute);
    }

    private bool UpdateSelectedPersonCommandCanExecute()
    {
        return _selectedPerson is not null;
    }

    private void UpdateSelectedPersonCommandExecute()
    {
        _selectedPerson.FirstName = EditFirstName;
        _selectedPerson.LastName = EditLastName;
    }
}