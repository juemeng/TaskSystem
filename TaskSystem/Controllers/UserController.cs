﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using TaskSystem.Models;
using TaskSystem.Models.DAL;
using TaskSystem.Repository;

namespace TaskSystem.Controllers
{
    public class UserController : Controller
    {
        IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Login()
        {
            return View();
        }

        //登陆验证
        [HttpPost]
        public ActionResult Login(User u)
        {
            var user = _repository.AuthenticUser(u.Name, u.PassWord);
            if (user == null)
            {
                ViewBag.ErrorMessage = "用户名或密码错误，请检查！";
                return View();
            }
            else
            {
                Session["User"] = user;
                return RedirectToAction("Index", "Task");
            }
        }

        //显示用户列表
        [AdminAuthorize]
        public ActionResult ShowUser()
        {
            ViewBag.LoginName = (Session["User"] as User).Name;
            var model = _repository.All();
            return View(model);
        }

        //获取用户名称列表
        [HttpPost]
        public JsonResult UserNameList()
        {
            var userNames = _repository.GetNames();
            return Json(userNames);
        }

        //删除
        public string Delete(int id)
        {
            var user = _repository.Find(id);
            string path = Server.MapPath(user.IconUrl);
            System.IO.File.Delete(path);
            _repository.Delete(id);
            _repository.Save();
            return "true";
        }

        //登出
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login");
        }

        //添加或修改
        [HttpPost]
        public string InsertOrUpdate(User user)
        {
            int id = 0;
            if (!string.IsNullOrEmpty(user.Name) && !string.IsNullOrEmpty(user.PassWord) && !string.IsNullOrEmpty(user.Email))
            {
                 Session["AddUser"] = user;
                 return "true";
            }
            else
            {
                if (Session["AddUser"] != null && Request.Files.AllKeys.Contains("photo"))
                {
                    var adduser = Session["AddUser"] as User;
                    var photo = Request.Files["photo"];
                    var path = Server.MapPath("~/content/UserIcon");
                    var photourl = adduser.Name + Path.GetExtension(photo.FileName);
                    photo.SaveAs(path + @"\" + photourl);
                    adduser.IconUrl = "/content/UserIcon/" + photourl;
                    if (adduser.Id == default(int) && _repository.FindUserByName(adduser.Name) != null)
                    {
                        return "false";
                    }
                    _repository.InsertOrUpdate(adduser);
                    _repository.Save();
                    if (adduser.Id == default(int))
                    {
                        id = _repository.GetLastUserId();
                    }
                    else
                    {
                        id = adduser.Id;
                    }
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    return js.Serialize(new { Icon = "/content/UserIcon/" + photourl, Id = id });
                }
                return "false";
            }
        }

    }
}
