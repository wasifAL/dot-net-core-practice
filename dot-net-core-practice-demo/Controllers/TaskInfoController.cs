using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using dot_net_core_practice_demo.Service;
using dot_net_core_practice_demo.Models;

namespace dot_net_core_practice_demo.Controllers
{
    [ApiController]
    [Route("taskinfo")]
    public class TaskInfoController : ControllerBase
    {
        private readonly ITaskInfoService _taskService;
        public TaskInfoController(ITaskInfoService taskInfoService)
        {
            _taskService = taskInfoService;
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveTask(TaskInfo taskinfo)
        {
            if (ModelState.IsValid)
            {
                taskinfo.TaskId = Guid.NewGuid();
                _taskService.AddTask(taskinfo);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult UpdateTask(TaskInfo taskinfo)
        {
            if (ModelState.IsValid)
            {
                //taskinfo.TaskId = Guid.NewGuid();
                _taskService.UpdateTask(taskinfo);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetTask()
        {
            try
            {
                var tasks = _taskService.GetTask();
                if (tasks == null) return NotFound();
                return Ok(tasks);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetTaskbyID(Guid id)
        {
            try
            {
                var tasks = _taskService.GetTaskbyId(id);
                if (tasks == null) return NotFound();
                return Ok(tasks);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
        

       
   
   
