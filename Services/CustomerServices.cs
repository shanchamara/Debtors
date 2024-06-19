using AuditSystem.Context;
using AuditSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuditSystem.Services
{
    public class CustomerServices
    {
        readonly AuditSystemEntities _context = new AuditSystemEntities();



        public List<CustomerModel> GetAll()
        {
            try
            {
                var dr = (from a in _context.VW_Customer
                          orderby a.Id descending
                          select new CustomerModel()
                          {
                              Id = a.Id,
                              Name = a.Name,
                          }).ToList();
                return dr;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}