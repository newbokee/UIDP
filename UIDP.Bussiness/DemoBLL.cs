﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UIDP.Entity;
using UIDP.IService;
using UIDP.Model;
using UIDP.Repository;
using UIDP.Service;

namespace UIDP.Bussiness
{
    public class DemoBLL
    {
        private IDemoService demoService = new DemoService();
        public JsonResult<Demo> GetPageList(int pageIndex, int pageSize)
        {
            Expression<Func<Demo, bool>> ex = (p => 1 == 1);
            IPagedList<Demo> data = demoService.FindPagedList(ex, "", pageIndex, pageSize);
            var t = new JsonResult<Demo>
            {
                code = 200,
                message = "查询成功",
                total = data.TotalCount,
                data = data
            };
            return t;
        }
    }
}
