using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class KHOAF
    {
        private HSGVDbContext context;

        public KHOAF()
        {
            context = new HSGVDbContext();
        }
        public IQueryable<tblKHOA> tblKHOAs
        {
            get { return context.tblKHOAs; }
        }


        public tblKHOA FindEntity(string ID)
        {
            tblKHOA dbEntry = context.tblKHOAs.Find(ID);
            return dbEntry;

        }

        public bool Insert(tblKHOA model)
        {
            tblKHOA dbEntry = context.tblKHOAs.Find(model.MaKhoa);
            if (dbEntry != null) return false;
            context.tblKHOAs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblKHOA model)
        {
            tblKHOA dbEntry = context.tblKHOAs.Find(model.MaKhoa);
            if (dbEntry == null) return false;
            dbEntry.MaKhoa = model.MaKhoa;
            dbEntry.TenKhoa = model.TenKhoa;


            context.SaveChanges();
            return true;
        }

        public bool Delete(tblKHOA model)
        {
            tblKHOA dbEntry = context.tblKHOAs.Find(model.MaKhoa);
            if (dbEntry == null) return false;
            context.tblKHOAs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}
