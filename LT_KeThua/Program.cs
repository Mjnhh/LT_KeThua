using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LT_KeThua
{
    class HinhTron
    {
        private double bankinh;
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }
        public double BanKinh
        {
            get { return bankinh; }
            set { bankinh = value; }

        }
        public virtual double tinhDienTich()
        {
            return bankinh * bankinh * Math.PI;

        }
        public double tinhChuVi()
        {
            return 2 * bankinh * Math.PI;
        }
        class HinhTru : HinhTron
        {
            private double chieucao;
            public HinhTru() : base()
            {
                chieucao = 1.0;
            }
            public HinhTru(double bankinh, double chieucao) : base(bankinh)
            {
                this.chieucao = chieucao;
            }
            public double ChieuCao
            {
                get { return chieucao; }
                set { chieucao = value; }
            }
            public double tinhTheTich()
            {
                double thetich = base.tinhDienTich() * chieucao;
                return thetich;
            }

            public override double tinhDienTich()
            {
                return base.tinhDienTich();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                HinhTron c1 = new HinhTron(5.0);
                Console.WriteLine("Hinh tron c1 : Ban Kinh: {0}, Dien Tich: {1}, Chu Vi: {2}", c1.BanKinh, c1.tinhDienTich(), c1.tinhChuVi());
                HinhTru c2 = new HinhTru(5.0, 3.0);
                Console.WriteLine("Hinh tru c2 : Ban Kinh: {0}, Chieu Cao: {1}, The Tich: {2}", c2.BanKinh, c2.ChieuCao, c2.tinhTheTich());

                Console.ReadLine();
                    
            }
        }
    }
}
