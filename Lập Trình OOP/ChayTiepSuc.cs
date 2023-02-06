// namespace TestCase
// {
//     public class Test
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = Encoding.UTF8;

//             DoiTuyen doi01 = new DoiTuyen("DT01", "THPT PVN");
//             ThiSinh thisinh01 = new ThiSinh("TS01", "Phạm Hùng", "TH");
//             ThiSinh thisinh02 = new ThiSinh("TS02", "Lê Duy", "NV");
//             ThiSinh thisinh03 = new ThiSinh("TS03", "Kim Ngọc", "TA");
//             ThiSinh thisinh04 = new ThiSinh("TS04", "Thuận Hưng", "MT");

//             DoiTuyen doi02 = new DoiTuyen("DT02", "THPT NHC");
//             ThiSinh thisinh05 = new ThiSinh("TS05", "Đức Hậu", "TH");
//             ThiSinh thisinh06 = new ThiSinh("TS06", "Tuấn Anh", "NV");
//             ThiSinh thisinh07 = new ThiSinh("TS07", "Phương Trinh", "TA");
//             ThiSinh thisinh08 = new ThiSinh("TS08", "Thúy Hằng", "MT");

//             DoiTuyen doi03 = new DoiTuyen("DT03", "Thpt TSC");
//             ThiSinh thisinh09 = new ThiSinh("TS09", "Quốc Trung", "TH");
//             ThiSinh thisinh10 = new ThiSinh("TS10", "Hữu Hiền", "NV");
//             ThiSinh thisinh11 = new ThiSinh("TS11", "Phương Ngọc", "TA");
//             ThiSinh thisinh12 = new ThiSinh("TS12", "Hoàng Giang", "MT");

//             DoiTuyen doi04 = new DoiTuyen("DT04", "THPT RK");
//             ThiSinh thisinh13 = new ThiSinh("TS03", "Quốc Tuấn", "TH");
//             ThiSinh thisinh14 = new ThiSinh("TS14", "Minh Nguyên", "NV");
//             ThiSinh thisinh15 = new ThiSinh("TS15", "Phan Tiến", "TA");
//             ThiSinh thisinh16 = new ThiSinh("TS16", "Minh Sơn", "MT");

//             // Thêm thành viên
//             doi01.themThanhVien(thisinh01);
//             doi01.themThanhVien(thisinh02);
//             doi01.themThanhVien(thisinh03);
//             doi01.themThanhVien(thisinh04);

//             doi02.themThanhVien(thisinh05);
//             doi02.themThanhVien(thisinh06);
//             doi02.themThanhVien(thisinh07);
//             doi02.themThanhVien(thisinh08);

//             doi03.themThanhVien(thisinh09);
//             doi03.themThanhVien(thisinh10);
//             doi03.themThanhVien(thisinh11);
//             doi03.themThanhVien(thisinh12);

//             doi04.themThanhVien(thisinh13);
//             doi04.themThanhVien(thisinh14);
//             doi04.themThanhVien(thisinh15);
//             doi04.themThanhVien(thisinh16);

//             // Thêm đội tuyển vào cuộc thi
//             CuocThi olympic = new CuocThi();
//             olympic.themDoiTuyen(doi01);
//             olympic.themDoiTuyen(doi02);
//             olympic.themDoiTuyen(doi03);
//             olympic.themDoiTuyen(doi04);

//             // Thêm kết quả thi
//             thisinh01.Diemthi = 7.8f;
//             thisinh02.Diemthi = 8.9f;
//             thisinh03.Diemthi = 6.0f;
//             thisinh04.Diemthi = 9.0f;
//             thisinh05.Diemthi = 7.0f;
//             thisinh06.Diemthi = 5.1f;
//             thisinh07.Diemthi = 9.7f;
//             thisinh08.Diemthi = 8.9f;
//             thisinh09.Diemthi = 6.6f;
//             thisinh10.Diemthi = 5.7f;
//             thisinh11.Diemthi = 8.8f;
//             thisinh12.Diemthi = 6.9f;
//             thisinh13.Diemthi = 9.2f;
//             thisinh14.Diemthi = 7.5f;
//             thisinh15.Diemthi = 9.0f;
//             thisinh16.Diemthi = 8.6f;


