﻿/*
 * 版权所有:杭州火图科技有限公司
 * 地址:浙江省杭州市滨江区西兴街道阡陌路智慧E谷B幢4楼在地图中查看
 * (c) Copyright Hangzhou Hot Technology Co., Ltd.
 * Floor 4,Block B,Wisdom E Valley,Qianmo Road,Binjiang District
 * 2013-2017. All rights reserved.
 * author guomw
**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WwChatHttpCore.Objects
{
    public class WxBaseRequestModel
    {
        public string Uin { get; set; }

        public string Sid { get; set; }

        public string Skey { get; set; }

        public string DeviceID { get; set; }
    }


    public class uploadMediaRequestModel
    {

        public WxBaseRequestModel BaseRequest { get; set; }

        public string ClientMediaId { get; set; }

        public string TotalLen { get; set; }

        public string StartPos { get; set; }

        public string DataLen { get; set; }

        public int MediaType { get; set; }

        public int UploadType { get; set; }

        public string FromUserName { get; set; }

        public string ToUserName { get; set; }

        public string FileMd5 { get; set; }
    }
}