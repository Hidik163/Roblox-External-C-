using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using SharpDX.D3DCompiler;

namespace H163_ext_test
{
    public static class Config_sys
    {
        public static void Load(string st,int the_pit)
        {
            
            string[] spl = st.Split(' ');
            string q = spl[1];
            if (the_pit <= 10)
            {
                if (the_pit == 0)
                {
                    RenderClass.esp_flagsex = Convert.ToBoolean(spl[1].ToLower());
                    if (RenderClass.esp_flagsex)
                        RenderClass.espaw = true;
                    else if (!RenderClass.FOV_flagsex && !RenderClass.redare)
                        RenderClass.espaw = false;
                }
                else if (the_pit == 1)
                    RenderClass.nickname = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 2)
                    RenderClass.heal_flag = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 3)
                    RenderClass.lines = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 4)
                    RenderClass.lines2 = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 5)
                    RenderClass.tp_linq = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 6)
                    RenderClass.sq = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 7)
                    RenderClass.ecl = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 8)
                    RenderClass.sk = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 9)
                    RenderClass.esp_team_check = Convert.ToBoolean(spl[1].ToLower());
                else
                    RenderClass.esp_distance = Convert.ToBoolean(spl[1].ToLower());
            }
            else if (the_pit <= 19)
            {

                if (the_pit == 11)
                {
                    RenderClass.suport_nik_cvet = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.nik_cvet = ImGui.ColorConvertFloat4ToU32(RenderClass.suport_nik_cvet);
                }
                else if (the_pit == 12)
                {
                    RenderClass.suport_cvet = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.cvet = ImGui.ColorConvertFloat4ToU32(RenderClass.suport_cvet);
                }
                else if (the_pit == 13)
                {
                    RenderClass.redare = Convert.ToBoolean(spl[1].ToLower());
                    if (RenderClass.redare)
                        RenderClass.espaw = true;
                    else if (!RenderClass.FOV_flagsex && !RenderClass.esp_flagsex)
                        RenderClass.espaw = false;
                }
                else if (the_pit == 14)
                    RenderClass.radar_size.X = Convert.ToSingle(q);
                else if (the_pit == 15)
                    RenderClass.radar_size.Y = Convert.ToSingle(q);
                else if (the_pit == 16)
                    RenderClass.map_dis = Convert.ToInt32(q);
                else if (the_pit == 17)
                    RenderClass.map_vis = Convert.ToBoolean(spl[1].ToLower());
                else if (the_pit == 18)
                    RenderClass.esp_team_check = Convert.ToBoolean(spl[1].ToLower());
                else
                    RenderClass.per_x = Convert.ToSingle(q);
            }
            else if (the_pit <= 31)
            {
                if (the_pit == 20)
                {
                    RenderClass.radar_me = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.rd_1 = ImGui.ColorConvertFloat4ToU32(RenderClass.radar_me);
                }
                else if (the_pit == 21)
                {
                    RenderClass.radar_no_me = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.rd_2 = ImGui.ColorConvertFloat4ToU32(RenderClass.radar_no_me);
                }
                else if (the_pit == 22)
                {
                    RenderClass.map_color = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.rd_map = ImGui.ColorConvertFloat4ToU32(RenderClass.map_color);
                }
                else if (the_pit == 23)
                {
                    RenderClass.gui_lab_txt = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                }
                else if (the_pit == 24)
                {
                    RenderClass.gui_lab_bbt = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                }
                else if (the_pit == 25)
                {
                    RenderClass.st_prof = Convert.ToBoolean(spl[1].ToLower());
                    if (RenderClass.st_prof)
                        RenderClass.the_host = 0x11;
                    else
                        RenderClass.the_host = 0;

                }
                else if (the_pit == 26)
                {
                    RenderClass.aim = Convert.ToBoolean(spl[1].ToLower());
                }
                else if (the_pit == 27)
                {
                    RenderClass.metodg = Convert.ToInt32(spl[1]);
                }
                else if (the_pit == 28)
                {
                    RenderClass.tg_part = Convert.ToInt32(spl[1]);
                }
                else if (the_pit == 29)
                {
                    RenderClass.distance_work = Convert.ToSingle(q);
                }
                else if (the_pit == 30)
                {
                    RenderClass.tm_ai = Convert.ToBoolean(spl[1].ToLower());
                }
                else
                {
                    RenderClass.FOV_flagsex = Convert.ToBoolean(spl[1].ToLower());
                    if (RenderClass.FOV_flagsex)
                        RenderClass.espaw = true;
                    else if (!RenderClass.redare && !RenderClass.esp_flagsex)
                        RenderClass.espaw = false;
                }
            }
            else if (the_pit <= 40)
            {
                if (the_pit == 32)
                {
                    RenderClass.FVW = Convert.ToSingle(q);
                }
                else if (the_pit == 33)
                {
                    RenderClass.oqw = Convert.ToSingle(q);
                }
                else if (the_pit == 34)
                {
                    RenderClass.fov_color = new Vector4(Convert.ToSingle(spl[1]), Convert.ToSingle(spl[2]), Convert.ToSingle(spl[3]), Convert.ToSingle(spl[4]));
                    RenderClass.fv_cla = ImGui.ColorConvertFloat4ToU32(RenderClass.fov_color);
                }
                else if (the_pit == 35)
                {
                    RenderClass.tg = Convert.ToBoolean(spl[1].ToLower());
                }
                else if (the_pit == 36)
                {
                    RenderClass.tm_tg = Convert.ToBoolean(spl[1].ToLower());
                }
                else if (the_pit == 37)
                {
                    RenderClass.tg_dist = Convert.ToSingle(q);
                }
            }
            
        }
        public static void Save()
        {
            StreamWriter config = File.CreateText(@$"Configs\Config_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}_{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}.txt");
            config.WriteLine($"Enable_Esp: {RenderClass.esp_flagsex}\nNickname: {RenderClass.nickname}\nHealth: {RenderClass.heal_flag}\nCenter_Lines: {RenderClass.lines}\nDown_Lines: {RenderClass.lines2}\nTop_Lines: {RenderClass.tp_linq}\nSquare: {RenderClass.sq}\nCircle: {RenderClass.ecl}\nskeleton: {RenderClass.sk}\nTeam_Check: {RenderClass.esp_team_check}\nDistance: {RenderClass.esp_distance}");
            config.WriteLine($"Nickname_color: {RenderClass.suport_nik_cvet.X} {RenderClass.suport_nik_cvet.Y} {RenderClass.suport_nik_cvet.Z} {RenderClass.suport_nik_cvet.W}");
            config.WriteLine($"Main_color: {RenderClass.suport_cvet.X} {RenderClass.suport_cvet.Y} {RenderClass.suport_cvet.Z} {RenderClass.suport_cvet.W}");
            config.WriteLine($"Radar: {RenderClass.redare}\nSize_Map_X: {RenderClass.radar_size.X}\nSize_Map_Y: {RenderClass.radar_size.Y}\nMap_design: {RenderClass.map_dis}\nVisible_map: {RenderClass.map_vis}\n_Team_Check: {RenderClass.esp_team_check}\nSize_Persons: {RenderClass.per_x}");
            config.WriteLine($"Me_color: {RenderClass.radar_me.X} {RenderClass.radar_me.Y} {RenderClass.radar_me.Z} {RenderClass.radar_me.W}");
            config.WriteLine($"Enemy_color: {RenderClass.radar_no_me.X} {RenderClass.radar_no_me.Y} {RenderClass.radar_no_me.Z} {RenderClass.radar_no_me.W}");
            config.WriteLine($"Map_color: {RenderClass.map_color.X} {RenderClass.map_color.Y} {RenderClass.map_color.Z} {RenderClass.map_color.W}");
            config.WriteLine($"Gui_Text_Color: {RenderClass.gui_lab_txt.X} {RenderClass.gui_lab_txt.Y} {RenderClass.gui_lab_txt.Z} {RenderClass.gui_lab_txt.W}");
            config.WriteLine($"Gui_Main_Color: {RenderClass.gui_lab_bbt.X} {RenderClass.gui_lab_bbt.Y} {RenderClass.gui_lab_bbt.Z} {RenderClass.gui_lab_bbt.W}");
            config.WriteLine($"StreamProof: {RenderClass.st_prof}");
            config.WriteLine($"AimBot(Enabled): {RenderClass.aim}\nAimBot(metod): {RenderClass.metodg}\nAimBot(targetpart): {RenderClass.tg_part}\nAimBot(distance): {RenderClass.distance_work}\nAimBot(Team_Check): {RenderClass.tm_ai}\nAimBot(FOV): {RenderClass.FOV_flagsex}\nAimBot(FOV_radius): {RenderClass.FVW}\nAimBot(FOV_size): {RenderClass.oqw}");
            config.WriteLine($"Fov_Color: {RenderClass.fov_color.X} {RenderClass.fov_color.Y} {RenderClass.fov_color.Z} {RenderClass.fov_color.W}");
            config.WriteLine($"TriggetBot(Enabled): {RenderClass.tg}\nTriggetBot(TeamCheck): {RenderClass.tm_tg}\nTriggerBot(Distance): {RenderClass.tg_dist}");
            config.Close();
        }
    }
}
