using QuanLyPhongTro.DAL;
using QuanLyPhongTro.DTO;
using QuanLyPhongTro.GUI.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_HistoryService
    {
        DAL_HistoryService dal_HistoryService = new DAL_HistoryService();
        DAL_Rooms dalroom = new DAL_Rooms();
        public HistoryService getHistoryServiceByID(int id)
        {
            return dal_HistoryService.getHistoryServiceByID(id);
        }
        public List<HistoryService> GetListHistoryServiceByID(int id)
        {
            return dal_HistoryService.GetListHistoryServiceByID(id);
        }
        public List<int> getValueOldService(string idRoom)
        {
            return dal_HistoryService.getValueOldService(idRoom);
        }
        public List<HistoryService> GetListHistoryService() { 
            return dal_HistoryService.GetListHistoryService();
        }
        public bool ExistID(int id)
        {
            return dal_HistoryService.ExistID(id);
        }
        public bool AddHistoryService(HistoryService hs)
        {
            if (string.IsNullOrEmpty(hs.ID.ToString()))
            {
                throw new BusinessException("ID không được để trống");
            }
            if (!dalroom.RoomExist(hs.SoPhong))
            {
                throw new BusinessException("Phòng không tồn tại");
            }
            if (string.IsNullOrEmpty(hs.Ki.ToString()))
            {
                throw new BusinessException("Kì không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.SoDienCu.ToString()))
            {
                throw new BusinessException("Số điện cũ không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.SoDienMoi.ToString()))
            {
                throw new BusinessException("Số điện mới không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.SoNuocCu.ToString()))
            {
                throw new BusinessException("Số nước cũ không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.SoNuocMoi.ToString()))
            {
                throw new BusinessException("Số nước mới không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.GiaNuoc.ToString()))
            {
                throw new BusinessException("Giá nước không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.GiaDien.ToString()))
            {
                throw new BusinessException("Giá điện không được bỏ trống");
            }
            if (string.IsNullOrEmpty(hs.NgayTao.ToString()))
            {
                throw new BusinessException("Ngày tạo không được bỏ trống");
            }
            return dal_HistoryService.AddHisSV(hs);
        }
        public bool RemoveHistoryService(int id)
        {
            return dal_HistoryService.RemoveHisSV(id);
        }

        public bool UpdateHistoryService(HistoryService hs)
        {

            return dal_HistoryService.Update(hs);
        }
        public List<HistoryService> SortKI_DESC()
        {
            return dal_HistoryService.SortKI_DESC();
        }
        public List<HistoryService> SortKI_ASC()
        {
            return dal_HistoryService.SortKI_ASC();
        }
        public List<HistoryService> HistoryServicesByIDRoom(string idRoom)
        {
            return dal_HistoryService.HistoryServicesByIDRoom(idRoom);
        }
        public string FindIDByKi(string soPhong, string ki)
        {
            return dal_HistoryService.FindIDByKi(soPhong, ki);
        }
        public decimal getPriceInternet(int id)
        {
            return dal_HistoryService.getPriceInternet(id);
        }
        public HistoryService FindHistoryServiceByIDRoomAndMonth(string idRoom, string ki) {
            return dal_HistoryService.FindHistoryServiceByIDRoomAndMonth(idRoom, ki);
        }
        public HistoryService getHistoryServiceByStatus(string idRoom)
        {
            return dal_HistoryService.getHistoryServiceByStatus(idRoom);
        }
        public List<HistoryService> GetPendingServiceHistory()
        {
            return dal_HistoryService.GetPendingServiceHistory();
        }
        public bool UpdateStatus(string status , string idLS)
        {
            return dal_HistoryService.UpdateStatus(status, idLS);
        }
    }
}
