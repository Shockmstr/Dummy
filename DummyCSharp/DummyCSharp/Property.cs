using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyCSharp
{
    class Property
    {
        public static IDictionary<string, string> impactListInit()
        {
            IDictionary<string, string> list = new Dictionary<string, string>();

            list.Add("Pickup300", "265.3-6516.0");
            list.Add("Pickup3045", "314.5-6244.0");
            list.Add("Pickup3090", "24.77-7119.0");
            list.Add("Pickup400", "600.6-19940.0");
            list.Add("Pickup4045", "760.9-4526.0");
            list.Add("Pickup4090", "90.76-586.3");
            list.Add("Pickup500", "751.6-112000.0");
            list.Add("Pickup5045", "1447.0-104400.0");
            list.Add("Pickup5090", "-");
            list.Add("Pickup600", "1616.0-35840.0");
            list.Add("Pickup6045", "2374.0-4335.0");
            list.Add("Pickup6090", "689.6-9094.0");

            list.Add("Sedan300", "5201.0-0.0");
            list.Add("Sedan3045", "1734.0-3042.0");
            list.Add("Sedan3090", "2993.0-0.0");
            list.Add("Sedan400", "6585.0-0.0");
            list.Add("Sedan4045", "2391.0-1000.0");
            list.Add("Sedan4090", "1222.0-194.1");
            list.Add("Sedan500", "7426.0-376.7");
            list.Add("Sedan5045", "5220.0-204.7");
            list.Add("Sedan5090", "5115.0-2881.0");
            list.Add("Sedan600", "19500.0-30440.0");
            list.Add("Sedan6045", "7834.0-36600.0");
            list.Add("Sedan6090", "10000.0-12150.0");

            list.Add("SUV300", "158.5-11600.0");
            list.Add("SUV3045", "102.5-8678.0");
            list.Add("SUV3090", "50.35-5830.0");
            list.Add("SUV400", "256.0-11830.0");
            list.Add("SUV4045", "206.0-5775.0");
            list.Add("SUV4090", "86.18-11060.0");
            list.Add("SUV500", "773.0-10640.0");
            list.Add("SUV5045", "649.1-12080.0");
            list.Add("SUV5090", "191.6-8773.0");
            list.Add("SUV600", "1198.0-50400.0");
            list.Add("SUV6045", "960.3-11500.0");
            list.Add("SUV6090", "798.7-15460.0");

            return list;
        }
    }
}
