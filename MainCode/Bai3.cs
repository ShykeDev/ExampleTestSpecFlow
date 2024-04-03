
namespace Lab7.MainCode
{
    public class StudentGrader
    {
        public static string XepLoai(int diem)
        {
            if (diem < 0 || diem > 100)
            {
                throw new ArgumentException("Điểm không hợp lệ");
            } 
            else if (diem <= 40) return "F";
            else if (diem <= 60) return "D";
            else if (diem < 70) return "C";
            else if (diem < 80) return "B";
            else return "A";
        }
    }
}
