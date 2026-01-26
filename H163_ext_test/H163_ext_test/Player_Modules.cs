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
    public static class Player_Modules
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        public static instance _players()
        {
            var datamodel = base_s.getdatamodel();
            var dt = new instance(datamodel);
            var Players = dt.findfirstchild("Players");
            return Players;
        }
        public static instance LocalPlayer()
        {
            var player_addres = local.ReadPointer(_players().address + offsets.LocalPlayer);
            var localplayer = new instance(player_addres);
            return localplayer;
        }
        public static instance Character_LocalPLayer()
        {
            var character = local.ReadPointer(LocalPlayer().address + Offsets2.Player.Character);
            var localplayer2 = new instance(character);
            return localplayer2;
        }
        public static void NoClip()
        {
            foreach (var child in Character_LocalPLayer().getchildren())
            {
                var Head_prim = local.ReadPointer(child.address + offsets.Primitive);
                if (local.ReadBool(Head_prim + 0x1AE) == true)
                {
                    local.WriteInt(Head_prim + 0x1AE, 0);
                }
            }
        }
    }
}
