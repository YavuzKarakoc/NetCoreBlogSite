

using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBlog.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="ALi"
                },
                new UserComment
                {
                    ID = 2,
                    UserName="Ayşe"
                },
                new UserComment
                {
                    ID = 3,
                    UserName="Mahmut"
                }
            };
            return View(commentvalues);
        }
    }
}
