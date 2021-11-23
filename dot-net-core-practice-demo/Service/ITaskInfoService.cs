using dot_net_core_practice_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_net_core_practice_demo.Service
{
    public interface ITaskInfoService
    {
        public void AddTask(TaskInfo task);
        public void UpdateTask(TaskInfo task);
        public TaskInfo GetTaskbyId(Guid taskId);
        public List<TaskInfo> GetTask();
    }
}
