using System;
using System.Drawing;

namespace FriendlyEyeSender
{
    class DetectionObject
    {
        private Rectangle rectangle;

        public DetectionObject(Rectangle rect)
        {
            rectangle = rect;
        }

        public Rectangle Rectangle
        {
            get
            {
                return rectangle;
            }

            set
            {
                rectangle = value;
            }
        }
    }
}
