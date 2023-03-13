using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Branch;

namespace ServicesOperations.Implementations.Branch
{
    public class CenterDetailsService : ICenterDetailsService
    {
        private IRepository<sp_fetch_tblcenter_details_Result> centerrepo;

        public CenterDetailsService(IRepository<sp_fetch_tblcenter_details_Result> centerrepo)
        {
            this.centerrepo = centerrepo;
        }

        public void AddCenterDetail(sp_fetch_tblcenter_details_Result center)
        {
            string spname = "[sp_tblcenter_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";
            object[] parameters = { "Insert",center.center_id, center.center_code, center.center_name, center.center_type, center.company_name, center.gst_number, center.address, center.contact_number, center.email_address, center.password };
            centerrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteCenterDetail(sp_fetch_tblcenter_details_Result center)
        {
            string spname = "[sp_tblcenter_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";
            object[] parameters = { "Delete", center.center_id, center.center_code, center.center_name, center.center_type, center.company_name, center.gst_number, center.address, center.contact_number, center.email_address, center.password };
            centerrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblcenter_details_Result> GetAllCenterDetails()
        {
            string spname = "[sp_fetch_tblcenter_details]{0}";
            object[] parameters = { 0 };
            return centerrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblcenter_details_Result GetCenterDetail(int center_id)
        {
            string spname = "[sp_fetch_tblcenter_details]{0}";
            object[] parameters = { center_id };
            return centerrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreCenterDetail(sp_fetch_tblcenter_details_Result center)
        {
            string spname = "[sp_tblcenter_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";
            object[] parameters = { "Restore", center.center_id, center.center_code, center.center_name, center.center_type, center.company_name, center.gst_number, center.address, center.contact_number, center.email_address, center.password };
            centerrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateCenterDetail(sp_fetch_tblcenter_details_Result center)
        {
            string spname = "[sp_tblcenter_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";
            object[] parameters = { "Update", center.center_id, center.center_code, center.center_name, center.center_type, center.company_name, center.gst_number, center.address, center.contact_number, center.email_address, center.password };
            centerrepo.ExecuteCommand(spname, parameters);
        }
    }
}
