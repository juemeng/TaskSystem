using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TaskSystem.Models.DAL
{
    public class TaskDbInit:DropCreateDatabaseIfModelChanges<TaskSystemContext>
    {
        //用下面的数据初始化数据库
        protected override void Seed(TaskSystemContext context)
        {
            List<User> users = new List<User>
            {
                new User{Name="Jo",Email="trpg@qq.com",PassWord="123",IconUrl=@"~\Content\UserIcon\Jo"},
                new User{Name="Jack.Wang",Email="wangdeshui@shinetechchina.com",PassWord="123",IconUrl=@"~\Content\UserIcon\JackW"},
                new User{Name="Beier",Email="Beier@163.com",PassWord="123",IconUrl=@"~\Content\UserIcon\Beier"},
                new User{Name="Houde.Zuo",Email="houde@gmail.com",PassWord="123",IconUrl=@"~\Content\UserIcon\HoudeZ"},
            };

            List<Task> tasks = new List<Task>
            {
                new Task{TaskName="Changing Languages",Owner=users[0],Description="When changing languages the user should not lose the selections in the panels",Time="8 Hour"},
                new Task{TaskName="Tooltip Style",Owner=users[1],Description="All tooltips (that is additional information on mouse hover) should look the same. See previous screenshots for visual representation.",Time="4 Hour"},
            };


            users.ForEach(user => context.Users.Add(user));
            tasks.ForEach(task => context.Tasks.Add(task));
            context.SaveChanges();
        }
    }
}