﻿using AuditSystem.Context;
using AuditSystem.Helps;
using AuditSystem.Models;
using AuditSystem.Services;
using System;
using System.Web.Mvc;

namespace AuditSystem.Controllers
{
    public class NatureMasterController : Controller
    {
        readonly NatureMasterServices _ClientService = new NatureMasterServices();

        [HttpGet]
        public ActionResult Index()
        {
            var dt = _ClientService.GetAll();
            return View(dt);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(NatureMasterModel masterModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblNatureMaster tbl = new TblNatureMaster();
                    {
                        tbl.Narration = masterModel.Narration;
                        tbl.Code = masterModel.Code;
                        tbl.Create_By = "User";
                        tbl.IsActive = masterModel.IsActive;
                        tbl.Create_Date = new CommonResources().LocalDatetime().Date;
                    };

                    return Json(_ClientService.Insert(tbl));
                }
            }
            catch (Exception)
            {
                return Json(new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                });
            }
            return Json(new MessageModel()
            {
                Status = "warning",
                Text = $"There was a error with retrieving data. Please try again",
            });
        }


        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var dt = _ClientService.GetById(Id);
            var model = new NatureMasterModel()
            {
                Id = dt.Id,
                Code = dt.Code,
                IsActive = dt.IsActive,
                Narration = dt.Narration
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(NatureMasterModel masterModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblNatureMaster tbl = new TblNatureMaster();
                    {
                        tbl.Narration = masterModel.Narration;
                        tbl.Code = masterModel.Code;
                        tbl.Edit_By = "User";
                        tbl.Id = masterModel.Id;
                        tbl.IsActive = masterModel.IsActive;
                    };

                    return Json(_ClientService.Update(tbl));
                }
            }
            catch (Exception)
            {
                return Json(new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                });
            }
            return Json(new MessageModel()
            {
                Status = "warning",
                Text = $"There was a error with retrieving data. Please try again",
            });
        }

        [HttpDelete]
        public ActionResult Delete(int ID)
        {
            try
            {
                TblNatureMaster tbl = new TblNatureMaster();
                {
                    tbl.Id = ID;
                    tbl.Delete_By = "User";
                };
                return Json(_ClientService.Delete(tbl));
            }
            catch (Exception)
            {
                return Json(new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                });
            }

        }
    }
}