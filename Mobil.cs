using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan4
{
    internal class Mobil
    {
        //field
        private string _warna;
        private int _JumlahPintu;
        private string _merk;
        private string _model;
        private int _TahunKeluar;
        private string _Kecepatan;

        //properties
        public string warna
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public int JumlahPintu
        {
            get
            {
                return _JumlahPintu;
            }
            set
            {
                _JumlahPintu = value;
            }
        }
        public string merk
        {
            get { return _merk; }
            set
            {
                _merk = value;
            }
        }
        public string model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }
        public int TahunKeluar
        {
            get { return _TahunKeluar; }
            set
            {
                _TahunKeluar = value;
            }
        }
        public string Kecepatan
        {
            get { return _Kecepatan; }
            set
            {
                _Kecepatan = value;
            }
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna{0}, merk {1}, Model {2} Berjalan dengan kecepatan {3} Keluaran Tahun {4} Dengan Jumlah Pintu Sebanyak {5}", warna, merk, model, Kecepatan, TahunKeluar, JumlahPintu);
        }
    }
}

