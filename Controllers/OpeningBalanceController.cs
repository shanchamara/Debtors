using AuditSystem.Context;
using AuditSystem.Helps;
using AuditSystem.Models;
using AuditSystem.Services;
using System;
using System.Web.Mvc;

namespace AuditSystem.Controllers
{
    public class OpeningBalanceController : Controller
    {
        readonly OpeningBalanceServices _ClientService = new OpeningBalanceServices();
        readonly CustomerServices _ClientService2 = new CustomerServices();

        [HttpGet]
        public ActionResult Index()
        {
            var dt = _ClientService.GetAll();
            return View(dt);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new OpeningBalanceModel() { CustomerLists = new SelectList(_ClientService2.GetAll(), "Id", "Name"), };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(OpeningBalanceModel masterModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblOpeningBalance tbl = new TblOpeningBalance();
                    {
                        tbl.Narration = masterModel.Narration;
                        tbl.Fk_CustomerId = masterModel.Fk_CustomerId;
                        tbl.Create_By = "User";
                        tbl.SalesRep = masterModel.SalesRep;
                        tbl.Amount = masterModel.Amount;
                        tbl.Date = masterModel.Date;
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
            var model = new OpeningBalanceModel()
            {
                Id = dt.Id,
                Fk_CustomerId = dt.Fk_CustomerId,
                Amount = dt.Amount,
                Narration = dt.Narration,
                Date = dt.Date,
                CustomerLists = new SelectList(_ClientService2.GetAll(), "Id", "Name"),
                SalesRep = dt.SalesRep
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(OpeningBalanceModel masterModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TblOpeningBalance tbl = new TblOpeningBalance();
                    {
                        tbl.Narration = masterModel.Narration;
                        tbl.Fk_CustomerId = masterModel.Fk_CustomerId;
                        tbl.Edit_By = "User";
                        tbl.Id = masterModel.Id;
                        tbl.Amount = masterModel.Amount;
                        tbl.Date = masterModel.Date;
                        tbl.SalesRep = masterModel.SalesRep;
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
                TblOpeningBalance tbl = new TblOpeningBalance();
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