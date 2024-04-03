using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.MainCode
{
    public class BaiHat
    {
        public BaiHat()
        {
        }

        public BaiHat(string id, string ten, string tenCaSi, int doDai, string tenNhacSi)
        {
            this.id = id;
            this.ten = ten;
            this.tenCaSi = tenCaSi;
            this.doDai = doDai;
            this.tenNhacSi = tenNhacSi;
        }

        public string id { get; set; }
        public string ten { get; set; }
        public string tenCaSi { get; set; }
        public int doDai { get; set; }
        public string tenNhacSi { get; set; }


    }


    public class BaiHatService
    {
        public List<BaiHat> listBaiHat;
        public BaiHatService()
        {
            listBaiHat = new List<BaiHat>();
            //SeedData
            listBaiHat.Add(new BaiHat("BH001", "Bài hát 1", "Ca sĩ 1", 1500, "Nhạc sĩ 1"));
        }

        public bool Add(BaiHat baiHat)
        {
            try
            {
                if (baiHat.id == null || baiHat.id == "") return false;
                if (listBaiHat.Any(bh => bh.id.Equals(baiHat.id))) return false;
                if (baiHat.doDai <= 0) return false;
                listBaiHat.Add(baiHat);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Delete(string id)
        {
            var baiHat = listBaiHat.First(bh => bh.id.Equals(id));
            if (baiHat == null) return false;
            listBaiHat.Remove(baiHat);
            return true;
        }
    }

}
