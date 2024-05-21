using Project_63134214.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63134214.Controllers
{
    public class NhanVien_63134214Controller : Controller
    {
        // GET: NhanVien_63134214
        public ActionResult Index(int? page, string strSearch)
        {
            var listNhanVien = new Model_63134214().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien_63134214/Details/5
        public ActionResult Permission(int id)
        {
            var context = new Model_63134214();
            var editing = context.NhanViens.Find(id);
            return View(editing);
        }
        // POST: Permission/Edit/5
        [HttpPost]
        public ActionResult Permission(NhanVien model)
        {
            try
            {
                // TODO: Add update permission logic here
                var context = new Model_63134214();
                var oldItem = context.NhanViens.Find(model.Id);
                oldItem.MatKhau = model.MatKhau;
                oldItem.QuanTri = model.QuanTri;
                oldItem.ChuyenVien = model.ChuyenVien;
                oldItem.NhanVien1 = model.NhanVien1;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: NhanVien_63134214/Create
        public ActionResult Create()
        {
            var context = new Model_63134214();
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu=chucVuSelect;
            return View();
        }

        // POST: NhanVien_63134214/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new Model_63134214();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien_63134214/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new Model_63134214();
            var editing = context.NhanViens.Find(id);
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu",editing.IdChucVu);
            ViewBag.IdChucVu = chucVuSelect;
            return View(editing);
        }

        // POST: NhanVien_63134214/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new Model_63134214();
                var oldItem = context.NhanViens.Find(model.Id);
                oldItem.HoTen = model.HoTen;
                oldItem.GioiTinh= model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.CCCD = model.CCCD;
                oldItem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien_63134214/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new Model_63134214();
            var deleting = context.NhanViens.Find(id);
            
            return View(deleting);
        }

        // POST: NhanVien_63134214/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new Model_63134214();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: NhanVien_63134214/AboutMe
        public ActionResult AboutMe()
        {
            return View();
        }

    }
}
