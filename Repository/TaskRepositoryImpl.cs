using Protofolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Repository
{
    public class TaskRepositoryImpl : TaskRepository
    {
        public Task CreateTask(Task task)
        {
            Task theTask = new Task();
            theTask.Id = 101;
            theTask.Description = "Lear angular";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "Completed";
            theTask.AssignedBy = "sai";
            return theTask;

           
        }

        public List<Task> GetAllTasks()
        {
            List<Task> listTask = new List<Task>();
            Task theTask = new Task();
            theTask.Id = 102;
            theTask.Description = "Lear angular";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "Completed";
            theTask.AssignedBy = "sai";
            listTask.Add(theTask);

            Task theTask1 = new Task();
            theTask1.Id = 102;
            theTask1.Description = "Lear Microservices";
            theTask1.StartDate = new DateTime();
            theTask1.EndDate = new DateTime();
            theTask1.Status = "Completed";
            theTask1.AssignedBy = "raj";
            listTask.Add(theTask1);

            return listTask;

        }

        public Task GetTaskById(int id)
        {
            Task theTask = new Task();
            theTask.Id = 101;
            theTask.Description = "Lear angular";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "Completed";
            theTask.AssignedBy = "sai";

            return theTask;
        }

        public int taskCount()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task task, int id)
        {
            throw new NotImplementedException();
        }

       public string DeleteTask(int id)
        {
            return "Deleted Successfully";
        }
    }
}