using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H163_ext_test;
using Swed64;
using static H163_ext_test.instance;

namespace Shoto_tyt_esti
{
    public static class Humanoid
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        public static instance Humanoid_LocalPlayer()
        {
            return Player_Modules.Character_LocalPLayer().findfirstchild("Humanoid");
        }
        public static void walkspeed(float speed)
        {
            local.WriteFloat(Humanoid_LocalPlayer().address + offsets.WalkSpeed, speed);
            local.WriteFloat(Humanoid_LocalPlayer().address + offsets.WalkSpeedCheck, speed);
        }
        public static void JumpPower(float speed)
        {
            local.WriteFloat(Humanoid_LocalPlayer().address + offsets.JumpPower, speed);
        }
        public static void PlatformStand(bool a)
        {
            local.WriteBool(Humanoid_LocalPlayer().address + Offsets3.PlatformStand, a);
        }
        public static void AutoRotate(bool a)
        {
            local.WriteBool(Humanoid_LocalPlayer().address + Offsets.Humanoid.AutoRotate, a);
        }
        public static void Reset()
        {
            local.WriteFloat(Humanoid_LocalPlayer().address + offsets.Health, 0);
        }
    }
}
