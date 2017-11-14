﻿using _07_MvcOA.IDAL;
using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public interface IUserInfoBLL : IBaseBLL<UserInfo>
    {
        bool DeleteEntities(List<int> list);
        IQueryable<UserInfo> LoadSearchEntities(UserInfoParam userInfoParam);
    }
}