using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.Repos;
using MenuProject.ViewModels.Base;
using StudentProject.Models;
using System.Collections.ObjectModel;

namespace MenuProject.ViewModels
{
    public partial class StudentViewModel : BaseViewModel
    {
        private readonly EducationLevelsRepo _educationLevelsRepo = new();
        private readonly StudentRepo _studentRepo = new();

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new();

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();

        [ObservableProperty]
        private Student _selectedStudent;        
        
        public StudentViewModel()
        {
            _selectedStudent = new Student();
            Update();
        }

        [RelayCommand]
        public void DoSave(Student student)
        {
            if (student.HasId)
                _studentRepo.Update(student);
            else
                _studentRepo.Insert(student);
            Update();
        }

        [RelayCommand]
        void DoNewStudent()
        {
            SelectedStudent = new Student();
        }

        [RelayCommand]
        public void DoRemove(Student studentToDelete)
        {
            _studentRepo.Delete(studentToDelete);
            Update();
        }

        private void Update()
        {
            EducationLevels = new ObservableCollection<string>(_educationLevelsRepo.FindAll());
            Students = new ObservableCollection<Student>(_studentRepo.FindAll());
        }
    }
}
