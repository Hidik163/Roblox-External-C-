using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using static Shoto_tyt_esti.CFrame_a;
namespace H163_ext_test
{
    public class RenderClass : Overlay
    {
        string[] cl_gr = { "White", "Black", "Light-Green", "Blue", "Default-Green", "Pink", "Black-blue", "Purple", "Black-pink", "Turquoise", "Grey", "Light-Green-2", "Black-Green", "Orange","Red", "Brown", "Light-purple", "Light-Blue" };
        int zis_color = 0;
        bool attach = false;
        bool lock_walk = false;
        bool lock_walk_mask = false;
        bool noclip = false;
        bool noclip_mask = false;
        bool inf_jump = false;
        bool inf_jump_m = false;
        bool no_cd = false;
        bool no_cd_m = false;
        bool fly = false;
        bool fly_m = false;
        bool V_walk = false;
        bool V_walk_mask = false;
        bool hit = false;
        bool hide_gui = true;
        bool hit_m = false;
        bool aim = false;
        bool aim_m = false;
        bool espaw = false;
        bool nickname = false;
        bool lines = false;
        bool lines2 = false;
        bool sq = false;
        bool ecl = false;
        bool sk = false;
        bool sk2 = false;
        bool ew = false;
        bool ew_m = false;
        bool dc = false;
        bool dc_m = false;
        bool kr = false;
        bool kr_m = false;
        bool de = false;
        bool de_m = false;
        bool tg = false;
        bool tg_m = false;
        bool FOV_flagsex = false;
        bool esp_flagsex = false;
        bool heal_flag = false;
        float distance_work = 75;
        float size_hit = 1;
        float gra = 0;
        float exp = 0;
        float sun_sz = 1;
        float moon_sz = 1;
        float as1 = 0;
        float as2 = 0;
        float as3 = 0;
        float blome = 0;
        float blome2 = 0;
        float blome3 = 0;
        float as4 = 0;
        float as5 = 0;
        float atm = 0;
        float atm2 = 0;
        float sun23 = 0;
        float fog1 = 0;
        float fog2 = 1000;
        float fvo = 1.7f;
        float z = 0;
        float z1 = 0;
        float z2 = 0;
        float iqwe = 5;
        float sde = 50;
        float kio = 10;
        float FVW = 100;
        float oqw = 1;
        Vector3 colfog = new Vector3(0,0,0);
        Vector3 atm3 = new Vector3(1, 1, 1);
        Vector3 sasd = new Vector3(1, 1, 1);
        Vector3 colorqwe = new Vector3(1, 1, 1);
        Vector3 c2 = new Vector3(1, 1, 1);
        Vector3 c3 = new Vector3(1, 1, 1);
        Vector3 c4 = new Vector3(1, 1, 1);
        Vector3 ale = new Vector3(1, 1, 1);
        Vector3 get_ale = new Vector3(1, 1, 1);
        int menu = 1;
        float speed = 22;
        float power = 16;
        float heqw = 0;
        float hea = 0;
        static Swed local = new Swed("RobloxPlayerBeta");
        static Vector4 suport_cvet = new Vector4(1, 1, 0, 1);
        static Vector4 suport_nik_cvet = new Vector4(0, 1, 0, 1);
        Vector4 gui_lab_bbt = new Vector4(0.5f,0.5f,0,1);
        Vector4 gui_lab_txt = new Vector4(0.9f, 0.9f, 0, 1);
        static Vector4 fov_color = new Vector4(0.5f, 0.5f, 0, 1);
        uint cvet = ImGui.ColorConvertFloat4ToU32(suport_cvet);
        uint nik_cvet = ImGui.ColorConvertFloat4ToU32(suport_nik_cvet);
        uint fv_cla = ImGui.ColorConvertFloat4ToU32(fov_color);
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
                local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x6848e04, 0);//PhysicsSenderMaxBandwidthBpsScaling
                de_m = true;
            }
            else if (!de)
            {
                local.WriteInt(local.GetModuleBase("RobloxPlayerBeta.exe") + 0x6848e04, 5);//PhysicsSenderMaxBandwidthBpsScaling
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
                if (ImGui.Button("AimBot"))
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
                    ImGui.Checkbox("Fly", ref fly);
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
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * 200, cam.UpVector.Z * -200, cam.LookVector.Z * -200);
                                }
                                else if ((memory.GetAsyncKeyState(0x53) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * -200, cam.UpVector.Z * 200, cam.LookVector.Z * 200);
                                }
                                else if ((memory.GetAsyncKeyState(0x41) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * -200, 0, cam.RightVector.Z * 200);
                                }
                                else if ((memory.GetAsyncKeyState(0x44) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * 200, 0, cam.RightVector.Z * -200);
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
                    ImGui.Text("HitBox Expander (head)");
                    ImGui.Checkbox("Enable_hit", ref hit);
                    ImGui.SliderFloat("Size", ref size_hit, 1, 100);
                    if (hit && !hit_m)
                    {
                        hit_m = true;
                        Thread hit12 = new Thread(() =>
                        {
                            string me_name = Player_Modules.LocalPlayer().name();
                            while (hit)
                            {
                                foreach (var child in Player_Modules._players().getchildren())
                                {
                                    if (child.name() != me_name)
                                    {
                                        var c = local.ReadPointer(child.address + Offsets2.Player.Character);
                                        if (c == 0) continue;
                                        var c2 = new instance(c);
                                        var q = local.ReadPointer(c2.findfirstchild("Head").address + offsets.Primitive);
                                        local.WriteVec(q + offsets.PartSize, new Vector3(size_hit, size_hit, size_hit));
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
                    if (aim && !aim_m)
                    {
                        aim_m = true;
                        Thread sss = new Thread(() =>
                        {
                            var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                            var name = Player_Modules.LocalPlayer().name();
                            while (aim)
                            {
                                if ((memory.GetAsyncKeyState(0x02) & 0x8000) != 0)
                                    {                                    
                                    var my = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                                    if (my == 0) continue;
                                    Vector3 pss = local.ReadVec(my + offsets.Position);
                                    Vector2 a = new Vector2(-1, -1);
                                    float closestDistance = float.MaxValue;
                                    var aqw = Scr_Mos.GetMousePosition();
                                    var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                                    var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                                    foreach (var child in Player_Modules._players().getchildren())
                                    {
                                        if (child.name() != name)
                                        {
                                            var ca = local.ReadPointer(child.address + Offsets2.Player.Character);
                                            if (ca == 0) continue;
                                            instance a2 = new instance(ca);
                                            nint hud = 0, head = 0;
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
                                                else if (ze_name == "Head")
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
                                                                }
                                                            }
                                                            else
                                                            {
                                                                closestDistance = dist;
                                                                a = q;
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
                                        Scr_Mos.MoveMouse(-w / 2, -w2 / 2);
                                    }
                                }
                                Thread.Sleep(1);
                            }                            
                            aim_m = false;
                        });
                        sss.Start();
                    }
                    ImGui.SliderFloat("Distance", ref distance_work, 0, 1000);
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
                    ImGui.SetCursorPos(new Vector2(210, 200));
                    ImGui.Text("TriggerBot");
                    ImGui.Checkbox("_Enable", ref tg);
                    if (tg && !tg_m)
                    {
                        tg_m = true;
                        Thread sss = new Thread(() =>
                        {
                            var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                            var name = Player_Modules.LocalPlayer().name();
                            while (tg)
                            {
                                var my = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                                if (my == 0) continue;
                                Vector3 pss = local.ReadVec(my + offsets.Position);
                                Vector2 a = new Vector2(-1, -1);
                                float closestDistance = float.MaxValue;
                                Vector2 clos = new Vector2(-1,-1);
                                var aqw = Scr_Mos.GetMousePosition();
                                var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                                var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                                foreach (var child in Player_Modules._players().getchildren())
                                {
                                    if (child.name() != name)
                                    {
                                        var ca = local.ReadPointer(child.address + Offsets2.Player.Character);
                                        if (ca == 0) continue;
                                        instance a2 = new instance(ca);
                                        nint hud = 0, head = 0;
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
                                    if (((w <= 21) && (w >= -21)) && ((w2 <= 80) && (w2 >= -8)) && (clos.X <= 25 && clos.Y <= 25))
                                        Scr_Mos.Click();
                                    else if (((w <= 17.5) && (w >= -17.5)) && ((w2 <= 70) && (w2 >= -8)) && (clos.X <= 50 && clos.Y <= 50))
                                        Scr_Mos.Click();
                                    else if (((w <= 13.5) && (w >= -13.5)) && ((w2 <= 50) && (w2 >= -8)) && (clos.X <= 100 && clos.Y <= 100))
                                        Scr_Mos.Click();
                                    else if (((w <= 9.5) && (w >= -9.5)) && ((w2 <= 35) && (w2 >= -8)) && (clos.X <= 150 && clos.Y <= 150))
                                        Scr_Mos.Click();
                                    else if (((w <= 8) && (w >= -8)) && ((w2 <= 25) && (w2 >= -4)) && (clos.X <= 200 && clos.Y <= 200))
                                        Scr_Mos.Click();
                                    else if (((w <= 5) && (w >= -5)) && ((w2 <= 20) && (w2 >= -2)) && (clos.X <= 300 && clos.Y <= 300))
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
                        else if (!FOV_flagsex)
                            espaw = false;
                    }                   
                    ImGui.Checkbox("Nickname", ref nickname);
                    ImGui.Checkbox("Health", ref heal_flag);
                    ImGui.Checkbox("Center_Lines", ref lines);
                    ImGui.Checkbox("Down_Lines", ref lines2);
                    ImGui.Checkbox("Square", ref sq);
                    ImGui.Checkbox("Circle", ref ecl);
                    ImGui.Checkbox("skeleton", ref sk);
                    ImGui.Checkbox("skeleton_2(coming)", ref sk2);
                    ImGui.SetCursorPos(new Vector2(190, 250));
                    ImGui.Text("ESP(settings)");
                    if(ImGui.ColorEdit4("Nickname color",ref suport_nik_cvet))
                        nik_cvet = ImGui.ColorConvertFloat4ToU32(suport_nik_cvet);
                    if(ImGui.ColorEdit4("Main color", ref suport_cvet))
                        cvet = ImGui.ColorConvertFloat4ToU32(suport_cvet);
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
                    string me_name = Player_Modules.LocalPlayer().name();
                    foreach (var child in Player_Modules._players().getchildren())
                    {
                        if(child.name() != me_name)
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
                if (esp_flagsex)
                {
                    var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                    var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                    var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                    string name_me = Player_Modules.LocalPlayer().name();
                    foreach (var i in Player_Modules._players().getchildren())
                    {
                        string name_isq = i.name();
                        if (name_isq != name_me)
                        {
                            var ch3 = local.ReadPointer(i.address + Offsets2.Player.Character);
                            if (ch3 == 0) continue;
                            var s3 = new instance(ch3);
                            byte bae;
                            if (sk)
                                bae = 0;
                            else if (heal_flag)
                                bae = 5;
                            else if (!nickname && !heal_flag && !lines && !lines2 && !sk && !ecl && !sq)
                                bae = 7;
                            else
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
                                        sa3 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                    }
                                    else if (name == "Humanoid" && heal_flag)
                                    {
                                        bae++;
                                        hea = local.ReadFloat(child.address + offsets.Health);
                                    }
                                    else if (sk)
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
                                if (sa3.X >= 0 && sa3.Y >= 0 && sa3.X <= 1920 && sa3.Y <= 1080)
                                {
                                    if (nickname && heal_flag)
                                    {
                                        if (name_isq.Length > 1)
                                            draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), nik_cvet, $"{hea}\n{name_isq}");
                                    }
                                    else if (heal_flag)
                                        draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), nik_cvet, $"{hea}");
                                    else if (nickname)
                                    {
                                        if (name_isq.Length > 1)
                                            draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), nik_cvet, name_isq);
                                    }
                                    if (lines)
                                        draw.AddLine(new Vector2(960, 540), sa3, cvet);
                                    if (lines2)
                                        draw.AddLine(new Vector2(960, 1080), sa3, cvet);
                                    if (sq)
                                        draw.AddRect(new Vector2(sa3.X - 20, sa3.Y + 40), new Vector2(sa3.X + 20, sa3.Y - 10), cvet);
                                    if (ecl)
                                        draw.AddCircle(sa3, 30, cvet);
                                    if (sk)
                                        draw.AddLine(fuck_yeeee, sa3, cvet);
                                }
                                if (sk)
                                    if (fuck_yeeee.X >= 0 && fuck_yeeee.X <= 1920 && fuck_yeeee.Y >= 0 && fuck_yeeee.Y <= 1080)
                                    {
                                        draw.AddLine(fuck_yeeee, part1, cvet);
                                        draw.AddLine(fuck_yeeee, part2, cvet);
                                        draw.AddLine(fuck_yeeee, part3, cvet);
                                        draw.AddLine(fuck_yeeee, part4, cvet);
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






