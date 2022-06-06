using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace VehicleAdvanced
{
    [ScriptTypeExtension(typeof(VehicleClass))]
    public class Module
    {

        [ScriptFunction("get_healthMax")]
        public static ushort getHealthMax([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.asset.healthMax;
        }
        [ScriptFunction("set_speed")]
        public static void setSpeed([ScriptInstance] ExpressionValue instance, ushort value)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return;
            vehicleClass.Vehicle.asset.GetType().GetField("_speedMax", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(vehicleClass.Vehicle.asset, value);
        }
        [ScriptFunction("get_speed")]
        public static float getSpeed([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.speed;
        }
    }
}
