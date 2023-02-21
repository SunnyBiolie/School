namespace TrungTamBoiDuong {
    public abstract class NV {
        protected string hoten;
        protected double hesoluong;
        protected double luongcoban = 450;
        public abstract double Luong();
        List<NV> DSGV;
    }
    public class QuanLy : NV {
        private double _phucapQL;
        public QuanLy(string hoten, double hesoluong, double phucap) {
            this.hoten = hoten;
            this.hesoluong = hesoluong;
            _phucapQL = phucap;
        }
        public override double Luong() {
            return hesoluong * luongcoban + _phucapQL;
        }
        public void TinhLuong() {

        }
    }
    public abstract class GiangVien : NV {
        protected double thulaomoitiet = 50;
        protected List<MonHoc> dsMonGD;
        public List<MonHoc> DSMonGD { get => dsMonGD; set => dsMonGD = value; }
        public int tongsotiet() {
            if (dsMonGD.Count == 0) return 0;
            else {
                int tongsotiet = 0;
                foreach (MonHoc mh in dsMonGD) {
                    tongsotiet += mh.Sotiet;
                }
                return tongsotiet;
            }
        } 
    }

    public class GVCH : GiangVien {
        public GVCH(string hoten, double hesoluong) {
            this.hoten = hoten;
            this.hesoluong = hesoluong;
            DSMonGD = new List<MonHoc>();
        }
        public override double Luong()
        {
            return hesoluong * luongcoban + thulaomoitiet * tongsotiet();
        }
    }
    public class GVTG : GiangVien {
        private double _hesomoi;
        public GVTG(string hoten, double hesomoi) {
            this.hoten = hoten;
            _hesomoi = hesomoi;
            DSMonGD = new List<MonHoc>();
        }
        public override double Luong()
        {
            return thulaomoitiet * tongsotiet() * (_hesomoi + 1);
        }
    }


    public abstract class MonHoc {
        protected string name;
        protected int sotiet;
        public string Name { get => name; set => name = value; }
        public int Sotiet { get => sotiet; set => sotiet = value; }
    }
    public class KTBP : MonHoc {
        public KTBP() {
            sotiet = 15;
            name = "Kỹ thuật bàn phím";
        }
    }
    public class Internet : MonHoc {
        public Internet() {
            sotiet = 20;
            name = "Internet";
        }
    }
}
