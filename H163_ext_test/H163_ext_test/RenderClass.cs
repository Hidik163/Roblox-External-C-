using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClickableTransparentOverlay;
using H163_ext_test;
using ImGuiNET;
using Newtonsoft.Json.Linq;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D11;
using Shoto_tyt_esti;
using Swed64;
using Vortice.Mathematics;
using static Offsets;
using System.Text;
using static Shoto_tyt_esti.CFrame_a;
using Humanoid = Shoto_tyt_esti.Humanoid;
namespace H163_ext_test
{
    public class RenderClass : Overlay
    {
        [DllImport("user32.dll")]
        static extern bool SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);
        string[] cl_gr = { "White", "Black", "Light-Green", "Blue", "Default-Green", "Pink", "Black-blue", "Purple", "Black-pink", "Turquoise", "Grey", "Light-Green-2", "Black-Green", "Orange","Red", "Brown", "Light-purple", "Light-Blue" };
        public static int part_target = 0;
        public static int zis_color = 0;
        public static int metodg = 0;
        public static int tg_part = 0;
        public static int map_dis = 0;
        string[] map_disain = { "Square", "Square_Filled"};
        Random rnd = new Random();
        string[] prties = { "Head", "Torso/UpperTorso","HumanoidRootPart"};
        string[] metod = {"Mouse","Camera"};
        string[] parts = { "Head", "Torso/UpperTorso" };
        public static uint the_host = 0;
        public static bool st_prof = false;
        public static bool map_vis = true;
        public static bool attach = false;
        public static bool lock_walk = false;
        public static bool lock_walk_mask = false;
        public static bool noclip = false;
        public static bool noclip_mask = false;
        public static bool inf_jump = false;
        public static bool inf_jump_m = false;
        public static bool no_cd = false;
        public static bool no_cd_m = false;
        public static bool fly = false;
        public static bool fly_m = false;
        public static bool V_walk = false;
        public static bool V_walk_mask = false;
        public static bool hit = false;
        public static bool hide_gui = true;
        public static bool hit_m = false;
        public static bool aim = false;
        public static bool aim_m = false;
        public static bool espaw = false;
        public static bool nickname = false;
        public static bool lines = false;
        public static bool lines2 = false;
        public static bool sq = false;
        public static bool ecl = false;
        public static bool sk = false;
        public static bool sk2 = false;
        public static bool ew = false;
        public static bool ew_m = false;
        public static bool dc = false;
        public static bool dc_m = false;
        public static bool kr = false;
        public static bool kr_m = false;
        public static bool de = false;
        public static bool de_m = false;
        public static bool tg = false;
        public static bool tg_m = false;
        public static bool FOV_flagsex = false;
        public static bool esp_flagsex = false;
        public static bool heal_flag = false;
        public static bool tm_ai = false;
        public static bool tm_tg = false;
        public static bool esp_team_check = false;
        public static bool esp_distance = false;
        public static bool tp_linq = false;
        public static bool hit_tmch = false;
        public static bool redare = false;
        public static bool flag_1 = false;
        public static bool flag_2 = false;
        bool frez_all = false;
        bool show_team = false;
        public static float distance_work = 75;
        public static float size_hit = 1;
        public static float gra = 0;
        public static float exp = 0;
        public static float sun_sz = 1;
        public static float moon_sz = 1;
        public static float as1 = 0;
        public static float as2 = 0;
        public static float as3 = 0;
        public static float blome = 0;
        public static float blome2 = 0;
        public static float blome3 = 0;
        public static float as4 = 0;
        public static float as5 = 0;
        public static float atm = 0;
        public static float atm2 = 0;
        public static float sun23 = 0;
        public static float fog1 = 0;
        public static float fog2 = 1000;
        public static float fvo = 1.7f;
        public static float z = 0;
        public static float z1 = 0;
        public static float z2 = 0;
        public static float iqwe = 5;
        public static float sde = 50;
        public static float kio = 10;
        public static float FVW = 100;
        public static float oqw = 1;
        public static float f_asp = 100;
        public static float tg_dist = 100;
        public static float per_x = 4;
        public static float square_size = 1;
        public static Vector3 colfog = new Vector3(0,0,0);
        public static Vector3 atm3 = new Vector3(1, 1, 1);
        public static Vector3 sasd = new Vector3(1, 1, 1);
        public static Vector3 colorqwe = new Vector3(1, 1, 1);
        public static Vector3 c2 = new Vector3(1, 1, 1);
        public static Vector3 c3 = new Vector3(1, 1, 1);
        public static Vector3 c4 = new Vector3(1, 1, 1);
        public static Vector3 ale = new Vector3(1, 1, 1);
        public static Vector3 get_ale = new Vector3(1, 1, 1);
        public static Vector3 pl_pos_head = new Vector3(0,0,0);
        public static Vector2 radar_size = new Vector2(300, 300);
        public static int menu = 1;
        public static float speed = 22;
        public static float power = 16;
        public static float heqw = 0;
        float hea = 0;
        int ssiaqw = 0;
        public static int bind_aimbot = 0x02;
        public static string bind_aimbot_name = "Mouse2";
        uint st_flag,st_flag2;
        static Swed local = new Swed("RobloxPlayerBeta");
        public static Vector4 suport_cvet = new Vector4(1, 1, 0, 1);
        public static Vector4 suport_nik_cvet = new Vector4(0, 1, 0, 1);
        public static Vector4 radar_me = new Vector4(1, 0, 0, 1);
        public static Vector4 radar_no_me = new Vector4(0, 1, 0, 1);
        public static Vector4 map_color = new Vector4(0, 0, 1, 1);
        public static Vector4 gui_lab_bbt = new Vector4(0.5f,0.5f,0,1);
        public static Vector4 gui_lab_txt = new Vector4(0.9f, 0.9f, 0, 1);
        public static Vector4 fov_color = new Vector4(0.5f, 0.5f, 0, 1);
        public static Vector4 team_cl = new Vector4(0, 0, 1, 1);
        public static Vector4 team_cl2 = new Vector4(1,0,0,1);
        public static uint cvet = ImGui.ColorConvertFloat4ToU32(suport_cvet);
        public static uint nik_cvet = ImGui.ColorConvertFloat4ToU32(suport_nik_cvet);
        public static uint fv_cla = ImGui.ColorConvertFloat4ToU32(fov_color);
        public static uint rd_1 = ImGui.ColorConvertFloat4ToU32(radar_me);
        public static uint rd_2 = ImGui.ColorConvertFloat4ToU32(radar_no_me);
        public static uint rd_map = ImGui.ColorConvertFloat4ToU32(map_color);
        public static uint team_color = ImGui.ColorConvertFloat4ToU32(team_cl);
        public static uint team_color2 = ImGui.ColorConvertFloat4ToU32(team_cl2);
        Vector2 fuck_yeeee = new Vector2(-1, -1);
        Vector2 sa3 = new Vector2(-1, -1);
        Vector2 part1 = new Vector2(-1, -1);
        Vector2 part2 = new Vector2(-1, -1);
        Vector2 part3 = new Vector2(-1, -1);
        Vector2 part4 = new Vector2(-1, -1);
        protected override void Render()
        {
            
            if (memory.GetAsyncKeyState(0x76) < 0) //https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
            {
                hide_gui = !hide_gui;              
                Thread.Sleep(200);
            }
            if (de && !de_m)
            {  
                local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x6959de4, 0);//PhysicsSenderMaxBandwidthBpsScaling
                de_m = true;
            }
            else if (!de)
            {
                local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x6959de4, 5);//PhysicsSenderMaxBandwidthBpsScaling
                de_m = false;
            }
            if ((memory.GetAsyncKeyState(0x2D) & 0x8000) != 0)
            {
                de = !de;
                Thread.Sleep(150);
            }
            if (hide_gui)
            {
                ImGui.SetNextWindowSize(new Vector2(600, 800));
                ImGuiStylePtr style = ImGui.GetStyle();
                style.WindowBorderSize = 2;
                style.WindowRounding = 6;
                style.FrameRounding = 3;
                style.Colors[(int)ImGuiCol.Button] = gui_lab_bbt;
                style.Colors[(int)ImGuiCol.Text] = gui_lab_txt;
                style.Colors[(int)ImGuiCol.Border] = gui_lab_bbt;
                style.Colors[(int)ImGuiCol.TitleBgActive] = gui_lab_bbt;
                ImGui.Begin($"Hidik163_exe", ImGuiWindowFlags.NoResize);
                IntPtr hwnd = Process.GetCurrentProcess().MainWindowHandle;
                SetWindowDisplayAffinity(hwnd, the_host);
                ImGui.SetCursorPos(new Vector2(500, 30));
                ImGui.Text($"Attach ({attach})");
                ImGui.SetCursorPos(new Vector2(520, 50));
                if (ImGui.Button("Attach"))
                {
                    if (memory.attach())
                    {
                        attach = !attach;
                    }
                    else
                        Console.WriteLine("ti eblan");
                }
                ImGui.SetCursorPos(new Vector2(20, 40));
                if (ImGui.Button("Player"))
                {
                    menu = 1;

                }
                ImGui.SetCursorPos(new Vector2(90, 40));
                if (ImGui.Button("World"))
                {
                    menu = 2;
                }
                ImGui.SetCursorPos(new Vector2(160, 40));
                if (ImGui.Button("Aiming"))
                {
                    menu = 3;
                }
                ImGui.SetCursorPos(new Vector2(230, 40));
                if (ImGui.Button("Auto_farm"))
                {
                    menu = 4;
                }
                ImGui.SetCursorPos(new Vector2(320, 40));
                if (ImGui.Button("Esp"))
                {
                    menu = 5;
                }
                ImGui.SetCursorPos(new Vector2(527, 747));
                if (ImGui.Button("  Gui\nSettings"))
                {
                    menu = 6;
                }
                ImGui.SetCursorPos(new Vector2(370, 40));
                if (ImGui.Button("Player List"))
                {
                    menu = 7;
                }
                if (menu == 1)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("Player", new Vector2(500, 700), true);
                    ImGui.Text("Function(Player)");
                    ImGui.Separator();
                    ImGui.SetCursorPos(new Vector2(225, 30));
                    ImGui.Text("Player");
                    ImGui.SliderFloat("WalkSpeed", ref speed, 0, 400);
                    ImGui.SameLine();
                    ImGui.Checkbox("Enable", ref lock_walk);
                    if (lock_walk && !lock_walk_mask)
                    {
                        lock_walk_mask = true;
                        Thread sped = new Thread(() =>
                        {
                            while (lock_walk)
                            {
                                Humanoid.walkspeed(speed);
                                Thread.Sleep(1);
                            }
                            lock_walk_mask = false;
                        });
                        sped.Start();
                    }
                    ImGui.SliderFloat("JumpPower", ref power, 0, 400);
                    ImGui.SameLine();
                    if (ImGui.Button("Set"))
                        Humanoid.JumpPower(power);
                    ImGui.SliderFloat("HipHeight", ref heqw, 0, 400);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_2"))
                        local.WriteFloat(Humanoid.Humanoid_LocalPlayer().address + offsets.HipHeight,heqw);
                    ImGui.Checkbox("NoClip", ref noclip);
                    if (noclip && !noclip_mask)
                    {
                        noclip_mask = true;
                        Thread sped = new Thread(() =>
                        {
                            while (noclip)
                            {
                                Player_Modules.NoClip();
                                Thread.Sleep(1);
                            }
                            noclip_mask = false;
                        });
                        sped.Start();
                    }
                    ImGui.Checkbox("Inf Jump", ref inf_jump);
                    if (inf_jump && !inf_jump_m)
                    {
                        inf_jump_m = true;
                        Thread Inf_jump = new Thread(() =>
                        {
                            while (inf_jump)
                            {
                                if ((memory.GetAsyncKeyState(0x20) & 0x8000) != 0)
                                    Velocity.Set_AssemblyLinearVelocity(0, 70, 0);
                            }
                            inf_jump_m = false;
                        });
                        Inf_jump.Start();
                    }

                    ImGui.Checkbox("No Jump CD", ref no_cd);
                    if (no_cd && !no_cd_m)
                    {
                        no_cd_m = true;
                        Thread No_Cool_Down_Jump = new Thread(() =>
                        {
                            while (no_cd)
                            {
                                if ((memory.GetAsyncKeyState(0x20) & 0x8000) != 0)
                                    local.WriteBool(Humanoid.Humanoid_LocalPlayer().address + Offsets.Humanoid.Jump, true);
                                Thread.Sleep(1);
                            }
                            no_cd_m = false;
                        });
                        No_Cool_Down_Jump.Start();
                    }
                    ImGui.Checkbox("Fly(method: Velocity)", ref fly);
                    ImGui.SliderFloat("fly speed",ref f_asp, 0, 300);
                    if (fly && !fly_m)
                    {
                        fly_m = true;
                        World.Set_Gravity(0);
                        Thread fly12 = new Thread(() =>
                        {
                            while (fly)
                            {
                                if ((memory.GetAsyncKeyState(0x57) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * f_asp, cam.UpVector.Z * -f_asp, cam.LookVector.Z * -f_asp);
                                }
                                else if ((memory.GetAsyncKeyState(0x53) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * -f_asp, cam.UpVector.Z * f_asp, cam.LookVector.Z * f_asp);
                                }
                                else if ((memory.GetAsyncKeyState(0x41) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * -f_asp, 0, cam.RightVector.Z * f_asp);
                                }
                                else if ((memory.GetAsyncKeyState(0x44) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * f_asp, 0, cam.RightVector.Z * -f_asp);
                                }
                                else
                                {
                                    Velocity.Set_AssemblyLinearVelocity(0, 0, 0);
                                    Thread.Sleep(10);
                                }

                            }
                            fly_m = false;
                            World.Set_Gravity(196);
                        });
                        fly12.Start();
                    }
                    ImGui.Checkbox("Desync", ref de);
                    ImGui.SameLine();
                    ImGui.Text("-key enable (insert)");
                    if(ImGui.Checkbox("Freeze all", ref frez_all))
                    {
                        if(frez_all)
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x766F11C, 999999999); //DebugRateLimitRandom - on
                        else
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x766F11C, 0); //DebugRateLimitRandom - off
                    }
                    ImGui.Checkbox("Velocity Walk", ref V_walk);
                    ImGui.SliderFloat("Speed_W", ref kio, 1,200);
                    if (V_walk && !V_walk_mask)
                    {
                        V_walk_mask = true;
                        Thread fly2 = new Thread(() =>
                        {
                            while (V_walk)
                            {
                                if ((memory.GetAsyncKeyState(0x57) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * kio, -1, cam.LookVector.Z * -kio);
                                }
                                if ((memory.GetAsyncKeyState(0x53) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * -kio, -1, cam.LookVector.Z * kio);
                                }
                                if ((memory.GetAsyncKeyState(0x41) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * -kio, -1, cam.RightVector.Z * kio);
                                }
                                if ((memory.GetAsyncKeyState(0x44) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * kio, -1, cam.RightVector.Z * -kio);
                                }
                            }
                            V_walk_mask = false;
                        });
                        fly2.Start();
                    }
                    if (ImGui.Button("\n  Respawn  \n\n"))
                        Humanoid.Reset();
                    ImGui.NewLine();
                    ImGui.InputFloat3("Position TP", ref ale);
                    ImGui.SameLine();
                    if (ImGui.Button("Teleport"))
                    {
                        CFrame_a.Pre_Tp(ale.X, ale.Y, ale.Z);
                    }
                    ImGui.NewLine();
                    ImGui.Text($"Your Position: {get_ale}");
                    if (ImGui.Button("Get My Position"))
                    {
                        get_ale = CFrame_a.Get_MePosition();
                    }
                    ImGui.NewLine();
                    ImGui.Text("HitBox Expander");                  
                    ImGui.Checkbox("Enable_hit", ref hit);
                    
                    ImGui.ListBox("Target Part", ref part_target, prties, prties.Length);
                    ImGui.Checkbox("Team Check",ref hit_tmch);
                    ImGui.SliderFloat("Size", ref size_hit, 1, 100);
                    if (hit && !hit_m)
                    {
                        hit_m = true;
                        Thread hit12 = new Thread(() =>
                        {
                            while (hit)
                            {
                                var namme = Player_Modules.LocalPlayer().address;
                                foreach (var child in Player_Modules._players().getchildren())
                                {
                                    if (child.address != namme)
                                    {
                                        if(hit_tmch)
                                        {
                                            var team = local.ReadPointer(namme + Offsets.Player.Team);
                                            var team_pl = local.ReadPointer(child.address + Offsets.Player.Team);
                                            if (team == team_pl)
                                                continue;
                                        }
                                        var c = local.ReadPointer(child.address + Offsets2.Player.Character);
                                        if (c == 0) continue;
                                        var c2 = new instance(c);
                                        foreach (var qseq in c2.getchildren())
                                        {           
                                            string aw = qseq.name();
                                            if (aw == "Head" && part_target == 0)
                                            {
                                                var q = local.ReadPointer(qseq.address + offsets.Primitive);
                                                local.WriteVec(q + offsets.PartSize, new Vector3(size_hit, size_hit, size_hit));
                                                break;
                                            }
                                            else if((aw == "Torso" || aw == "UpperTorso") && part_target == 1)
                                            {
                                                var q = local.ReadPointer(qseq.address + offsets.Primitive);                        
                                                local.WriteVec(q + offsets.PartSize, new Vector3(size_hit, size_hit, size_hit));                              
                                                break;
                                            }
                                            else if(aw != "Torso" && aw != "Head" && part_target == 2 && aw.Length <= 6)
                                            {
                                                var q = local.ReadPointer(qseq.address + offsets.Primitive);
                                                Vector3 qq = local.ReadVec(q + offsets.PartSize);
                                                if (qq.X >= 2 && qq.Y >= 2)
                                                {
                                                    local.WriteVec(q + offsets.PartSize, new Vector3(size_hit, size_hit, size_hit));
                                                    break;
                                                }
                                            }
                                            

                                        }
                                    }
                                }
                                Thread.Sleep(1000);
                            }
                            hit_m = false;                           
                        });
                        hit12.Start();
                    }
                    ImGui.NewLine();
                    ImGui.Text("Camera");
                    ImGui.SliderFloat("Camera FOV", ref fvo, 0.1f, 3);
                    ImGui.SameLine();
                    if(ImGui.Button("set"))
                    {
                        local.WriteFloat(base_s.Camera() + offsets.FOV, fvo);
                    }
                    ImGui.NewLine();
                    ImGui.Checkbox("OffsetCamera", ref ew);
                    if (ew && !ew_m)
                    {
                        ew_m = true;
                        Thread hit12 = new Thread(() =>
                        {
                            while (ew)
                            {
                                local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(z1, z, z2));
                                Thread.Sleep(1);
                            }
                            local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(0, 0, 0));
                            ew_m = false;
                        });
                        hit12.Start();
                    }                    
                    ImGui.SliderFloat("X", ref z1, 0, 50);                   
                    ImGui.SliderFloat("Y", ref z, 0, 50);
                    ImGui.SliderFloat("Z", ref z2, 0, 50);
                    ImGui.Checkbox("FreeCam (method = CameraOffsets)", ref dc);
                    ImGui.SameLine();
                    if(ImGui.Button("fix"))
                    {
                        foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
                        {
                            var p = local.ReadPointer(child.address + offsets.Primitive);
                            if (local.ReadVec(p + offsets.PartSize) == new Vector3(2, 2, 1) && child.name() != "Torso")
                            {
                                CFrame m = memory.read<CFrame>(p + offsets.CFrame);
                                CFrame tp = new CFrame(new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1), m.position);
                                for (int i = 0; i < 1000; i++)
                                {
                                    memory.write<CFrame>(p + offsets.CFrame, tp);
                                }
                                break;
                            }
                        }
                        Humanoid.PlatformStand(true);
                        Humanoid.AutoRotate(false);
                    }
                    if(ImGui.Button(" TP Camera Position "))
                    {
                        Vector3 pos = local.ReadVec(base_s.Camera() + offsets.CameraPos);
                        var s = Humanoid.Humanoid_LocalPlayer().address;
                        Vector3 aaa = local.ReadVec(s + Offsets2.Humanoid.CameraOffset);
                        local.WriteVec(s + Offsets2.Humanoid.CameraOffset, new Vector3(0, aaa.Y,0));
                        CFrame_a.Pre_Tp(pos.X,pos.Y,pos.Z);
                    }
                    ImGui.SliderFloat("Speed", ref iqwe, 0, 10);
                    if (dc && !dc_m)
                    {
                        dc_m = true;
                        Thread hit12 = new Thread(() =>
                        {
                            foreach (var child in Player_Modules.Character_LocalPLayer().getchildren())
                            {
                                var p = local.ReadPointer(child.address + offsets.Primitive);
                                if (local.ReadVec(p + offsets.PartSize) == new Vector3(2, 2, 1) && child.name() != "Torso")
                                {
                                    CFrame m = memory.read<CFrame>(p + offsets.CFrame);
                                    CFrame tp = new CFrame(new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1), m.position);
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        memory.write<CFrame>(p + offsets.CFrame, tp);
                                    }
                                    break;
                                }
                            }
                            Humanoid.PlatformStand(true);
                            Humanoid.AutoRotate(false);
                            while (dc)
                            {                                                                
                                Velocity.Set_AssemblyAngularVelocity(0, 0, 0);
                                if ((memory.GetAsyncKeyState(0x57) & 0x8000) != 0)
                                {
                                    CFrame cam = memory.read<CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Vector3 aaa = local.ReadVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset);
                                    local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(aaa.X + (cam.LookVector.X * iqwe), aaa.Y + (cam.UpVector.Z * -iqwe), aaa.Z + (cam.RightVector.X * -iqwe)));
                                }
                                else if ((memory.GetAsyncKeyState(0x53) & 0x8000) != 0)
                                {
                                    CFrame cam = memory.read<CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Vector3 aaa = local.ReadVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset);
                                    local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(aaa.X + (cam.LookVector.X * -iqwe), aaa.Y + (cam.UpVector.Z * iqwe), aaa.Z + (cam.RightVector.X * iqwe)));
                                }
                                else if ((memory.GetAsyncKeyState(0x41) & 0x8000) != 0)
                                {
                                    CFrame cam = memory.read<CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Vector3 aaa = local.ReadVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset);
                                    local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(aaa.X + (cam.RightVector.X * -iqwe), aaa.Y, aaa.Z + (cam.RightVector.Z * iqwe)));
                                }
                                else if ((memory.GetAsyncKeyState(0x44) & 0x8000) != 0)
                                {
                                    CFrame cam = memory.read<CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Vector3 aaa = local.ReadVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset); ;
                                    local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(aaa.X + (cam.RightVector.X * iqwe), aaa.Y, aaa.Z + (cam.RightVector.Z * -iqwe)));
                                }
                                Thread.Sleep(1);
                            }
                            Humanoid.PlatformStand(false);
                            local.WriteVec(Humanoid.Humanoid_LocalPlayer().address + Offsets2.Humanoid.CameraOffset, new Vector3(0, 0, 0));
                            Humanoid.AutoRotate(true);
                            dc_m = false;
                        });
                        hit12.Start();
                    }
                    ImGui.Checkbox("SpinBot", ref kr);
                    ImGui.SliderFloat("Spin-Speed", ref sde,1,100);
                    if (kr && !kr_m)
                    {
                        kr_m = true;
                        Thread hit12 = new Thread(() =>
                        {                         
                            while (kr)
                            {
                                Humanoid.AutoRotate(false);
                                Velocity.Set_AssemblyAngularVelocity(0,sde,0);
                            }
                            Humanoid.AutoRotate(true);
                            kr_m = false;
                        });
                        hit12.Start();
                    }
                    ImGui.EndChild();
                }
                else if (menu == 2)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("World", new Vector2(500, 700), true);
                    ImGui.Text("Function(World)");
                    ImGui.Separator();
                    ImGui.SetCursorPos(new Vector2(225, 30));
                    ImGui.Text("World");
                    ImGui.SliderFloat("Gravity", ref gra, 0, 300);
                    ImGui.SameLine();
                    if (ImGui.Button("Set"))
                        World.Set_Gravity(gra);


                    ImGui.Text("Lighting");
                    ImGui.ColorEdit3("Ambient", ref colorqwe);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_1"))
                        World.Set_Ambient(colorqwe.X, colorqwe.Y, colorqwe.Z);
                    ImGui.ColorEdit3("Out_Ambient", ref c2);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_2"))
                        World.Set_OutdoorAmbient(c2.X, c2.Y, c2.Z);
                    ImGui.ColorEdit3("ColorShift_Top", ref c3);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_3"))
                        World.Set_ColorShift_Top(c3.X * 255, c3.Y * 255, c3.Z * 255);
                    ImGui.ColorEdit3("ColorShift_Btm", ref c4);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_4"))
                        World.Set_ColorShift_Bottom(c4.X * 255, c4.Y * 255, c4.Z * 255);
                    ImGui.SliderFloat("ExposureCompen", ref exp, -10, 10);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_5"))
                        World.Set_ExposureCompensation(exp);


                    ImGui.Text("Sky");
                    ImGui.SliderFloat("MoonSize", ref moon_sz, 0, 100);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_6"))
                        World.Set_MoonAngularSize(moon_sz);
                    ImGui.SliderFloat("SunSize", ref sun_sz, 0, 100);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_7"))
                        World.Set_SunAngularSize(sun_sz);


                    ImGui.Text("Terrain");
                    ImGui.ListBox("GlassColors", ref zis_color, cl_gr, cl_gr.Length);
                    if (ImGui.Button("Set_Color"))
                        World.Set_GlassColor(zis_color);
                    ImGui.SliderFloat("GlassLenght", ref as1, 0, 1.5f);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_8"))
                    {
                        if (as1 == 0)
                            World.Set_GlassLenght(-0.55f);
                        else
                            World.Set_GlassLenght(as1);
                    }
                    ImGui.SliderFloat("WaterRefl", ref as2, 0, 30);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_9"))
                        World.Set_WaterReflectance(as2);
                    ImGui.SliderFloat("WaterTransp", ref as3, 0, 1);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_10"))
                        World.Set_WaterTransparency(as3);
                    ImGui.SliderFloat("WaterWaveSize", ref as4, 0, 100);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_11"))
                        World.Set_WaterWaveSize(as4);
                    ImGui.SliderFloat("WaterWaveSpeed", ref as5, 0, 1000);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_12"))
                        World.Set_WaterWaveSpeed(as5);
                    ImGui.ColorEdit3("WaterColor", ref sasd);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_13"))
                        World.Set_WaterColor(sasd.X, sasd.Y, sasd.Z);


                    ImGui.Text("Atmosphere");
                    ImGui.ColorEdit3("Color", ref atm3);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_14"))
                        World.Set_AtmosphereColor(atm3.X, atm3.Y, atm3.Z);
                    ImGui.SliderFloat("Density", ref atm, 0, 1);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_15"))
                        World.Set_AtmosphereDensity(atm);
                    ImGui.SliderFloat("Offset", ref atm2, 0, 1);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_16"))
                        World.Set_AtmosphereOffset(atm2);


                    ImGui.Text("Bloom");
                    ImGui.SliderFloat("Intensity", ref blome, 0, 100);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_17"))
                        World.Set_BloomIntensity(blome);
                    ImGui.SliderFloat("Size", ref blome2, 0, 50);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_18"))
                        World.Set_BloomSize(blome2);
                    ImGui.SliderFloat("Threshold", ref blome3, 0, 1);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_19"))
                        World.Set_BloomThreshold(blome3);


                    ImGui.Text("SunRays");
                    ImGui.SliderFloat("SRIntensity", ref sun23, 0, 10);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_20"))
                        World.Set_SunRaysIntensity(sun23);


                    ImGui.Text("Fog");
                    ImGui.SliderFloat("FogStart", ref fog1, 0, 1000);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_21"))
                        World.Set_FogStart(fog1);
                    ImGui.SliderFloat("FogEnd", ref fog2, 0, 1000);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_22"))
                        World.Set_FogEnd(fog2);
                    ImGui.ColorEdit3("FogColor",ref colfog);
                    ImGui.SameLine();
                    if (ImGui.Button("Set_23"))
                        World.Set_FogColor(colfog);
                    ImGui.EndChild();                    

                }
                else if (menu == 3)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("AimBot", new Vector2(500, 700), true);
                    ImGui.Text("Function(AimBot)");
                    ImGui.Separator();
                    ImGui.SetCursorPos(new Vector2(225, 30));
                    ImGui.Text("AimBot");
                    ImGui.Checkbox("Enable", ref aim);
                    ImGui.SameLine();
                    ImGui.Text("  -bind key:");
                    ImGui.SameLine();
                    if (ImGui.Button($"{bind_aimbot_name}"))
                    {
                        bind_aimbot_name = "...";
                        Thread bind = new Thread(() => 
                        {
                            while (true)
                            {
                                bind_aimbot = bind_sys.Bind_keys();
                                if (bind_aimbot == 0) continue;
                                bind_aimbot_name = bind_sys.Key_name(bind_aimbot);
                                break;
                            }
                        });
                        bind.Start();
                    }
                    ImGui.ListBox("Methods",ref metodg,metod,metod.Length);
                    ImGui.NewLine();
                    ImGui.ListBox("Part Target", ref tg_part, parts, parts.Length);
                    if (aim && !aim_m)
                    {
                        aim_m = true;
                        Thread sss = new Thread(() =>
                        {
                            var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                            while (aim)
                            {                                                                
                                if ((memory.GetAsyncKeyState(bind_aimbot) & 0x8000) != 0)
                                    {
                                    var name = Player_Modules.LocalPlayer().address;
                                    nint team = 0;
                                    if(tm_ai)
                                        team = local.ReadPointer(name + Offsets.Player.Team);
                                    var my = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                                    if (my == 0) continue;
                                    Vector3 pss = local.ReadVec(my + offsets.Position);
                                    Vector2 a = new Vector2(-1, -1);
                                    float closestDistance = float.MaxValue;
                                    nint team_pl = 0, ca = 0, hud = 0, head = 0;
                                    Vector3 the_thebest = new Vector3(0, 0, 0);
                                    var aqw = Scr_Mos.GetMousePosition();
                                    var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                                    var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                                    foreach (var child in Player_Modules._players().getchildren())
                                    {
                                        if (child.address != name)
                                        {
                                            if (tm_ai)
                                            {
                                                team_pl = local.ReadPointer(child.address + Offsets.Player.Team);
                                                if (team_pl == team)          
                                                    continue;
                                            }
                                            ca = local.ReadPointer(child.address + Offsets2.Player.Character);
                                            if (ca == 0) continue;                                         
                                            instance a2 = new instance(ca);
                                            byte qw = 0;
                                            foreach(var irhf in a2.getchildren())
                                            {
                                                if (qw == 2) break;
                                                string ze_name = irhf.name();
                                                if (ze_name == "Humanoid")
                                                {
                                                    hud = irhf.address;
                                                    qw++;
                                                }
                                                else if (ze_name == "Head" && tg_part == 0)
                                                {
                                                    head = irhf.address;
                                                    qw++;
                                                }
                                                else if(tg_part == 1 && (ze_name == "UpperTorso" || ze_name == "Torso"))
                                                {
                                                    head = irhf.address;
                                                    qw++;
                                                }

                                            }
                                            
                                            if(hud == 0 || head == 0) continue;
                                            if (local.ReadFloat(hud + offsets.Health) > 0)
                                            {                                                
                                                var head_prim = local.ReadPointer(head + offsets.Primitive);
                                                Vector3 pos2 = local.ReadVec(head_prim + offsets.Position);                                               
                                                if (Math.Abs(pss.X - pos2.X) < distance_work && Math.Abs(pss.Y - pos2.Y) < distance_work && Math.Abs(pss.Z - pos2.Z) < distance_work)
                                                {                                                    
                                                    Vector2 q = Scr_Mos.world_to_screen(pos2, dim, dim1);
                                                    if (q.X >= 0 && q.Y >= 0 && q.X <= 1920 && q.Y <= 1080)
                                                    {
                                                        int x = aqw.X - (int)q.X;
                                                        int y = aqw.Y - (int)q.Y;
                                                        float dist = x * x + y * y;
                                                        if (dist < closestDistance)
                                                        {
                                                            if (FOV_flagsex)
                                                            {
                                                                if (Math.Abs(x) <= FVW && Math.Abs(y) <= FVW)
                                                                {
                                                                    closestDistance = dist;
                                                                    a = q;
                                                                    if (metodg == 1)
                                                                        the_thebest = pos2;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                closestDistance = dist;
                                                                a = q;
                                                                if (metodg == 1)
                                                                    the_thebest = pos2;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (a.X >= 0 && a.Y >= 0 && a.X <= 1920 && a.Y <= 1080)
                                    {
                                        int w = aqw.X - (int)a.X;
                                        int w2 = aqw.Y - (int)a.Y;
                                        if (metodg == 0)
                                            Scr_Mos.MoveMouse(-w / 2, -w2 / 2);
                                        else
                                        {
                                            var cam = base_s.Camera();
                                            Vector3 CamPos = local.ReadVec(cam + offsets.CameraPos);
                                            Vector3 LokDir = Vector3.Normalize(the_thebest - CamPos);
                                            Rotation a123 = memory.read<Rotation>(cam + Offsets.Camera.Rotation);
                                            Vector3 u = a123.UpVector;
                                            Vector3 u2 = a123.RightVector;
                                            Vector3 u3 = a123.LookVector;
                                            memory.write<Rotation>(base_s.Camera() + Offsets.Camera.Rotation, new Rotation(new Vector3(u2.X, u2.Y, -LokDir.X), new Vector3(u.Z, u.Y, -LokDir.Y), new Vector3(u3.X, u3.Y, -LokDir.Z)));
                                        }
                                    }
                                }
                                Thread.Sleep(1);
                            }                            
                            aim_m = false;
                        });
                        sss.Start();
                    }
                    ImGui.NewLine();
                    ImGui.SliderFloat("Distance", ref distance_work, 0, 1000);
                    ImGui.Checkbox("Team Check", ref tm_ai);
                    if (ImGui.Checkbox("FOV", ref FOV_flagsex))
                    {
                        if (FOV_flagsex)
                            espaw = true;
                        else if (!esp_flagsex)
                            espaw = false;
                    }
                    ImGui.SliderFloat("FOV radius", ref FVW, 1, 500);
                    ImGui.SliderFloat("FOV size", ref oqw, 1, 20);
                    if (ImGui.ColorEdit4("FOV Color",ref fov_color))
                         fv_cla = ImGui.ColorConvertFloat4ToU32(fov_color);
                    ImGui.SetCursorPos(new Vector2(210, 360));
                    ImGui.Text("TriggerBot");
                    ImGui.Checkbox("_Enable", ref tg);
                    ImGui.Checkbox("_Team Check", ref tm_tg);
                    ImGui.SliderFloat("_Distance", ref tg_dist,50,300);
                    if (tg && !tg_m)
                    {
                        tg_m = true;
                        Thread sss = new Thread(() =>
                        {
                            var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                            while (tg)
                            {
                                var name = Player_Modules.LocalPlayer().address;
                                nint team = 0;
                                if (tm_tg)
                                    team = local.ReadPointer(name + Offsets.Player.Team);
                                var my = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                                if (my == 0) continue;
                                Vector3 pss = local.ReadVec(my + offsets.Position);
                                Vector2 a = new Vector2(-1, -1);
                                float closestDistance = float.MaxValue;
                                nint team_pl = 0, ca = 0, hud = 0, head = 0;
                                Vector2 clos = new Vector2(-1,-1);
                                var aqw = Scr_Mos.GetMousePosition();
                                var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                                var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                                foreach (var child in Player_Modules._players().getchildren())
                                {
                                    if (child.address != name)
                                    {
                                        if (tm_tg)
                                        {
                                            team_pl = local.ReadPointer(child.address + Offsets.Player.Team);
                                            if (team_pl == team)
                                                continue;
                                        }
                                        ca = local.ReadPointer(child.address + Offsets2.Player.Character);
                                        if (ca == 0) continue;
                                        instance a2 = new instance(ca);
                                        byte qw = 0;
                                        foreach (var irhf in a2.getchildren())
                                        {
                                            if (qw == 2) break;
                                            string ze_name = irhf.name();
                                            if (ze_name == "Humanoid")
                                            {
                                                hud = irhf.address;
                                                qw++;
                                            }
                                            else if (ze_name == "Head")
                                            {
                                                head = irhf.address;
                                                qw++;
                                            }

                                        }
                                        if (hud == 0 || head == 0) continue;
                                        if (local.ReadFloat(hud + offsets.Health) > 0)
                                        {
                                            var head_prim = local.ReadPointer(head + offsets.Primitive);
                                            Vector3 pos2 = local.ReadVec(head_prim + offsets.Position);
                                            Vector2 q = Scr_Mos.world_to_screen(pos2, dim, dim1);
                                            if (q.X >= 0 && q.Y >= 0 && q.X <= 1920 && q.Y <= 1080)
                                            {
                                                int x = aqw.X - (int)q.X;
                                                int y = aqw.Y - (int)q.Y;
                                                float dist = x * x + y * y;
                                                if (dist < closestDistance)
                                                {
                                                    clos = new Vector2(Math.Abs(pss.X - pos2.X), Math.Abs(pss.Y - pos2.Y));
                                                    closestDistance = dist;
                                                    a = q;
                                                }
                                            }
                                                
                                        }
                                    }
                                }
                                if (a.X >= 0 && a.Y >= 0 && a.X <= 1920 && a.Y <= 1080)
                                {
                                    int w = aqw.X - (int)a.X;
                                    int w2 = aqw.Y - (int)a.Y;
                                    if (tg_dist <= 100)
                                    {
                                        if (((w <= 21) && (w >= -21)) && ((w2 <= 80) && (w2 >= -8)) && (clos.X <= 25 && clos.Y <= 25))
                                            Scr_Mos.Click();
                                        else if (((w <= 17.5) && (w >= -17.5)) && ((w2 <= 70) && (w2 >= -8)) && (clos.X <= 50 && clos.Y <= 50))
                                            Scr_Mos.Click();
                                        else if (((w <= 13.5) && (w >= -13.5)) && ((w2 <= 50) && (w2 >= -8)) && (clos.X <= 100 && clos.Y <= 100))
                                            Scr_Mos.Click();
                                    }
                                    else if (tg_dist <= 200)
                                    {
                                        if (((w <= 9.5) && (w >= -9.5)) && ((w2 <= 35) && (w2 >= -8)) && (clos.X <= 150 && clos.Y <= 150))
                                            Scr_Mos.Click();
                                        else if (((w <= 8) && (w >= -8)) && ((w2 <= 25) && (w2 >= -4)) && (clos.X <= 200 && clos.Y <= 200))
                                            Scr_Mos.Click();
                                    }
                                    else if(tg_dist <= 300)
                                        if (((w <= 5) && (w >= -5)) && ((w2 <= 20) && (w2 >= -2)) && (clos.X <= 300 && clos.Y <= 300))
                                            Scr_Mos.Click();
                                }
                                
                            }
                            tg_m = false;
                        });
                        sss.Start();
                    }
                    ImGui.EndChild();
                }
                else if (menu == 4)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("Auto_farm", new Vector2(500, 700), true);
                    ImGui.Text("Function(Auto_farm)");

                    ImGui.Separator();
                    ImGui.EndChild();
                }
                else if (menu == 5)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("Esp", new Vector2(500, 700), true);
                    ImGui.Text("Function(Esp)");
                    ImGui.Separator();
                    ImGui.SetCursorPos(new Vector2(225, 30));
                    ImGui.Text("ESP");
                    if(ImGui.Checkbox("Enable", ref esp_flagsex))
                    {
                        if (esp_flagsex)
                            espaw = true;
                        else if (!FOV_flagsex && !redare)
                            espaw = false;
                    }                   
                    ImGui.Checkbox("Nickname", ref nickname);
                    ImGui.Checkbox("Health", ref heal_flag);
                    ImGui.Checkbox("Center_Lines", ref lines);
                    ImGui.Checkbox("Down_Lines", ref lines2);
                    ImGui.Checkbox("Top_Lines", ref tp_linq);
                    ImGui.Checkbox("Square", ref sq);
                    ImGui.SliderFloat("Square size", ref square_size,1,10);
                    ImGui.Checkbox("Circle", ref ecl);
                    ImGui.Checkbox("skeleton", ref sk);
                    ImGui.Checkbox("Team Check", ref esp_team_check);
                    ImGui.Checkbox("Distance", ref esp_distance);
                    ImGui.Checkbox("Show team", ref show_team);
                    ImGui.Checkbox("skeleton_2(coming)", ref sk2);
                    ImGui.NewLine();
                    ImGui.Text("                         ESP(settings)");
                    if (ImGui.ColorEdit4("Nickname color", ref suport_nik_cvet))
                        nik_cvet = ImGui.ColorConvertFloat4ToU32(suport_nik_cvet);
                    if (ImGui.ColorEdit4("Main color", ref suport_cvet))
                        cvet = ImGui.ColorConvertFloat4ToU32(suport_cvet);
                    if(ImGui.ColorEdit4("Team color", ref team_cl))
                        team_color = ImGui.ColorConvertFloat4ToU32(team_cl);
                    if (ImGui.ColorEdit4("Team Nickname color", ref team_cl2))
                        team_color2 = ImGui.ColorConvertFloat4ToU32(team_cl2);
                    ImGui.NewLine();
                    ImGui.Text("                             Radar");
                    if(ImGui.Checkbox("Radar", ref redare))
                    {
                        if (redare)
                            espaw = true;
                        else if(!FOV_flagsex && !esp_flagsex)
                            espaw = false;
                    }
                    ImGui.SliderFloat("Size_Map_X", ref radar_size.X, 100, 1910);
                    ImGui.SliderFloat("Size_Map_Y", ref radar_size.Y, 100, 1070);
                    ImGui.ListBox("Map design",ref map_dis, map_disain,map_disain.Length);
                    ImGui.Checkbox("Visible map", ref map_vis);
                    ImGui.Checkbox("_Team Check", ref esp_team_check);
                    ImGui.SliderFloat("Size_Persons", ref per_x, 1, 20);
                    if (ImGui.ColorEdit4("Me color", ref radar_me))
                        rd_1 = ImGui.ColorConvertFloat4ToU32(radar_me);
                    if (ImGui.ColorEdit4("Enemy color", ref radar_no_me))
                        rd_2 = ImGui.ColorConvertFloat4ToU32(radar_no_me);
                    if (ImGui.ColorEdit4("Map color", ref map_color))
                        rd_map = ImGui.ColorConvertFloat4ToU32(map_color);                    
                    ImGui.EndChild();
                }
                else if (menu == 6)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("Gui Settings", new Vector2(500, 700), true);
                    ImGui.SetCursorPos(new Vector2(210, 10));
                    ImGui.Text("Gui(settings)");
                    ImGui.Separator();
                    ImGui.ColorEdit4("Text",ref gui_lab_txt);
                    ImGui.ColorEdit4("Main", ref gui_lab_bbt);
                    if(ImGui.Checkbox("StreamProof",ref st_prof))
                    {
                        if (st_prof)
                            the_host = 0x11;
                        else
                            the_host = 0;
                    }
                    ImGui.NewLine();
                    ImGui.Text("FFlags");
                    if (ImGui.Checkbox("DebugDrawBroadPhaseAABBs", ref flag_1))
                    {
                        if (flag_1)
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x775B0F8, 999999999);//DebugDrawBroadPhaseAABBs - on
                        else
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x775B0F8, 0);//DebugDrawBroadPhaseAABBs - off
                    }
                    if (ImGui.Checkbox("DebugDrawBvhNodes", ref flag_2))
                    {
                        if (flag_2)
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x775B038, 999999999);//DebugDrawBvhNodes - on
                        else
                            local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x775B038, 0);//DebugDrawBvhNodes - off
                    }
                    ImGui.NewLine();
                    ImGui.Text("                               Config");
                    if (ImGui.Button("  Save Config  "))
                    {
                        Config_sys.Save();
                    }
                    ImGui.NewLine();
                    ImGui.Text("configs\n{");
                    string[] files = Directory.GetFiles("Configs");
                    for (int i = 0; i < files.Length; i++)
                    {
                        ImGui.Text(files[i]);
                        ImGui.SameLine();
                        if(ImGui.Button($"Load_{i}"))
                        {
                            StreamReader config = File.OpenText(files[i]);
                            int the_pit = 0;
                            while(true)
                            {
                                string st = config.ReadLine();
                                if (st == null) break;
                                Config_sys.Load(st, the_pit);                                
                                the_pit++;
                            }
                            config.Close();
                        }
                    }
                    ImGui.Text("}");  

                    ImGui.EndChild();
                }
                else if (menu == 7)
                {
                    ImGui.SetCursorPos(new Vector2(20, 80));
                    ImGui.BeginChild("Gui Settings", new Vector2(500, 700), true);
                    ImGui.SetCursorPos(new Vector2(210, 10));
                    ImGui.Text("Players");
                    ImGui.Separator();                   
                    if (ImGui.Button($"                           Stop Spectate                           "))
                    {
                        var sub = local.ReadPointer(base_s._workspace().address + offsets.Camera);
                        var w = Player_Modules.Character_LocalPLayer().address;
                        memory.write<nint>(sub + offsets.CameraSubject, w);
                    }
                    int pl = 1;
                    nint me_name = Player_Modules.LocalPlayer().address;
                    foreach (var child in Player_Modules._players().getchildren())
                    {
                        if(child.address != me_name)
                        {
                            ImGui.NewLine();
                            ImGui.Text($"{pl}. {child.name()}");
                            ImGui.SameLine();
                            if(ImGui.Button($"Spectate_{pl}"))
                            {
                                var sub = local.ReadPointer(base_s._workspace().address + offsets.Camera);
                                var w = local.ReadPointer(child.address + Offsets2.Player.Character);
                                memory.write<nint>(sub + offsets.CameraSubject, w);
                            }
                            ImGui.SameLine();
                            if (ImGui.Button($"Teleport_{pl}"))
                            {
                                var w = local.ReadPointer(child.address + Offsets2.Player.Character);
                                instance a = new instance(w);
                                var awe = local.ReadPointer(a.findfirstchild("Head").address + offsets.Primitive);
                                Vector3 awqq = local.ReadVec(awe + offsets.Position);
                                CFrame_a.Pre_Tp(awqq.X, awqq.Y, awqq.Z);
                            }
                            ImGui.SameLine();
                            if (ImGui.Button($"Profile_{pl}"))
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = $"https://www.roblox.com/users/{local.ReadULong(child.address + offsets.UserId)}/profile",
                                    UseShellExecute = true
                                });
                            }
                            pl++;
                        }
                    }
                    ImGui.EndChild();
                }
                ImGui.End();
            }
            if (espaw)
            {
                ImGui.SetNextWindowPos(new Vector2(0, 0));
                ImGui.SetNextWindowSize(new Vector2(1920, 1080));
                ImGui.Begin("esp)lobi", ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoBackground | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMouseInputs);
                ImDrawListPtr draw = ImGui.GetWindowDrawList();
                if(FOV_flagsex)
                {
                    var aqw = Scr_Mos.GetMousePosition();
                    draw.AddCircle(new Vector2(aqw.X, aqw.Y), FVW, fv_cla,0,oqw);
                }
                if (esp_flagsex || redare)
                {
                    var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                    var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                    var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                    Vector3 aqsw = new Vector3(0,0,0);
                    if (esp_distance || redare)
                    {
                        var pr = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                        aqsw = local.ReadVec(pr + offsets.Position);
                        if(redare)
                        {
                            if (map_vis)
                            {
                                if (map_dis == 0)
                                    draw.AddRect(new Vector2(10, 10), new Vector2(radar_size.X, radar_size.Y), rd_map, 10, ImDrawFlags.None, 4);
                                else if (map_dis == 1)
                                    draw.AddRectFilled(new Vector2(10, 10), new Vector2(radar_size.X, radar_size.Y), rd_map, 10);
                            }
                            draw.AddRectFilled(new Vector2((radar_size.X + 10) / 2, (radar_size.Y + 10) / 2), new Vector2((radar_size.X + 10) / 2 + per_x, (radar_size.Y + 10) / 2 + per_x), rd_1, 10);
                        }
                    }
                    var name_me = Player_Modules.LocalPlayer().address;
                    foreach (var i in Player_Modules._players().getchildren())
                    {                       
                        if (i.address != name_me)
                        {
                            st_flag = cvet;
                            st_flag2 = nik_cvet;
                            if(esp_team_check || show_team)
                            {
                                var team = local.ReadPointer(name_me + Offsets.Player.Team);
                                var team_pl = local.ReadPointer(i.address + Offsets.Player.Team);
                                if (team == team_pl)
                                {
                                    if (esp_team_check)
                                        continue;
                                    else if (show_team)
                                    {
                                        st_flag = team_color;
                                        st_flag2 = team_color2;
                                    }
                                }                                    
                            }
                            var ch3 = local.ReadPointer(i.address + Offsets2.Player.Character);
                            if (ch3 == 0) continue;
                            var s3 = new instance(ch3);
                            byte bae = 7;
                            if (sk || sq)
                            {
                                if (!heal_flag)
                                    bae = 1;
                                else
                                    bae = 0;
                            }
                            else if (heal_flag)
                                bae = 5;
                            else if (!nickname && !heal_flag && !lines && !lines2 && !sk && !ecl && !sq && !esp_distance && !redare && !tp_linq)
                                continue;
                            else if (redare || nickname || lines || lines2 || ecl || esp_distance || tp_linq)
                                bae = 6;
                            if (bae != 7)
                            {
                                foreach (var child in s3.getchildren())
                                {
                                    if (bae == 7) break;
                                    var name = child.name();
                                    if (name == "Head")
                                    {
                                        bae++;
                                        var prim = local.ReadPointer(child.address + offsets.Primitive);
                                        Vector3 pos = local.ReadVec(prim + offsets.Position);
                                        sa3 = Scr_Mos.world_to_screen(pos, dim, dim1);
                                        if(esp_distance)
                                            ssiaqw = (int)(Math.Abs(aqsw.X - pos.X) + Math.Abs(aqsw.Y - pos.Y) + Math.Abs(aqsw.Z - pos.Z));
                                        if (redare)
                                            pl_pos_head = pos;
                                    }
                                    else if (name == "Humanoid" && heal_flag)
                                    {
                                        bae++;
                                        hea = local.ReadFloat(child.address + offsets.Health);
                                    }
                                    else if (sk || sq)
                                    {
                                        if (name == "UpperTorso" || name == "Torso")
                                        {
                                            bae++;
                                            var priz2 = local.ReadPointer(child.address + offsets.Primitive);
                                            fuck_yeeee = Scr_Mos.world_to_screen(local.ReadVec(priz2 + offsets.Position), dim, dim1);
                                        }
                                        else if (name == "Left Leg" || name == "LeftFoot")
                                        {
                                            bae++;
                                            nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                            part1 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                        }
                                        else if (name == "Right Leg" || name == "RightFoot")
                                        {
                                            bae++;
                                            nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                            part2 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                        }
                                        else if (name == "Left Arm" || name == "LeftHand")
                                        {
                                            bae++;
                                            nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                            part3 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                        }
                                        else if (name == "Right Arm" || name == "RightHand")
                                        {
                                            bae++;
                                            nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                            part4 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                        }

                                    }

                                }
                                if(esp_flagsex)
                                if (sa3.X >= 0 && sa3.Y >= 0 && sa3.X <= 1920 && sa3.Y <= 1080)
                                {
                                    if (nickname)
                                    {
                                        string name_isq = i.name();
                                        if (name_isq.Length > 1)
                                        {
                                            if (nickname && heal_flag && esp_distance)
                                                draw.AddText(new Vector2(sa3.X - 80f, sa3.Y - 25f), st_flag2, $"{name_isq} | HP:{hea} | {ssiaqw}m");
                                            else if (nickname && heal_flag)
                                                draw.AddText(new Vector2(sa3.X - 50f, sa3.Y - 25f), st_flag2, $"{name_isq} | HP:{hea}");
                                            else if (nickname && esp_distance)
                                                draw.AddText(new Vector2(sa3.X - 50f, sa3.Y - 25f), st_flag2, $"{name_isq} | {ssiaqw}m");
                                            else
                                                draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), st_flag2, name_isq);
                                        }
                                    }
                                    else if (heal_flag)
                                    {
                                        if(esp_distance)
                                            draw.AddText(new Vector2(sa3.X - 50f, sa3.Y - 25f), st_flag2, $"HP:{hea} | {ssiaqw}m");
                                        else
                                            draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), st_flag2, $"HP:{hea}");
                                    }
                                    else if(esp_distance)
                                        draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), st_flag2, $"{ssiaqw}m");
                                    if (lines)
                                        draw.AddLine(new Vector2(960, 540), sa3, st_flag);
                                    if (lines2)
                                        draw.AddLine(new Vector2(960, 1080), sa3, st_flag);
                                    if (tp_linq)
                                        draw.AddLine(new Vector2(960, 0), sa3, st_flag);                                   
                                    if (ecl)
                                        draw.AddCircle(sa3, 30, st_flag);
                                    if (sk)
                                        draw.AddLine(fuck_yeeee, sa3, st_flag);                                                                        
                                }
                                if (redare)
                                {                                   
                                    var s = aqsw - pl_pos_head;
                                    float x = s.X + (radar_size.X + 10) / 2;
                                    float z = s.Z + (radar_size.Y + 10) / 2;
                                    if(x <= radar_size.X && z <= radar_size.Y && x >= 10 && z >= 10)
                                        draw.AddRectFilled(new Vector2(x, z), new Vector2(x + per_x, z + per_x), rd_2, 10);
                                }
                                if ((sk || sq) && esp_flagsex)
                                {
                                    if (fuck_yeeee.X >= 0 && fuck_yeeee.X <= 1920 && fuck_yeeee.Y >= 0 && fuck_yeeee.Y <= 1080)
                                    {
                                        if (sk)
                                        {
                                            float pos1 = (sa3.Y - fuck_yeeee.Y) / 2;
                                            draw.AddLine(fuck_yeeee, part1, st_flag);
                                            draw.AddLine(fuck_yeeee, part2, st_flag);
                                            draw.AddLine(new Vector2(fuck_yeeee.X, fuck_yeeee.Y + pos1), new Vector2(part3.X, part3.Y + pos1), st_flag);
                                            draw.AddLine(new Vector2(part3.X, part3.Y + pos1), part3, st_flag);
                                            draw.AddLine(new Vector2(fuck_yeeee.X, fuck_yeeee.Y + pos1), new Vector2(part4.X, part4.Y + pos1), st_flag);
                                            draw.AddLine(new Vector2(part4.X, part4.Y + pos1), part4, st_flag);
                                        }
                                        if(sq)
                                        {
                                            draw.AddRect(new Vector2(part2.X + (part4.X - part2.X),part2.Y), new Vector2(part3.X, part3.Y + (sa3.Y - part3.Y)), st_flag,0,ImDrawFlags.None, square_size);
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                    ImGui.End();
                }
                
            }
        }
    }
}










