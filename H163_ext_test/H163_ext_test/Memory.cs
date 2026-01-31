using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using Swed64;
namespace H163_ext_test
{
    //https://offsets.ntgetwritewatch.workers.dev/offsets.hpp
    //Roblox Version: version-db4634f0e27d4d36
    public static class offsets
    {
    
    public static readonly int Adornee = 0xD0;
    public static readonly int Anchored = 0x1AE;
    public static readonly int AnchoredMask = 0x2;
    public static readonly int AnimationId = 0xD0;
    public static readonly int AttributeToNext = 0x58;
    public static readonly int AttributeToValue = 0x18;
    public static readonly int AutoJumpEnabled = 0x1DB;
    public static readonly int BanningEnabled = 0x14C;
    public static readonly int BeamBrightness = 0x190;
    public static readonly int BeamColor = 0x120;
    public static readonly int BeamLightEmission = 0x19C;
    public static readonly int BeamLightInfuence = 0x1A0;
    public static readonly int CFrame = 0xC0;
    public static readonly int Camera = 0x460;
    public static readonly int CameraMaxZoomDistance = 0x310;
    public static readonly int CameraMinZoomDistance = 0x314;
    public static readonly int CameraMode = 0x318;
    public static readonly int CameraPos = 0x11C;
    public static readonly int CameraRotation = 0xF8;
    public static readonly int CameraSubject = 0xE8;
    public static readonly int CameraType = 0x158;
    public static readonly int CanCollide = 0x1AE;
    public static readonly int CanCollideMask = 0x8;
    public static readonly int CanTouch = 0x1AE;
    public static readonly int CanTouchMask = 0x10;
    public static readonly int CharacterAppearanceId = 0x2B8;
    public static readonly int Children = 0x70;
    public static readonly int ChildrenEnd = 0x8;
    public static readonly int ClassDescriptor = 0x18;
    public static readonly int ClassDescriptorToClassName = 0x8;
    public static readonly int ClickDetectorMaxActivationDistance = 0x100;
    public static readonly int ClockTime = 0x1B8;
    public static readonly int CreatorId = 0x188;
    public static readonly int DataModelDeleterPointer = 0x8014E90;
    public static readonly int DataModelPrimitiveCount = 0x438;
    public static readonly int DataModelToRenderView1 = 0x1D0;
    public static readonly int DataModelToRenderView2 = 0x8;
    public static readonly int DataModelToRenderView3 = 0x28;
    public static readonly int DecalTexture = 0x198;
    public static readonly int Deleter = 0x10;
    public static readonly int DeleterBack = 0x18;
    public static readonly int Dimensions = 0x720;
    public static readonly int DisplayName = 0x130;
    public static readonly int EvaluateStateMachine = 0x1DD;
    public static readonly int FFlagList = 0x7B0AA38;
    public static readonly int FFlagToValueGetSet = 0x30;
    public static readonly int FOV = 0x160;
    public static readonly int FakeDataModelPointer = 0x8014E88;
    public static readonly int FakeDataModelToDataModel = 0x1C0;
    public static readonly int FogColor = 0xFC;
    public static readonly int FogEnd = 0x134;
    public static readonly int FogStart = 0x138;
    public static readonly int ForceNewAFKDuration = 0x1F8;
    public static readonly int FramePositionOffsetX = 0x51C;
    public static readonly int FramePositionOffsetY = 0x524;
    public static readonly int FramePositionX = 0x518;
    public static readonly int FramePositionY = 0x520;
    public static readonly int FrameRotation = 0x188;
    public static readonly int FrameSizeOffsetX = 0x540;
    public static readonly int FrameSizeOffsetY = 0x544;
    public static readonly int FrameSizeX = 0x538;
    public static readonly int FrameSizeY = 0x53C;
    public static readonly int FrameVisible = 0x5B1;
    public static readonly int GameId = 0x190;
    public static readonly int GameLoaded = 0x630;
    public static readonly int Gravity = 0x9C0;
    public static readonly int Health = 0x194;
    public static readonly int HealthDisplayDistance = 0x338;
    public static readonly int HipHeight = 0x1A0;
    public static readonly int HumanoidDisplayName = 0xD0;
    public static readonly int HumanoidState = 0x8D8;
    public static readonly int HumanoidStateId = 0x20;
    public static readonly int InputObject = 0x100;
    public static readonly int InsetMaxX = 0x100;
    public static readonly int InsetMaxY = 0x104;
    public static readonly int InsetMinX = 0xF8;
    public static readonly int InsetMinY = 0xFC;
    public static readonly int InstanceAttributePointer1 = 0x48;
    public static readonly int InstanceAttributePointer2 = 0x18;
    public static readonly int InstanceCapabilities = 0x280;
    public static readonly int JobEnd = 0x1D8;
    public static readonly int JobId = 0x138;
    public static readonly int JobStart = 0x1D0;
    public static readonly int Job_Name = 0x18;
    public static readonly int JobsPointer = 0x80AB3A0;
    public static readonly int JumpPower = 0x1B0;
    public static readonly int LocalPlayer = 0x130;
    public static readonly int LocalScriptByteCode = 0x1A8;
    public static readonly int LocalScriptBytecodePointer = 0x10;
    public static readonly int LocalScriptHash = 0x1B8;
    public static readonly int MaterialType = 0x246;
    public static readonly int MaxHealth = 0x1B4;
    public static readonly int MaxSlopeAngle = 0x1B8;
    public static readonly int MeshPartColor3 = 0x194;
    public static readonly int MeshPartTexture = 0x318;
    public static readonly int ModelInstance = 0x380;
    public static readonly int ModuleScriptByteCode = 0x150;
    public static readonly int ModuleScriptBytecodePointer = 0x10;
    public static readonly int ModuleScriptHash = 0x160;
    public static readonly int MoonTextureId = 0xE0;
    public static readonly int MousePosition = 0xEC;
    public static readonly int MouseSensitivity = 0x8074E80;
    public static readonly int MoveDirection = 0x158;
    public static readonly int Name = 0xB0;
    public static readonly int NameDisplayDistance = 0x344;
    public static readonly int NameSize = 0x10;
    public static readonly int OnDemandInstance = 0x40;
    public static readonly int OutdoorAmbient = 0x108;
    public static readonly int Parent = 0x68;
    public static readonly int PartSize = 0x1B0;
    public static readonly int Ping = 0xCC;
    public static readonly int PlaceId = 0x198;
    public static readonly int PlayerConfigurerPointer = 0x7FF3058;
    public static readonly int PlayerMouse = 0xD10;
    public static readonly int Position = 0xE4;
    public static readonly int Primitive = 0x148;
    public static readonly int PrimitiveValidateValue = 0x6;
    public static readonly int PrimitivesPointer1 = 0x3D8;
    public static readonly int PrimitivesPointer2 = 0x240;
    public static readonly int ProximityPromptActionText = 0xD0;
    public static readonly int ProximityPromptEnabled = 0x156;
    public static readonly int ProximityPromptGamepadKeyCode = 0x13C;
    public static readonly int ProximityPromptHoldDuraction = 0x140;
    public static readonly int ProximityPromptMaxActivationDistance = 0x148;
    public static readonly int ProximityPromptMaxObjectText = 0xF0;
    public static readonly int RenderJobToDataModel = 0x1B0;
    public static readonly int RenderJobToFakeDataModel = 0x38;
    public static readonly int RenderJobToRenderView = 0x218;
    public static readonly int RequireBypass = 0x0;
    public static readonly int RigType = 0x1C8;
    public static readonly int RootPartR15 = 0x620;
    public static readonly int RootPartR6 = 0x4C0;
    public static readonly int Rotation = 0xC8;
    public static readonly int RunContext = 0x148;
    public static readonly int Sandboxed = 0xC5;
    public static readonly int ScreenGuiEnabled = 0x50D;
    public static readonly int ScriptContext = 0x3F0;
    public static readonly int Sit = 0x1DC;
    public static readonly int SkyboxBk = 0x110;
    public static readonly int SkyboxDn = 0x140;
    public static readonly int SkyboxFt = 0x170;
    public static readonly int SkyboxLf = 0x1A0;
    public static readonly int SkyboxRt = 0x1D0;
    public static readonly int SkyboxUp = 0x200;
    public static readonly int SoundId = 0xE0;
    public static readonly int StarCount = 0x260;
    public static readonly int StringLength = 0x10;
    public static readonly int SunTextureId = 0x230;
    public static readonly int TagList = 0x0;
    public static readonly int TaskSchedulerMaxFPS = 0x1B0;
    public static readonly int TaskSchedulerPointer = 0x80AB1C8;
    public static readonly int Team = 0x290;
    public static readonly int TeamColor = 0xD0;
    public static readonly int TextLabelText = 0xAA8;
    public static readonly int TextLabelVisible = 0x5B1;
    public static readonly int Tool_Grip_Position = 0x494;
    public static readonly int Transparency = 0xF0;
    public static readonly int UserId = 0x2C8;
    public static readonly int Value = 0xD0;
    public static readonly int ValueGetSetToValue = 0xC0;
    public static readonly int Velocity = 0xF0;
    public static readonly int ViewportSize = 0x2E8;
    public static readonly int VisualEngine = 0x10;
    public static readonly int VisualEnginePointer = 0x7AF2720;
    public static readonly int VisualEngineToDataModel1 = 0x700;
    public static readonly int VisualEngineToDataModel2 = 0x1C0;
    public static readonly int WalkSpeed = 0x1D4;
    public static readonly int WalkSpeedCheck = 0x3C0;
    public static readonly int Workspace = 0x178;
    public static readonly int WorkspaceToWorld = 0x3D8;
    public static readonly int viewmatrix = 0x450;
    }
    public class memory  //copy paste
    {
        public static IntPtr handle = IntPtr.Zero;
        public static int pid = 0;


        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int fuckidk, bool a2, int processid);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr prc, IntPtr addy, byte[] buffer, int size, out int writen);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr prc, IntPtr addy, byte[] buffer, int size, out int writen);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        public static bool attach()
        {
            var processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0)
            {
                return false;
            }
            var process = processes[0];
            pid = process.Id;
            handle = OpenProcess(0x1F0FFF, false, pid);
            return handle != IntPtr.Zero;
        }
        public static T read<T>(IntPtr addy) where T : struct 
        {
            int size = Marshal.SizeOf(typeof(T));
            byte[] buff = new byte[size];
            ReadProcessMemory(handle, addy, buff, size, out int readlen);
            GCHandle gch = GCHandle.Alloc(buff, GCHandleType.Pinned);
            T value = Marshal.PtrToStructure<T>(gch.AddrOfPinnedObject());
            return value;
        }

        public static bool write<T>(IntPtr addy, T value) where T : struct 
        {
            int size = Marshal.SizeOf(typeof(T));
            byte[] buff = new byte[size];
            IntPtr pointer = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(value, pointer, false);
            Marshal.Copy(pointer, buff, 0, size);
            Marshal.FreeHGlobal(pointer);
            return WriteProcessMemory(handle, addy, buff, size, out int ffff) && ffff == size;
        }
        public static string readstring(IntPtr addy, int max = 200)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < max; i++)
            {
                byte[] buff = new byte[1];
                ReadProcessMemory(handle, (IntPtr)((long)addy + i), buff, 1, out int _);

                if (buff[0] == 0)
                    break;
                sb.Append((char)buff[0]);
            }
            return sb.ToString();
        }
    }

    public class instance 
    {
        public static Swed local = new Swed("RobloxPlayerBeta");
        public IntPtr address;
        
        public instance(IntPtr addy)
        {
            address = addy;
        }

        public string name()  //copy paste
        {
            var ptr = local.ReadPointer(address + offsets.Name);
            return ptr != IntPtr.Zero ? memory.readstring(ptr, Convert.ToString(ptr).Length) : string.Empty;
        }
        public instance parent()
        {
            return new instance(local.ReadPointer(address + offsets.Parent));
        }
        public string classname()
        {
            var obj = local.ReadPointer(address + offsets.ClassDescriptor);
            var obj2 = local.ReadPointer(obj + offsets.ClassDescriptorToClassName);
            return local.ReadString(obj2, Convert.ToString(obj2).Length);
        }

        public List<instance> getchildren()  //copy paste
        {
            var children = new List<instance>();
            var start = local.ReadPointer(address + offsets.Children);
            var end = local.ReadULong((IntPtr)start + offsets.ChildrenEnd);

            for (ulong ptr = local.ReadULong((IntPtr)start); ptr != end; ptr += 0x10)
            {
                var childaddy = local.ReadULong((IntPtr)ptr);
                children.Add(new instance((IntPtr)childaddy));
            }

            return children;
        }

        public instance findfirstchild(string name)  //copy paste
        {
            foreach (var child in getchildren())
            {
                if (child.name() == name)
                    return child;
            }
            return new instance(IntPtr.Zero);
        }

        
    }
}


