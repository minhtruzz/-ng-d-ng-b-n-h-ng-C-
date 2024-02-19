using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class DTOLogin
    {
        public DTOLogin() { }
        public DTOLogin(DataRow r) {
            Ten = (string)r["Ten"];
            TenTK = (string)r["Ten"];
            MatKhau = (string)r["MatKhau"];
            Quyen = (int)r["Quyen"];
        }
        public string Ten { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public int Quyen { get; set; }
    }
}
