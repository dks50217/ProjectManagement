﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class ProjectResourceVM
    {
        public System.Guid ProjectGUID { get; set; }
        [DisplayName("專案名稱")]
        public string ProjectName { get; set; }
        public System.Guid TaskGUID { get; set; }
        [DisplayName("工作名稱")]
        public string TaskName { get; set; }
        public System.Guid ResourceGUID { get; set; }
        public int ResourceID { get; set; }
        [DisplayName("費用名稱")]
        public string ResourceName { get; set; }
        [DisplayName("類別編號")]
        public Nullable<int> CategoryID { get; set; }
        [DisplayName("類別名稱")]
        public string CategoryName { get; set; }
        [DisplayName("單位")]
        public string Unit { get; set; }
        [DisplayName("單價")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal UnitPrice { get; set; }
        [DisplayName("數量")]
        public int Quantity { get; set; }
        [DisplayName("費用發生日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public System.DateTime Date { get; set; }
        [DisplayName("備註")]
        public string Description { get; set; }
        [DisplayName("小計")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal SubTotal { get; set; }
    }
}