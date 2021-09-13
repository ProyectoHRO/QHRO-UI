using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetServicesTableAdapters;
using System.Data;
namespace BLL
{
    public class ClassServices
    {
        private servicioTableAdapter services;
        public ClassServices()
        {
            services=new servicioTableAdapter();
        }

        //methods
        //get
        public DataTable getServices()
        {
            return services.GetDataServices();
        }
        //insert
        public string newService(string serviceName)
        {
            try
            {
                DataTable service = services.GetDataByServiceName(serviceName);
                if (service.Rows.Count < 1)
                {
                    services.InsertQueryServiceName(serviceName);
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
                services.UpdateQueryServiceName(serviceName,serviceId);
                return "SE HA ACTUALIZADO EL REGISTRO";
            }
            catch (Exception error)
            {
                return "ERROR: " + error.Message;
            }
        }
    }
}
