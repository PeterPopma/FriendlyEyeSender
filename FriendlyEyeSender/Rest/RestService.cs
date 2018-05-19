using FriendlyEyeSender.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FriendlyEyeSender
{
    public class RestService : IRestService
    {
        Form parentForm;

        public RestService(Form form)
        {
            this.parentForm = form;
        }

        public XElement GetBoard()
        {
            XElement root = new XElement("FriendlyEyeSenderboard");

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    string color = "none";
                    XElement elFriendlyEyeSenderpiece = new XElement("FriendlyEyeSenderpiece");
                    root.Add(elFriendlyEyeSenderpiece);
                    XAttribute attribX = new XAttribute("x", x);
                    elFriendlyEyeSenderpiece.Add(attribX);
                    XAttribute attribY = new XAttribute("y", y);
                    elFriendlyEyeSenderpiece.Add(attribY);
                    XElement elColor = new XElement("Color", color);
                    elFriendlyEyeSenderpiece.Add(elColor);
                }
            }

            return root;
        }

    }
}
