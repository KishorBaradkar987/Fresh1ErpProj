using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Branch
{
    public  interface ICenterDetailsService
    {
        void AddCenterDetail(sp_fetch_tblcenter_details_Result center);
        void UpdateCenterDetail(sp_fetch_tblcenter_details_Result center);
        void DeleteCenterDetail(sp_fetch_tblcenter_details_Result center);
        List<sp_fetch_tblcenter_details_Result> GetAllCenterDetails();
        sp_fetch_tblcenter_details_Result GetCenterDetail(int center_id);
        void RestoreCenterDetail(sp_fetch_tblcenter_details_Result center);
    }
}
