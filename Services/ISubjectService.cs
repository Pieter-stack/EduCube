using EduCube.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCube.Services
{
    public interface ISubjectService
    {
        //Get all Subjects
        Task<List<SubjectModel>> GetSubjectList();

        //Add new Subject
        Task<int> AddSubject(SubjectModel subjectModel);

        //Delete Subject
        Task<int> DeleteSubject(SubjectModel subjectModel);

        //Update Subject
        Task<int> UpdateSubject(SubjectModel subjectModel);

    }
}
