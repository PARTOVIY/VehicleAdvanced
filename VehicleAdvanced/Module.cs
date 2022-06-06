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

        [ScriptFunction("get_maxHealth")]
        public static ushort getHealthMax([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.asset.health;
        }
        [ScriptFunction("get_maxSpeed")]
        public static float getMaxSpeed([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.asset.speedMax;
        }
        [ScriptFunction("get_speed")]
        public static float getSpeed([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.speed;
        }
        [ScriptFunction("get_battery")]
        public static ushort getBattery([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return 0;
            return vehicleClass.Vehicle.batteryCharge;
        }
        [ScriptFunction("set_battery")]
        public static void setBattery([ScriptInstance] ExpressionValue instance, ushort value)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return;
            vehicleClass.Vehicle.askChargeBattery(value);
        }
        [ScriptFunction("carjack")]
        public static void carjack([ScriptInstance] ExpressionValue instance, Vector3Class force, Vector3Class torque)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return;
            VehicleManager.carjackVehicle(vehicleClass.Vehicle, null, force.Vector3, torque.Vector3);
        }
        [ScriptFunction("removeAllPassengers")]
        public static void removeAllPassengers([ScriptInstance] ExpressionValue instance)
        {
            if (!(instance.Data is VehicleClass vehicleClass)) return;
            vehicleClass.Vehicle.forceRemoveAllPlayers();
        }
    }
}
