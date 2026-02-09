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
                string asxz = child.name();
                if (asxz != "Torso" && asxz.Length <= 6 && asxz != "Head")
                {
                    var p = local.ReadPointer(child.address + offsets.Primitive);
                    Vector3 qq = local.ReadVec(p + offsets.PartSize);
                    if (qq.X >= 2 && qq.Y >= 2)
                    {
                        for (int i = 0; i < 100; i++)
                            local.WriteVec(p + Offsets.BasePart.AssemblyLinearVelocity, new Vector3(x, y, z));
                        break;
                    }
                }

            }
        }
        public static void Set_AssemblyAngularVelocity(float x, float y, float z)
        {
            foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
            {
                string asxz = child.name();
                if (asxz != "Torso" && asxz.Length <= 6 && asxz != "Head")
                {
                    var p = local.ReadPointer(child.address + offsets.Primitive);
                    Vector3 qq = local.ReadVec(p + offsets.PartSize);
                    if (qq.X >= 2 && qq.Y >= 2)
                    {
                        for (int i = 0; i < 100; i++)
                            local.WriteVec(p + Offsets.BasePart.AssemblyAngularVelocity, new Vector3(x, y, z));
                        break;
                    }
                }

            }
        }
    }
}

