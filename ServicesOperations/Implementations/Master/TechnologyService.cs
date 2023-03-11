using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Master;

namespace ServicesOperations.Implementations.Master
{
    public class TechnologyService : ITechnologyService
    {
        IRepository<sp_fetch_tbltechnologies_Result> technologyrepo;

        public TechnologyService(IRepository<sp_fetch_tbltechnologies_Result> technologyrepo)
        {
            this.technologyrepo = technologyrepo;
        }

        public void AddTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            string spname = "[sp_tbltechnologies]{0},{1},{2}";
            object[] parameters = { "Insert", technology.technology_id, technology.technology_name };
            technologyrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            string spname = "[sp_tbltechnologies]{0},{1},{2}";
            object[] parameters = { "Delete", technology.technology_id, technology.technology_name };
            technologyrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tbltechnologies_Result> GetAllTechnologies()
        {
            string spname = "[sp_fetch_tbltechnologies]{0}";
            object[] parameters = { 0 };
            return technologyrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tbltechnologies_Result GetTechnology(int technology_id)
        {
            string spname = "[sp_fetch_tbltechnologies]{0}";
            object[] parameters = { technology_id };
            return technologyrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            string spname = "[sp_tbltechnologies]{0},{1},{2}";
            object[] parameters = { "Restore", technology.technology_id, technology.technology_name };
            technologyrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            string spname = "[sp_tbltechnologies]{0},{1},{2}";
            object[] parameters = { "Update", technology.technology_id, technology.technology_name };
            technologyrepo.ExecuteCommand(spname, parameters);
        }
    }
}
