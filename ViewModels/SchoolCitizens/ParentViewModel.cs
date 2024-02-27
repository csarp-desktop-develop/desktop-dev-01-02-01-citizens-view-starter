using CommunityToolkit.Mvvm.ComponentModel;
using MenuProject.Repos;
using MenuProject.SchoolCitizens;
using MenuProject.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MenuProject.ViewModels.SchoolCitizens
{
    public partial class ParentViewModel : BaseViewModel
    {
        private ParentRepo _parentRepo=new();

        [ObservableProperty]
        private ObservableCollection<Parent> _parents=new();

        [ObservableProperty]
        private Parent _selectedParent = new();

        public ParentViewModel()
        {
            UpdateView();
        }

        public void UpdateView()
        {
            List<Parent> parents=_parentRepo.FindAll();
            Parents=new ObservableCollection<Parent>(parents);
        }
    }
}
