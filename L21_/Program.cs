/*Lớp này gồm các thành phần sau:
2 hằng được đặt tên là SLOW, MEDIUM, và FAST với giá trị 1, 2, và 3 để biểu thị tốc độ quạt.
Trường speed có kiểu số nguyên (private int) để xác định tốc độ quạt, mặc định là SLOW
Trường on có kiểu private bool để xác định quạt đang bật hay tắt, mặc định là false (tắt).
Trường radius có kiểu private double để xác định bán kính quạt, giá trị mặc định là 5
Trường color có kiểu dữ liệu private string để xác định màu quạt, mặc định là blue
Các getter và setter cho các thuộc tính
Phương thức khởi tạo không tham số tạo đối tượng fan mặc định
Phương thức ToString() trả về chuỗi chứa thông tin của quạt. Nếu quạt đang ở trạng thái on, phương thức trả về speed, color, và radius với chuỗi “fan is on”. Nếu quạt không ở trạng thái on, phương thức trả về color, radius với chuỗi “fan is off”.
Viết chương trình hiển thị các đối tượng bằng cách gọi phương thức ToString
Tạo 2 đối tượng Fan
Đối tượng Fan 1: Gán giá trị lớn nhất cho speed, radius là 10, color là yellow và quạt ở trạng thái bật.
Đối tượng Fan 2: Gán giá trị trung bình cho speed, radius là 5, color là blue và quạt ở trạng thái tắt*/
using System;
namespace L21
{
    class Program
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        class Fan
        {
            public int speed { get; set; }
            private bool on { get; set; }
            private double radius { get; set; }
            private string color { get; set; }
            public Fan()
            {
                speed = SLOW;
                on = false;
                radius = 5;
                color = "blue";
            }
            public Fan(bool on, int speed, double radius, string color)
            {
                this.on = on;
                this.speed = speed;
                this.radius = radius;
                this.color = color;
            }
            public override string ToString()
            {
                if (on)
                {
                    return "Fan is on " + "\nSpeed " + speed + "\nRadius: " + radius + "\nColor: " + color;
                }
                else
                    return  "Fan is off " + "\nRadius: " + radius + "\nColor: " + color;

            }
        }
        static void Main()
        {

            Fan f1 = new Fan(true, 3, 10, "Yellow");
            Console.WriteLine("Fan 1: \n" + f1.ToString());
            Fan f2 = new Fan(false, 2, 5, "Blue");
            Console.WriteLine("Fan 2: \n" + f2.ToString());
        }
    }
}