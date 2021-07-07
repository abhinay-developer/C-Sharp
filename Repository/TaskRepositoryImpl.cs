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
            throw new NotImplementedException();
        }

        public Task GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public int taskCount()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task task, int id)
        {
            throw new NotImplementedException();
        }
    }
}