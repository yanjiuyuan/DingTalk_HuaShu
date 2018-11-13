﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingTalkServer
{
    public partial class DingTalkServerAddressConfig
    {
        public string GetDepartmentListUrl { get; private set; }
        public string GetDepartmentDetailUrl { get; private set; }
        public string CreateDepartmentUrl { get; private set; }
        public string UpdateDepartmentUrl { get; private set; }
        public string DeleteDepartmentUrl { get; private set; }
        public string GetDepartmentByUserId { get; private set; }
        public string GetUserId { get; private set; }

        public string GetWorkMsgUrl { get; private set; }
    }
}