using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class LOPF
    {
        private HSGVDbContext context;

        public LOPF()
        {
            context = new HSGVDbContext();
        }
        public IQueryable<tblLOP> tblLOPs
        {
            get { return context.tblLOPs; }
        }
        
        public tblLOP FindEntity(string ID)
        {
            tblLOP dbEntry = context.tblLOPs.Find(ID);
            return dbEntry;

        }

        public bool Insert(tblLOP model)
        {
            tblLOP dbEntry = context.tblLOPs.Find(model.MaLop);
            if (dbEntry != null) return false;
            context.tblLOPs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblLOP model)
        {
            tblLOP dbEntry = context.tblLOPs.Find(model.MaLop);
            if (dbEntry == null) return false;
            dbEntry.MaLop = model.MaLop;
            dbEntry.TenLop = model.TenLop;

            dbEntry.MaKhoa = model.MaKhoa;
            
            context.SaveChanges();
            return true;
        }

        public bool Delete(tblLOP model)
        {
            tblLOP dbEntry = context.tblLOPs.Find(model.MaLop);
            if (dbEntry == null) return false;
            context.tblLOPs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}
