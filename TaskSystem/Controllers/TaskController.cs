using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskSystem.Models;
using TaskSystem.Repository;
using TaskSystem.Models.DAL;

namespace TaskSystem.Controllers
{
    public class TaskController : Controller
    {
        ITaskRepository _taskrepository;
        IUserRepository _userrepository;

        public TaskController(ITaskRepository taskrepository,IUserRepository userrepository)
        {
            _taskrepository = taskrepository;
            _userrepository = userrepository;
        }
        
        [CustomAuthorizeAttribute]
        public ActionResult Index()
        {
            var model = _taskrepository.All().ToList();
            ViewBag.LoginName = (Session["User"] as User).Name;
            ViewBag.IsAdmin = (Session["User"] as User).IsAdmin;
            return View(model);
        }

        [CustomAuthorizeAttribute]
        [HttpPost]
        public JsonResult Add(Task t)
        {
            string ownerName = Request.Params["Owner"];
            User user = _userrepository.FindUserByName(ownerName);
            if (user != null && !string.IsNullOrEmpty(t.TaskName) && !string.IsNullOrEmpty(t.Description) && !string.IsNullOrEmpty(t.Time))
            {
                t.Owner_Id = user.Id;
                t.Time += " Hour";
                _taskrepository.InsertOrUpdate(t);
                _taskrepository.Save();
                return Json(new {Id=_taskrepository.GetLastTaskId(),Icon=user.IconUrl});
            }
            else
            {
                return null;
            }
        }

        [CustomAuthorizeAttribute]
        [HttpPost]
        public JsonResult Update(Task t)
        {
            string ownerName = Request.Params["Owner"];
            User user = _userrepository.FindUserByName(ownerName);
            if (user != null && !string.IsNullOrEmpty(t.TaskName) && !string.IsNullOrEmpty(t.Description) && !string.IsNullOrEmpty(t.Time))
            {
                t.Owner_Id = user.Id;
                t.Time += " Hour";
                _taskrepository.InsertOrUpdate(t);
                _taskrepository.Save();
                return Json(new { Icon = user.IconUrl});
            }
            else
            {
                return null;
            }
        }

        [CustomAuthorizeAttribute]
        public string Delete(int taskid)
        {
            _taskrepository.Delete(taskid);
            _taskrepository.Save();
            return "true";
        }

    }
}
