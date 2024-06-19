﻿using AuditSystem.Context;
using AuditSystem.Helps;
using AuditSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuditSystem.Services
{
    public class LegalStatusMasterServices
    {
        readonly AuditSystemEntities _context = new AuditSystemEntities();


        public TblLegalStatusMaster GetByName(string code)
        {
            return _context.TblLegalStatusMasters.SingleOrDefault(d => d.Code.Equals(code));
        }

        public MessageModel Insert(TblLegalStatusMaster obj)
        {

            try
            {
                var data = GetByName(obj.Code);
                if (data == null)
                {
                    _context.TblLegalStatusMasters.Add(obj);
                    _context.SaveChanges();

                    return new MessageModel()
                    {
                        Status = "success",
                        Text = $"This Record has been registered",
                    };
                }
                else
                {
                    return new MessageModel()
                    {
                        Status = "warning",
                        Text = $"This Record has been already registered",
                    };
                }
            }
            catch (Exception)
            {
                return new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                };
            }
        }

        public TblLegalStatusMaster GetById(int Id)
        {
            return _context.TblLegalStatusMasters.SingleOrDefault(i => i.Id == Id);
        }


        public MessageModel Update(TblLegalStatusMaster obj)
        {
            try
            {
                var dbobj = GetById(obj.Id);
                dbobj.Narration = obj.Narration;
                dbobj.Code = obj.Code;
                dbobj.Edit_By = obj.Edit_By;
                dbobj.IsActive = obj.IsActive;
                dbobj.Edit_Date = new CommonResources().LocalDatetime().Date;

                _context.SaveChanges();

                return new MessageModel()
                {
                    Status = "success",
                    Text = $"This Record has been Updated",
                };
            }
            catch (Exception)
            {
                return new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                };
            }
        }

        public MessageModel Delete(TblLegalStatusMaster obj)
        {
            try
            {
                var dbobj = GetById(obj.Id);
                dbobj.IsDelete = true;
                dbobj.Delete_By = obj.Delete_By;
                dbobj.Edit_Date = new CommonResources().LocalDatetime().Date;

                _context.SaveChanges();
                return new MessageModel()
                {
                    Status = "success",
                    Text = $"This Record have been deleted Successfully",
                };
            }
            catch (Exception)
            {
                return new MessageModel()
                {
                    Status = "warning",
                    Text = $"There was a error with retrieving data. Please try again",
                };
            }


        }

        public List<LegalStatusMasterModel> GetAll()
        {
            try
            {
                var dr = (from a in _context.VW_LegalStatusMaster
                          orderby a.Id descending
                          select new LegalStatusMasterModel()
                          {
                              Id = a.Id,
                              Code = a.Code,
                              Narration = a.Narration,
                              IsActive = a.IsActive,
                              IsDelete = a.IsDelete,
                          }).Where(d => d.IsDelete.Equals(false)).ToList();
                return dr;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}