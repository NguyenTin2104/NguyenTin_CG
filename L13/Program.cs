﻿/*Mục tiêu
Luyện tập thao tác với mảng 2 chiều

Điều kiện
Biết cách thao tác với mảng 2 chiều

Mô tả
Viết một ứng dụng cho phép người dùng nhập vào một ma trận số thực, sau đó tìm ra tọa độ cũng như giá trị của phần tử lớn nhất.

Hướng dẫn
Bước 1: tìm phần tử lớn nhất của ma trận có sẵn

Dùng mảng hai chiều để phản ánh ma trận.

Dùng phương pháp khởi tạo nhanh để tạo ra ma trận có sẵn các phần tử. Khai báo một biến số thực để chứa giá trị lớn nhất tìm kiếm được, và hai số nguyên để chứa tọa độ của giá trị lớn nhất tìm kiếm được, đặt cho những biến đó giá trị tương ứng của một phần tử ở tọa độ bất kỳ trong ma trận. Sử dụng vòng lặp để duyệt qua hết các phần tử của ma trận, cập nhật kết quả mỗi khi tìm thấy giá trị lớn hơn.

Thông báo cho người dùng kết quả tìm thấy được sau khi duyệt hết ma trận.

Thực thi chương trình để kiểm tra, thử với một số giá trị khác nhau để xác nhận rằng chương trình chạy đúng.

Bước 2: thu thập đầu vào thực từ nhập liệu của người dùng và hoàn thành yêu cầu

Viết mã để thay thế ma trận được tạo nhanh bằng ma trận được tạo ra từ nhập liệu của người dùng. Hỏi để biết kích thước ma trận, sau đó sử dụng vòng lặp để lần lượt hỏi từng giá trị của ma trận.*/
namespace _2Darray
{
    class Program
    {
        static void Main()
        {
            int row, col, indexR = 0, indexC = 0;
            Console.Write("Enter rows: ");
            row = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter rows: ");
            col = int.Parse(Console.ReadLine() ?? "0");
            double[,] a = new double[5, 5];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine() ?? "0");
                }
            }
            double key = a[indexR, indexC];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (a[i, j] > key)
                    {
                        key = a[i, j];
                        indexR = i;
                        indexC = j;
                    }
                }
            }
            Console.WriteLine($"Max of the 2D array at row {indexR} and column {indexC} is {key}");
        }
    }
}