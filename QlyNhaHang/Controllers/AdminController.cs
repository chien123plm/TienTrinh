using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QlyNhaHang.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult QuanLi()
        {
            return View();
        }

        public ActionResult QuanLiDatBan() { return View(); }
        public ActionResult QuanLiKho() { return View(); }
        public ActionResult QuanLiNhanVien() { return View(); }
        public ActionResult QuanLiCaLam() { return View(); }
    }
}