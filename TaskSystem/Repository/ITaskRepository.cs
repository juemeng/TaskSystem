using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskSystem.Models;
using TaskSystem.Models.DAL;

namespace TaskSystem.Repository
{
    public interface ITaskRepository:IRepository<Task>
    {
        IQueryable GetTasksByUser(User u);
        int GetLastTaskId();
    }
}
