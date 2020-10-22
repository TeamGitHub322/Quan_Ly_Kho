using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Quan_Ly_Kho.APP_DATA
{
   public class Connector
    {
       public Connector() { }
       public String getconnect()
       {
           return (ConfigurationManager.ConnectionStrings["Conn"].ToString());
       }
    }
}
