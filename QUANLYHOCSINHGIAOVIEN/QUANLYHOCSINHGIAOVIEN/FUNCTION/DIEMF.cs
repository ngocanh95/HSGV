using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class DIEMF
    {
        private HSGVDbContext context;

        public DIEMF()
        {
            context = new HSGVDbContext();
        }
        public IQueryable<tblKET_QUA> tblKET_QUAs
        {
            get { return context.tblKET_QUA; }
        }
        
        public tblKET_QUA FindEntity(string ID1, string ID2)
        {
            tblKET_QUA dbEntry = context.tblKET_QUA.Find(ID1, ID2);
            return dbEntry;

        }

        public bool Insert(tblKET_QUA model)
        {
            tblKET_QUA dbEntry = context.tblKET_QUA.Find(model.MaSV, model.MaMon);
            if (dbEntry != null) return false;
            context.tblKET_QUA.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblKET_QUA model)
        {
            tblKET_QUA dbEntry = context.tblKET_QUA.Find(model.MaSV, model.MaMon);
            if (dbEntry == null) return false;
            dbEntry.MaSV = model.MaSV;
            dbEntry.MaMon = model.MaMon;

            dbEntry.DiemTB = model.DiemTB;
            dbEntry.DiemThiLan1 = model.DiemThiLan1;
            dbEntry.DiemThiLan2 = model.DiemThiLan2;
            dbEntry.DiemTongKet = model.DiemTongKet;
            dbEntry.HanhKiem = model.HanhKiem;
            dbEntry.HocKi = model.HocKi;
            dbEntry.GhiChu = model.GhiChu;
            context.SaveChanges();
            return true;
        }

        public bool Delete(tblKET_QUA model)
        {
            tblKET_QUA dbEntry = context.tblKET_QUA.Find(model.MaSV, model.MaMon);
            if (dbEntry == null) return false;
            context.tblKET_QUA.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}
