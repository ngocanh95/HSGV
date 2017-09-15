using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class MONHOCF
    {
        private HSGVDbContext context;
        public MONHOCF()
        {
            context = new HSGVDbContext();
        }
        public IQueryable<tblMON> tblMONs
        {
            get { return context.tblMONs; }
        }

        public tblMON FindEntity(string id)
        {
            tblMON result = context.tblMONs.Find(id);
            return result;
        }

        public bool Insert(tblMON model)
        {
            tblMON result = context.tblMONs.Find(model.MaMon);
            if (result != null) return false;
            context.tblMONs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblMON model)
        {
            tblMON re = context.tblMONs.Find(model.MaMon);
            if (re == null) return false;
            re.MaMon = model.MaMon;
            re.MaKhoa = model.MaKhoa;
            re.SoDVHT = model.SoDVHT;
            re.HocKi = model.HocKi;
            re.TenMon = model.TenMon;
            context.SaveChanges();
            return true;
        }

        public bool Delete(tblMON model)
        {
            tblMON re = context.tblMONs.Find(model.MaMon);
            if (re == null) return false;
            context.tblMONs.Remove(re);
            context.SaveChanges();
            return true;
        }
    }
}