//             olympic.thongBao();
//             Console.ReadKey();
//         }
//     }
//     public class CuocThi
//     {
//         private static List<DoiTuyen> _dsdoituyen = new List<DoiTuyen>();
//         private static List<ThiSinh> _dsmontoan = new List<ThiSinh>();
//         private static List<ThiSinh> _dsmonnguvan = new List<ThiSinh>();
//         private static List<ThiSinh> _dsmontienganh = new List<ThiSinh>();
//         private static List<ThiSinh> _dsmontinhoc = new List<ThiSinh>();
//         public List<DoiTuyen> DSdoituyen { get => _dsdoituyen; }
//         public List<ThiSinh> DSmontoan { get => _dsmontoan; }
//         public List<ThiSinh> DSmonnguvan { get => _dsmonnguvan; }
//         public List<ThiSinh> DSmontienganh { get => _dsmontienganh; }
//         public List<ThiSinh> DSmontinhoc { get => _dsmontinhoc; }
//         public void themDoiTuyen(DoiTuyen doiA)
//         {
//             bool check = true;
//             foreach (DoiTuyen team in _dsdoituyen)
//                 if (team.Masodoituyen == doiA.Masodoituyen) check = false;
//             if (check) _dsdoituyen.Add(doiA);
//             else return;
//             foreach (ThiSinh member in doiA.DSthanhvien)
//             {
//                 switch (member.Mamonthi)
//                 {
//                     case "TH":
//                         _dsmontoan.Add(member);
//                         break;
//                     case "NV":
//                         _dsmonnguvan.Add(member);
//                         break;
//                     case "TA":
//                         _dsmontienganh.Add(member);
//                         break;
//                     case "MT":
//                         _dsmontinhoc.Add(member);
//                         break;
//                 }
//             } 
//         }
//         public static DoiTuyen giaiTapThe()
//         {
//             float max = 0;
//             DoiTuyen winner = new DoiTuyen();
//             foreach (DoiTuyen team in _dsdoituyen)
//             {
//                 if (team.totalPoints() > max)
//                 {
//                     max = team.totalPoints();
//                     winner = team;
//                 }
//             }
//             return winner;
//         }
//         public static ThiSinh nhatToan()
//         {
//             float max = 0;
//             ThiSinh top = new ThiSinh();
//             foreach (ThiSinh member in _dsmontoan)
//             {
//                 if (member.Diemthi > max)
//                 {
//                     max = member.Diemthi;
//                     top = member;
//                 }
//             }
//             return top;
//         }
//         public static ThiSinh nhatNguVan()
//         {
//             float max = 0;
//             ThiSinh top = new ThiSinh();
//             foreach (ThiSinh member in _dsmonnguvan)
//             {
//                 if (member.Diemthi > max)
//                 {
//                     max = member.Diemthi;
//                     top = member;
//                 }
//             }
//             return top;
//         }
//         public static ThiSinh nhatTiengAnh()
//         {
//             float max = 0;
//             ThiSinh top = new ThiSinh();
//             foreach (ThiSinh member in _dsmontienganh)
//             {
//                 if (member.Diemthi > max)
//                 {
//                     max = member.Diemthi;
//                     top = member;
//                 }
//             }
//             return top;
//         }
//         public static ThiSinh nhatTinHoc()
//         {
//             float max = 0;
//             ThiSinh top = new ThiSinh();
//             foreach (ThiSinh member in _dsmontinhoc)
//             {
//                 if (member.Diemthi > max)
//                 {
//                     max = member.Diemthi;
//                     top = member;
//                 }
//             }
//             return top;
//         }
//         public void thongBao()
//         {
//             Console.WriteLine($"Giải đội tuyển xuất sắc nhất thuộc về đội tuyển có mã số {giaiTapThe().Masodoituyen}, đơn vị {giaiTapThe().Tendonvi} với tổng điểm là {Math.Round(giaiTapThe().totalPoints(), 2)}");
//             Console.WriteLine($"Thí sinh đạt điểm cao nhất môn toán có mã số {nhatToan().Masothisinh}, thí sinh {nhatToan().Hoten} với số điểm {nhatToan().Diemthi}");
//             Console.WriteLine($"Thí sinh đạt điểm cao nhất môn ngữ văn có mã số {nhatNguVan().Masothisinh}, thí sinh {nhatNguVan().Hoten} với số điểm {nhatNguVan().Diemthi}");
//             Console.WriteLine($"Thí sinh đạt điểm cao nhất môn tiếng anh có mã số {nhatTiengAnh().Masothisinh}, thí sinh {nhatTiengAnh().Hoten} với số điểm {nhatTiengAnh().Diemthi}");
//             Console.WriteLine($"Thí sinh đạt điểm cao nhất môn tin học có mã số {nhatTinHoc().Masothisinh}, thí sinh {nhatTinHoc().Hoten} với số điểm {nhatTinHoc().Diemthi}");
//         }
//     }
//     public class DoiTuyen
//     {
//         private string _masodoituyen;
//         private string _tendonvi;
//         private List<ThiSinh> _dsthanhvien = new List<ThiSinh>();

//         public string Masodoituyen { get => _masodoituyen; }
//         public string Tendonvi { get => _tendonvi; }
//         public List<ThiSinh> DSthanhvien { get => _dsthanhvien; }

//         public DoiTuyen() {}
//         public DoiTuyen(string masodoituyen, string tendonvi)
//         {
//             _masodoituyen = masodoituyen;
//             _tendonvi = tendonvi;
//         }
//         public void themThanhVien(ThiSinh thisinhA)
//         {
//             bool check = true;
//             foreach (ThiSinh member in _dsthanhvien)
//                 if (member.Masothisinh == thisinhA.Masothisinh) check = false;
//             if (check) _dsthanhvien.Add(thisinhA);
//         }
//         public float totalPoints()
//         {
//             float total = 0;
//             foreach (ThiSinh member in _dsthanhvien)
//                 total += member.Diemthi;
//             return total;
//         }
//     }
//     public class ThiSinh
//     {
//         private string _masothisinh;
//         private string _hoten;
//         private string _mamonthi;
//         private float _diemthi;

