using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class ChuNhat
    {
        private double dai;
        private double rong;
        public ChuNhat()
        {
            dai = 1.0;
            rong = 1.0;
        }
        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double Dai
        {
            get { return dai; }
            set { dai = value; }
        }
        public double Rong
        {
            get { return rong; }
            set { rong = value; }
        }
        public double tinhDienTich()
        {
            return dai * rong;
        }
        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Hình chữ nhật: Chiều dài = {dai}, Chiều rộng = {rong}, Diện tích = {tinhDienTich()}, Chu vi = {tinhChuVi()}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                ChuNhat c1 = new ChuNhat(4,3);
                c1.Xuat();
                Console.ReadKey();
            }
        }
    }
}

