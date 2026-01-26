using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using H163_ext_test;
using Swed64;

namespace Shoto_tyt_esti
{
    public static class CFrame_a
    {
        public struct CFrame
        {
            public float r00, r01, r02;
            public float r10, r11, r12;
            public float r20, r21, r22;
            public float x, y, z;

            public Vector3 position
            {
                get { return new Vector3(x, y, z); }
            }
            public Vector3 RightVector
            {
                get { return new Vector3(r00, r01, r02); }
            }
            public Vector3 UpVector
            {
                get { return new Vector3(r10, r11, r12); }
            }
            public Vector3 LookVector
            {
                get { return new Vector3(r20, r21, r22); }
            }
            public CFrame(float r00, float r01, float r02,
                          float r10, float r11, float r12,
                          float r20, float r21, float r22,
                          float x, float y, float z)
            {
                this.r00 = r00; this.r01 = r01; this.r02 = r02;
                this.r10 = r10; this.r11 = r11; this.r12 = r12;
                this.r20 = r20; this.r21 = r21; this.r22 = r22;
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public CFrame(Vector3 rot1, Vector3 rot2, Vector3 rot3, Vector3 pos)
            {
                this.r00 = rot1.X; this.r01 = rot1.Y; this.r02 = rot1.Z;
                this.r10 = rot2.X; this.r11 = rot2.Y; this.r12 = rot2.Z;
                this.r20 = rot3.X; this.r21 = rot3.Y; this.r22 = rot3.Z;
                this.x = pos.X;
                this.y = pos.Y;
                this.z = pos.Z;
            }
        }
        static Swed local = new Swed("RobloxPlayerBeta");
        public static void Pre_Tp(float x, float y, float z)
        {
            foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
            {
                var p = local.ReadPointer(child.address + offsets.Primitive);
                if (local.ReadVec(p + offsets.PartSize) == new Vector3(2, 2, 1))
                {
                    var hrp_prim = local.ReadPointer(child.address + offsets.Primitive);
                    CFrame m = memory.read<CFrame>(hrp_prim + offsets.CFrame);
                    CFrame tp = new CFrame(m.RightVector, m.UpVector, m.LookVector, new Vector3(x, y, z));
                    for (int i = 0; i < 1000; i++)
                    {
                        memory.write<CFrame>(hrp_prim + offsets.CFrame, tp);
                    }
                }
            }
        }
        public static Vector3 Get_MePosition()
        {
            var head = Player_Modules.Character_LocalPLayer().findfirstchild("Head");
            var head_prim = local.ReadPointer(head.address + offsets.Primitive);
            return local.ReadVec(head_prim + offsets.Position);
        }
    }
}
