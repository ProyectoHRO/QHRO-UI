using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class ClassServices
    {
        private Services services;
        public ClassServices()
        {
            services=new Services();
        }

        //methods
        //get
        public DataTable getServices()
        {
            return services.GetServices();
        }

        public DataTable getServicesByName(string serviceName)
        {
            return services.GetServicesByNameReport(serviceName);
        }
    

        public DataTable getServicesById(int id)
        {
            return services.GetServicesById(id);
        }
        //insert
        public string newService(string serviceName)
        {
            try
            {
                DataTable service = services.GetServicesByName(serviceName);
                if (service.Rows.Count <1)
                {
                    services.InsertService(serviceName);
                    return "SE HA GRABADO UN NUEVO REGISTRO";
                }
                else
                    return "ERROR: El servicio ya existe:  " + serviceName;
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
        //update
        public string updateAssistant(string serviceName, short serviceId)
        {
            try
            {
                services.UpdateService(serviceName,serviceId);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
