using CommunityToolkit.Mvvm.ComponentModel;
using EduCube.Models;
using EduCube.Services;
using EduCube.Views.AddUpdateViews;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCube.ViewModels
{
    public partial class SubjectViewModel : ObservableObject
    {
        public ObservableCollection<SubjectModel> Subjects { get; set; } = new ObservableCollection<SubjectModel>();

        //readonly from interface get variable
        private readonly ISubjectService _subjectService;

        public SubjectViewModel(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }





        [ICommand]
        public async void GetSubjectList()
        {
     //       var subjectList = await _subjectService.GetSubjectList();
     //       if(subjectList?.Count > 0)
     //       {
     //           Subjects.Clear();
     //           foreach (var subject in subjectList)
      //          {
      //              Subjects.Add(subject);  
      //          }
      //      }
        }



        //ICommand for buttons to run task
        [ICommand]
        public async void AddUpdateSubject()
        {
            //navigate to AddUpdate page for subjects
            await AppShell.Current.GoToAsync(nameof(AddUpdateSubjectPage));
        }



    }
}
