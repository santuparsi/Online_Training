using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnStoredProceduresUsingDTOs.Models;
using HandsOnStoredProceduresUsingDTOs.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace HandsOnStoredProceduresUsingDTOs.Repositories
{
    public class TblExculsionRepository
    {
        DiscountPricingContext _context;
        public TblExculsionRepository()
        {
            _context = new DiscountPricingContext();
        }
        public void AddTblExclusions(TblExculsionsDTO item)
        {
            _context.Database.ExecuteSqlRaw("prcInsExclusions @strDrugNDC,@strContractCode", new[] {
                new SqlParameter("@strDrugNDC",item.StrDrugNdc),
                new SqlParameter("@strContractCode",item.StrContractCode)
            });
        }
        public void UpdatetblExclusions(TblExculsionsDTO item)
        {
            _context.Database.ExecuteSqlRaw("prcUpdExclusions @strDrugNDC,@strContractCode", new[] {
                new SqlParameter("@strDrugNDC",item.StrDrugNdc),
                new SqlParameter("@strContractCode",item.StrContractCode)
            });
        }
        public void DeletetblExclusions(TblExculsionsDTO item)
        {
            _context.Database.ExecuteSqlRaw("prcDelExclusions @strDrugNDC,@strContractCode", new[] {
                new SqlParameter("@strDrugNDC",item.StrDrugNdc),
                new SqlParameter("@strContractCode",item.StrContractCode)
            });
        }
        public List<TblExclusions> GetExclusions(string CCode)
        {
            return _context.TblExclusions.FromSqlRaw("prcSelExclusions @strContractCode", new[] {
                new SqlParameter("@strContractCode",CCode)
            }).ToList();
        }

    }
}
