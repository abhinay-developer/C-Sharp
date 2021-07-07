using Protofolio.Models;
using Protofolio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Service
{
    public class TaskService
    {
        private TaskRepository taskRepo;
       
        
        public TaskService()
        {
             taskRepo = new TaskRepositoryImpl();

        }

        public Task createTask(Task task)
        {
            return taskRepo.CreateTask(task);
        }
    }
}