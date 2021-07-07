using Protofolio.Models;
using Protofolio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Protofolio.Controllers
{
    public class TaskController : ApiController
    {
        [HttpPost]
        [Route("api/task/insert")]
        public Task insertTask(Task task)
        {
            TaskService taskService = new TaskService();
            return taskService.createTask(task);
        }

    }
}
