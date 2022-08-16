using EduCube.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCube.Services
{
    internal class SubjectRepository : ISubjectService
    {
        //Make database connection
        private SQLiteAsyncConnection _dbConnection;

        //constructor setup db connection // connect
    //    public SubjectRepository()
    //    {
     //       SetUpDb();
      //  }

        //setup db connection
        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "educubeDatabase.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<SubjectModel>();
            }
        }

        //Add new subject 
        public Task<int> AddSubject(SubjectModel subjectModel)
        {
            return _dbConnection.InsertAsync(subjectModel);
        }

        //Add delete subject 
        public Task<int> DeleteSubject(SubjectModel subjectModel)
        {
            return _dbConnection.DeleteAsync(subjectModel);
        }

        //Get all subjects
        public Task<List<SubjectModel>> GetSubjectList()
        {
            var subjectList = _dbConnection.Table<SubjectModel>().ToListAsync();
            return subjectList;
        }

        //Update Subject
        public Task<int> UpdateSubject(SubjectModel subjectModel)
        {
            return _dbConnection.UpdateAsync(subjectModel);
        }



    }
}
