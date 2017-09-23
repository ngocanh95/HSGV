using QUANLYHOCSINHGIAOVIEN.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINHGIAOVIEN.FUNCTION
{
    public class SINHVIENF
    {
        private HSGVDbContext context;

        public SINHVIENF()
        {
            context = new HSGVDbContext();
        }

        public IQueryable<tblSINH_VIEN> tblSINH_VIENs
        {
            get { return context.tblSINH_VIEN; }
        }



        public tblSINH_VIEN FindEntity(string ID)
        {
            tblSINH_VIEN dbEntry = context.tblSINH_VIEN.Find(ID);
            return dbEntry;

        }

        public bool Insert(tblSINH_VIEN model)
        {
            tblSINH_VIEN dbEntry = context.tblSINH_VIEN.Find(model.MaSv);
            if (dbEntry != null) return false;
            context.tblSINH_VIEN.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(tblSINH_VIEN model)
        {
            tblSINH_VIEN dbEntry = context.tblSINH_VIEN.Find(model.MaSv);
            if (dbEntry == null) return false;
            dbEntry.MaSv = model.MaSv;
            dbEntry.HoTen = model.HoTen;

            dbEntry.GioiTinh = model.GioiTinh;
            dbEntry.NgaySinh = model.NgaySinh;
            dbEntry.DiaChi = model.DiaChi;
            dbEntry.MaLop = model.MaLop;

            context.SaveChanges();
            return true;
        }

        public bool Delete(tblSINH_VIEN model)
        {
            tblSINH_VIEN dbEntry = context.tblSINH_VIEN.Find(model.MaSv);
            if (dbEntry == null) return false;
            context.tblSINH_VIEN.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}
