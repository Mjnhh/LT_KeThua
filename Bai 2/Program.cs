using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class HinhTron
    {
        protected double bankinh;

        public HinhTron() { bankinh = 0; }
        public HinhTron(double bankinh) { this.bankinh = bankinh; }

        public void setBanKinh(double bankinh) { this.bankinh = bankinh; }
        public double getBanKinh() { return bankinh; }

        public virtual double tinhDienTich()
        {
            return Math.PI * bankinh * bankinh;
        }

        public double tinhChuVi()
        {
            return 2 * Math.PI * bankinh;
        }

        public void hienThi()
        {
            Console.WriteLine($"Hình tròn: Bán kính = {bankinh}, Diện tích = {tinhDienTich()}, Chu vi = {tinhChuVi()}");
        }
    }

    class HinhTru : HinhTron
    {
        private double chieucao;

        public HinhTru() : base() { chieucao = 0; }
        public HinhTru(double bankinh, double chieucao) : base(bankinh) { this.chieucao = chieucao; }

        public void setChieuCao(double chieucao) { this.chieucao = chieucao; }
        public double getChieuCao() { return chieucao; }

        public override double tinhDienTich()
        {
            return 2 * Math.PI * bankinh * (bankinh + chieucao);
        }

        public double tinhTheTich()
        {
            return Math.PI * bankinh * bankinh * chieucao;
        }

        public void hienThi()
        {
            Console.WriteLine($"Hình trụ: Bán kính = {bankinh}, Chiều cao = {chieucao}, Diện tích = {tinhDienTich()}, Thể tích = {tinhTheTich()}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Nhập thông tin hình tròn
            Console.Write("Nhập bán kính hình tròn: ");
            double r = Convert.ToDouble(Console.ReadLine());
            HinhTron hinhTron = new HinhTron(r);
            hinhTron.hienThi();

            // Nhập thông tin hình trụ
            Console.Write("Nhập bán kính hình trụ: ");
            double rTru = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều cao hình trụ: ");
            double hTru = Convert.ToDouble(Console.ReadLine());
            HinhTru hinhTru = new HinhTru(rTru, hTru);
            hinhTru.hienThi();
            Console.ReadLine();
        }
    }
}
