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
    internal class AdminRepository
    {

        string _dbPath; // this property -> our db file

        private SQLiteConnection conn;


        //initializes our db connection each time
        private void Init()
        {
            //connect to db

            if (conn != null)//if already connected don't do again
                return;

            //connecting to db file
            conn = new SQLiteConnection(_dbPath);
            // Create table if not already existed
            conn.CreateTable<AdminModel>();

        }

        //constructor to set our properties
        public AdminRepository(string dbPath)
        {
            _dbPath = dbPath;
        }


        // CRUD

        //Create
        //Create a new user
        public void CreateNewUser(AdminModel person)
        {
            try
            {
                Init();//first connect to file
                conn.Insert(person);//insert person as row
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //Read
        //Get all users from db
        public List<AdminModel> GetAllUsers()
        {
            try
            {
                Init();//first connect 
                return conn.Table<AdminModel>().ToList(); //get all users
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return new List<AdminModel>();
        }


        //Update
        //not yet implemented


        //Delete
        //remove user from db
        public void DeleteUser(int id)
        {
            try
            {
                conn.Delete<AdminModel>(id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
