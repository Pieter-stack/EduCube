using CommunityToolkit.Mvvm.ComponentModel;
using EduCube.Services;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCube.ViewModels.AddUpdateViewModels
{

    public partial class AddUpdateSubjectViewModel : ObservableObject
    {
        //readonly from interface get variable
        private readonly ISubjectService _subjectService;

        //get ViewModel
        public AddUpdateSubjectViewModel(ISubjectService subjectService)
        {
            _subjectService = subjectService;       
        }

        //Make observable stings and ints for variables 
        [ObservableProperty]
        private string _subjectTitle;

        [ObservableProperty]
        private string _subjectCode;

        [ObservableProperty]
        private string _subjectLecturer;

        [ObservableProperty]
        private string _subjectDescription;

        [ObservableProperty]
        private int _subjectCredits;

        [ObservableProperty]
        private int _subjectPrice;

        [ObservableProperty]
        private string _subjectDate;

        [ObservableProperty]
        private string _subjectTime;

        [ObservableProperty]
        private string _subjectImage;

        [ObservableProperty]
        private string _subjectHours;

        [ObservableProperty]
        private string _subjectVenue;




        //add and update command for button
        [ICommand]
        public async void AddUpdateSubject()
        {
            var response = await _subjectService.AddSubject(new Models.SubjectModel
            {
                //set variables 
                SubjectTitle = SubjectTitle,
                SubjectCode = SubjectCode,
                SubjectLecturer = SubjectLecturer,
                SubjectDescription = SubjectDescription,
                SubjectCredits = SubjectCredits,
                SubjectPrice = SubjectPrice,
                SubjectDate = SubjectDate,
                SubjectTime = SubjectTime,
                SubjectImage = SubjectImage,
                SubjectHours = SubjectHours,
                SubjectVenue = SubjectVenue
            });

            if(response > 0)
            {
                //has added no error
                await Shell.Current.DisplayAlert("Subject added", "Subject added to Subject List", "OK");
            }
            else
            {
                //error occured
                await Shell.Current.DisplayAlert("Not Added", "Something went wrong while adding record", "OK");
            }




        }


    }
}
