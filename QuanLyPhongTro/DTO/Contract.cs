using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DTO
{
    internal class Contract
    {
        private string id;
        private DateTime ngayThue;
        private DateTime hanThue;
        private int soPhong;
        private decimal giaPhong;
        private int idKhachChinh;
        private int idKhachPhu;
        private string trangThai;
        private DateTime ngayTaoHopDong;
        private string tenKhach1;
        private string tenKhach2;

        public Contract()
        {

        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime NgayThue
        {
            get { return ngayThue; }
            set { ngayThue = value; }
        }

        public DateTime HanThue
        {
            get { return hanThue; }
            set { hanThue = value; }
        }

        public int SoPhong
        {
            get { return soPhong; }
            set { soPhong = value; }
        }

        public decimal GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }

        public int IdKhachChinh
        {
            get { return idKhachChinh; }
            set { idKhachChinh = value; }
        }

        public int IdKhachPhu
        {
            get { return idKhachPhu; }
            set { idKhachPhu = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public DateTime NgayTaoHopDong
        {
            get { return ngayTaoHopDong; }
            set { ngayTaoHopDong = value; }
        }
        public string TenKhach1
        {
            get { return tenKhach1; }
            set { tenKhach1 = value; }
        }
        public string TenKhach2
        {
            get { return tenKhach2; }
            set { tenKhach2 = value; }
        }
    }
}