//         public string Masothisinh { get => _masothisinh; }
//         public string Hoten { get => _hoten; }
//         public string Mamonthi { get => _mamonthi; }
//         public float Diemthi { set => _diemthi = value; get => _diemthi; }

//         public ThiSinh() {}
//         public ThiSinh(string masothising, string hoten, string mamonthi)
//         {
//             _masothisinh = masothising;
//             _hoten = hoten;
//             _mamonthi = mamonthi;
//         }
//     }
// }


// using System;

// namespace conAppOOP
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = System.Text.Encoding.UTF8;

//             Competition chayTiepSuc = new Competition();

//             Team doiMot = new Team("1", "HCM");
//             Athlete NguyenTuan = new Athlete("001", "Nguyễn Tuân", 21);
//             Athlete TuanHai = new Athlete("002", "Tuấn Hải", 23);
//             Athlete Sunny = new Athlete("003", "CK", 20);
//             Sunny.arrangeTeam(doiMot);
//             Sunny.Time = 5;
//             doiMot.AddVDV(NguyenTuan);
//             doiMot.AddVDV(TuanHai);
//             doiMot.AddVDV(Sunny);
//             NguyenTuan.Time = 8;
//             TuanHai.Time = 13;
//             Team doiHai = new Team("2", "HN");
//             Athlete KienCuong = new Athlete("001", "Kiên Cường", 25);
//             Athlete BatKhuat = new Athlete("001", "Bất Khuất", 20);
//             doiHai.AddVDV(BatKhuat);
//             doiHai.AddVDV(KienCuong);
//             KienCuong.Time = 10;
//             BatKhuat.Time = 11;

//             chayTiepSuc.addTeam(doiMot);
//             chayTiepSuc.addTeam(doiHai);

//             Console.WriteLine(doiMot.totalTime());
//             chayTiepSuc.getInfo();
//             doiMot.memberList();

//             Console.ReadKey();
//         }
//     }
//     public class Competition
//     {
//         static private List<Team> Teams = new List<Team>();
//         public void addTeam(Team A)
//         {
//             Teams.Add(A);
//         }
//         public static Athlete fastest()
//         {
//             float minTime = 1000000;
//             Athlete fastest = new Athlete();
//             foreach (Team A in Teams)
//             {
//                 foreach (Athlete member in A.Athletes)
//                 {
//                     if (member.Time < minTime)
//                     {
//                         minTime = member.Time;
//                         fastest = member;
//                     }
//                 }
//             }
//             return fastest;
//         }
//         public static Team winner()
//         {
//             float minTotalTime = 1000000;
//             Team winner = new Team();
//             foreach (Team A in Teams)
//             {
//                 if (A.totalTime() < minTotalTime)
//                 {
//                     minTotalTime = A.totalTime();
//                     winner = A;
//                 }
//             }
//             return winner;
//         }
//         public void getInfo()
//         {
//             Console.WriteLine($"Người chạy nhanh nhất là {fastest().Name} với thời gian {fastest().Time}");
//             Console.WriteLine($"Đội chiến thằng cuộc thi là {winner().TeamID}");
//         }
//     }
//     public class Team
//     {
//         private string teamID;
//         private string unit;
//         public string TeamID { get => teamID; }
//         public string Unit { get => unit; }
//         private List<Athlete> athletes = new List<Athlete>();
//         public List<Athlete> Athletes { get => athletes; }
//         public Team() {}
//         public Team(string teamID, string unit)
//         {
//             this.teamID = teamID;
//             this.unit = unit;
//         }
//         public void AddVDV(Athlete athlete)
//         {
//             bool check = true;
//             foreach (Athlete member in athletes)
//                 if (member.id == athlete.id) check = false;
//             if (check) athletes.Add(athlete);
//         }
//         public float totalTime()
//         {
//             float sum = 0;
//             foreach (var member in this.athletes)
//                 sum += member.Time;
//             return sum;
//         }
//         public void memberList()
//         {
//             foreach (var member in athletes)
//                 Console.WriteLine(member.Name);
//         }
//     }
//     public class Athlete
//     {
//         private string ID;
//         public string id { get => ID; }
//         private string name;
//         private int age;
//         private float time;
//         public string Name { get => name; }
//         public int Age { get => age; }
//         private Team team;
//         public float Time { set => time = value; get => time; }
//         public Athlete() {}
//         public Athlete(string id, string name, int age)
//         {
//             this.ID = id;
//             this.name = name;
//             this.age = age;
//         }
//         public void arrangeTeam(Team A)
//         {
//             this.team = A;
//             A.AddVDV(this);
//         }
//     }
// }
