using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class GIANGVIENF
    {
        private HSGVDbContext context;

        public GIANGVIENF()
        {
            context = new HSGVDbContext();
        }
  
        public IQueryable<tblGIANG_VIEN> tblGIANG_VIENs
        {
            get { return context.tblGIANG_VIEN; }
        }

     

        public tblGIANG_VIEN FindEntity(string ID)
        {
            tblGIANG_VIEN dbEntry = context.tblGIANG_VIEN.Find(ID);
            return dbEntry;

        }

        public bool Insert(tblGIANG_VIEN model)
        {
            tblGIANG_VIEN dbEntry = context.tblGIANG_VIEN.Find(model.MaGV);
            if (dbEntry != null) return false;
            context.tblGIANG_VIEN.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblGIANG_VIEN model)
        {
            tblGIANG_VIEN dbEntry = context.tblGIANG_VIEN.Find(model.MaGV);
            if (dbEntry == null) return false;
            dbEntry.MaGV = model.MaGV;
            dbEntry.TenGV = model.TenGV;
            dbEntry.NgaySInh = model.NgaySInh;
            dbEntry.GioiTinh = model.GioiTinh;
            dbEntry.Phone = model.Phone;
            dbEntry.Email = model.Email;
            dbEntry.PhanLoaiGV = model.PhanLoaiGV;
           

            context.SaveChanges();
            return true;
        }

        public bool Delete(tblGIANG_VIEN model)
        {
            tblGIANG_VIEN dbEntry = context.tblGIANG_VIEN.Find(model.MaGV);
            if (dbEntry == null) return false;
            context.tblGIANG_VIEN.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}
