using dot_net_core_practice_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_net_core_practice_demo.Service
{
    public class TaskInfoService : ITaskInfoService
    {
        private TaskInfoDbContext _context;
        public TaskInfoService(TaskInfoDbContext context)
        {
            _context = context;

        }
        public void AddTask(TaskInfo task)
        {
            _context.Add(task);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<TaskInfo> GetTask()
        {
            List<TaskInfo> taskList;
            try
            {
                taskList = _context.Set<TaskInfo>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return taskList;
        }

        public TaskInfo GetTaskbyId(Guid taskId)
        {
            TaskInfo task;
            try
            {
                task = _context.Find<TaskInfo>(taskId);
            }
            catch (Exception)
            {
                throw;
            }
            return task;
        }

        public void UpdateTask(TaskInfo task)
        {
          //  TaskInfo _temp = GetTaskbyId(task.TaskId);
            _context.Update(task);
            _context.SaveChanges();
        }
    }
}
