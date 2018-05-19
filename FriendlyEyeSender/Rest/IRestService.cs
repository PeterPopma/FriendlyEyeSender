using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FriendlyEyeSender
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebGet]
        XElement GetBoard();
    }
}
