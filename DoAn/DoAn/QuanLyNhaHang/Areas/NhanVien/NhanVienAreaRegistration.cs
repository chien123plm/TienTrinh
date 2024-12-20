﻿using System.Web.Mvc;

namespace QuanLyNhaHang.Areas.NhanVien
{
    public class NhanVienAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NhanVien";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NhanVien_default",
                "NhanVien/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "QuanLyNhaHang.Areas.NhanVien.Controllers" }
            );
        }
    }
}