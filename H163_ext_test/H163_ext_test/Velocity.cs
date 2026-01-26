using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using H163_ext_test;
using Swed64;

namespace Shoto_tyt_esti
{
    public static class Velocity
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        public static void Set_AssemblyLinearVelocity(float x, float y, float z)
        {
            foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
            {
                var p = local.ReadPointer(child.address + offsets.Primitive);
                if (local.ReadVec(p + offsets.PartSize) == new Vector3(2, 2, 1) && child.name() != "Torso")
                {
                    var hrp_prim = local.ReadPointer(child.address + offsets.Primitive);
                    for (int i = 0; i < 100; i++)
                        local.WriteVec(hrp_prim + Offsets.BasePart.AssemblyLinearVelocity, new Vector3(x, y, z));
                }

            }
        }
        public static void Set_AssemblyAngularVelocity(float x, float y, float z)
        {
            foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
            {
                var p = local.ReadPointer(child.address + offsets.Primitive);
                if (local.ReadVec(p + offsets.PartSize) == new Vector3(2, 2, 1) && child.name() != "Torso")
                {
                    var hrp_prim = local.ReadPointer(child.address + offsets.Primitive);
                    for (int i = 0; i < 100; i++)
                        local.WriteVec(hrp_prim + Offsets.BasePart.AssemblyAngularVelocity, new Vector3(x, y, z));
                }

            }
        }
    }
}
