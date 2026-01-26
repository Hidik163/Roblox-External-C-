using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using ClickableTransparentOverlay;
using H163_ext_test;
using ImGuiNET;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D11;
using Shoto_tyt_esti;
using Swed64;
using Vortice.Mathematics;
namespace H163_ext_test
{
    public class RenderClass : Overlay
    {
        string[] cl_gr = { "White", "Black", "Light-Green", "Blue", "Green", "Pink", "Black-blue", "Purple", "Black-pink", "Turquoise", "Grey", "Light-Green-2", "Black-Green", "Orange" };
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
        static Swed local = new Swed("RobloxPlayerBeta");
        Vector4 suport_cvet = new Vector4(1, 1, 0, 1);
        Vector4 suport_nik_cvet = new Vector4(0, 1, 0, 1);
       


        protected override void Render()
        {
            
            if (memory.GetAsyncKeyState(0x11) < 0) //https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
            {
                hide_gui = !hide_gui;
                Thread.Sleep(200);
            }
            if (hide_gui)
            {
                ImGui.SetNextWindowSize(new Vector2(600, 800));
                ImGuiStylePtr style = ImGui.GetStyle();
                style.WindowBorderSize = 2;
                style.WindowRounding = 6;
                style.FrameRounding = 3;
                style.Colors[(int)ImGuiCol.Button] = new Vector4(0.5f, 0.5f, 0, 1);
                style.Colors[(int)ImGuiCol.Text] = new Vector4(0.9f, 0.9f, 0, 1);
                style.Colors[(int)ImGuiCol.Border] = new Vector4(0.5f, 0.5f, 0, 1);
                style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.5f, 0.5f, 0, 1);
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
                ImGui.SetCursorPos(new Vector2(50, 30));
                if (ImGui.Button("Player"))
                {
                    menu = 1;

                }
                ImGui.SetCursorPos(new Vector2(130, 30));
                if (ImGui.Button("World"))
                {
                    menu = 2;
                }
                ImGui.SetCursorPos(new Vector2(210, 30));
                if (ImGui.Button("AimBot"))
                {
                    menu = 3;
                }
                ImGui.SetCursorPos(new Vector2(290, 30));
                if (ImGui.Button("Auto_farm"))
                {
                    menu = 4;
                }
                ImGui.SetCursorPos(new Vector2(400, 30));
                if (ImGui.Button("Esp"))
                {
                    menu = 5;
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
                            }
                            lock_walk_mask = false;
                        });
                        sped.Start();
                    }
                    ImGui.SliderFloat("JumpPower", ref power, 0, 400);
                    ImGui.SameLine();
                    if (ImGui.Button("Set"))
                        Humanoid.JumpPower(power);
                    ImGui.Checkbox("NoClip", ref noclip);
                    if (noclip && !noclip_mask)
                    {
                        noclip_mask = true;
                        Thread sped = new Thread(() =>
                        {
                            while (noclip)
                            {
                                Player_Modules.NoClip();
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
                    ImGui.Checkbox("Velocity Walk", ref V_walk);
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
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * 200, -1, cam.LookVector.Z * -200);
                                }
                                if ((memory.GetAsyncKeyState(0x53) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.LookVector.X * -200, -1, cam.LookVector.Z * 200);
                                }
                                if ((memory.GetAsyncKeyState(0x41) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * -200, -1, cam.RightVector.Z * 200);
                                }
                                if ((memory.GetAsyncKeyState(0x44) & 0x8000) != 0)
                                {
                                    CFrame_a.CFrame cam = memory.read<CFrame_a.CFrame>(base_s.Camera() + Offsets.Camera.Rotation);
                                    Velocity.Set_AssemblyLinearVelocity(cam.RightVector.X * 200, -1, cam.RightVector.Z * -200);
                                }
                            }
                            V_walk_mask = false;
                        });
                        fly2.Start();
                    }
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
                            while (hit)
                            {
                                foreach (var child in Player_Modules._players().getchildren())
                                {
                                    if (child.name() != Player_Modules.LocalPlayer().name())
                                    {
                                        var c = local.ReadPointer(child.address + Offsets2.Player.Character);
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
                            while (aim)
                            {
                                if ((memory.GetAsyncKeyState(0x02) & 0x8000) != 0)
                                {  
                                    var my = local.ReadPointer(Player_Modules.Character_LocalPLayer().findfirstchild("Head").address + offsets.Primitive);
                                    Vector3 pss = local.ReadVec(my + offsets.Position);
                                    Vector2 a = new Vector2(-1, -1);
                                    float closestDistance = float.MaxValue;
                                    var name = Player_Modules.LocalPlayer().name();
                                    var aqw = Scr_Mos.GetMousePosition();
                                    foreach (var child in Player_Modules._players().getchildren())
                                    {
                                        if (child.name() != name)
                                        {
                                            var ca = local.ReadPointer(child.address + Offsets2.Player.Character);
                                            if (ca == 0) continue;
                                            instance a2 = new instance(ca);
                                            if (local.ReadFloat(a2.findfirstchild("Humanoid").address + offsets.Health) > 0)
                                            {
                                                var head_prim = local.ReadPointer(a2.findfirstchild("Head").address + offsets.Primitive);
                                                Vector3 pos2 = local.ReadVec(head_prim + offsets.Position);                                               
                                                Vector3 raznica = new Vector3(Math.Abs(pss.X - pos2.X), Math.Abs(pss.Y - pos2.Y), Math.Abs(pss.Z - pss.Z));
                                                if (raznica.X < distance_work && raznica.Y < distance_work && raznica.Z < distance_work)
                                                {
                                                    var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                                                    var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                                                    Vector2 q = Scr_Mos.world_to_screen(pos2, dim, dim1);
                                                    if (q.X != -1)
                                                    {
                                                        int x = aqw.X - (int)q.X;
                                                        int y = aqw.Y - (int)q.Y;
                                                        float dist = (float)Math.Sqrt(x * x + y * y);
                                                        if (dist < closestDistance)
                                                        {
                                                            closestDistance = dist;
                                                            a = q;
                                                        }
                    
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (a.X != -1)
                                    {
                                        int w = aqw.X - (int)a.X;
                                        int w2 = aqw.Y - (int)a.Y;
                                        Scr_Mos.MoveMouse(-w / 2, -w2 / 2);
                                    }
                                }
                    
                            }
                            aim_m = false;
                        });
                        sss.Start();
                    }
                    ImGui.SliderFloat("Distance", ref distance_work, 0, 1000);
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
                    ImGui.Checkbox("Enable", ref espaw);
                    ImGui.Checkbox("Nickname", ref nickname);
                    ImGui.Checkbox("Center_Lines", ref lines);
                    ImGui.Checkbox("Down_Lines", ref lines2);
                    ImGui.Checkbox("Square", ref sq);
                    ImGui.Checkbox("Circle", ref ecl);
                    ImGui.Checkbox("skeleton", ref sk);
                    ImGui.Checkbox("skeleton_2(coming)", ref sk2);                    
                    ImGui.EndChild();
                }
                ImGui.End();
            }
            if (espaw)
            {
                uint cvet = ImGui.ColorConvertFloat4ToU32(suport_cvet);
                uint nik_cvet = ImGui.ColorConvertFloat4ToU32(suport_nik_cvet);
                ImGui.SetNextWindowPos(new Vector2(0, 0));
                ImGui.SetNextWindowSize(new Vector2(1920, 1080));
                ImGui.Begin("esp)lobi", ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoBackground | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMouseInputs);
                ImDrawListPtr draw = ImGui.GetWindowDrawList();
                var vis = local.ReadPointer(local.GetModuleBase("RobloxPlayerBeta.exe") + offsets.VisualEnginePointer);
                var dim = memory.read<Vector2>(vis + offsets.Dimensions);
                var dim1 = memory.read<Matrix4x4>(vis + offsets.viewmatrix);
                foreach (var i in Player_Modules._players().getchildren())
                {
                    if (i.name() != Player_Modules.LocalPlayer().name() && i.name() != null)
                    {                        
                        var ch3 = local.ReadPointer(i.address + Offsets2.Player.Character);
                        if (ch3 == 0) continue;                        
                        Vector2 pqwsar15 = new Vector2(-1, -1);
                        Vector2 pqwsar6 = new Vector2(-1, -1);
                        bool r15q = false;
                        var s3 = new instance(ch3);
                        var azyt3 = s3.findfirstchild("UpperTorso").address;
                        if (azyt3 != 0)
                        {
                            var priz3 = local.ReadPointer(azyt3 + offsets.Primitive);
                            pqwsar15 = Scr_Mos.world_to_screen(local.ReadVec(priz3 + offsets.Position), dim, dim1);
                            r15q = true;
                        }
                        if (!r15q)
                        {
                            var azyt2 = s3.findfirstchild("Torso").address;
                            if (azyt2 != 0)
                            {
                                var priz2 = local.ReadPointer(azyt2 + offsets.Primitive);
                                pqwsar6 = Scr_Mos.world_to_screen(local.ReadVec(priz2 + offsets.Position), dim, dim1);
                            }
                        }
                        if((pqwsar15.X >= 0 && pqwsar15.X <= 1920 && pqwsar15.Y >= 0 && pqwsar15.Y <= 1080) || (pqwsar6.X >= 0 && pqwsar6.X <= 1920 && pqwsar6.Y >= 0 && pqwsar6.Y <= 1080))
                        foreach (var child in s3.getchildren())
                        {
                            var name = child.name();
                            if (name == "Head" && (nickname || lines || lines2 || sq || ecl || sk))
                            {
                                var prim = local.ReadPointer(child.address + offsets.Primitive);
                                Vector2 sa3 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                if (nickname && i.name().Length > 1)
                                    draw.AddText(new Vector2(sa3.X - 20f, sa3.Y - 25f), nik_cvet, i.name());
                                if (lines)
                                    draw.AddLine(new Vector2(960, 540), sa3, cvet);
                                if (lines2)
                                    draw.AddLine(new Vector2(960, 1080), sa3, cvet);
                                if (sq)
                                    draw.AddRect(new Vector2(sa3.X - 20, sa3.Y + 40), new Vector2(sa3.X + 20, sa3.Y - 10), cvet);
                                if (ecl)
                                    draw.AddCircle(sa3, 30, cvet);
                                if(sk && !r15q)
                                    draw.AddLine(pqwsar6, sa3, cvet);
                                else if(sk)
                                    draw.AddLine(pqwsar15, sa3, cvet);
                                
                            }
                            if (sk && !r15q)
                            {
                                if (name == "Left Leg" || name == "Right Leg" || name == "Left Arm" || name == "Right Arm")
                                {
                                    nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                    Vector2 sa3 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                    draw.AddLine(pqwsar6, sa3, cvet);
                                }                                
                            }
                            else if (sk)
                            {
                                if (name == "LeftFoot" || name == "RightFoot" || name == "LeftHand"|| name == "RightHand")
                                {
                                    nint prim = local.ReadPointer(child.address + offsets.Primitive);
                                    Vector2 sa3 = Scr_Mos.world_to_screen(local.ReadVec(prim + offsets.Position), dim, dim1);
                                    draw.AddLine(pqwsar15, sa3, cvet);
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


