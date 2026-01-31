using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://imtheo.lol/Offsets/Offsets.hpp
//Roblox version: version-db4634f0e27d4d36
public static class Offsets
{
    public static class AnimationTrack
    {
        public static readonly int Animation = 0xd0;
        public static readonly int Animator = 0x118;
        public static readonly int IsPlaying = 0x538;
        public static readonly int Looped = 0xf5;
        public static readonly int Speed = 0xe4;
    }

    public static class BasePart
    {
        public static readonly int AssemblyAngularVelocity = 0xfc;
        public static readonly int AssemblyLinearVelocity = 0xf0;
        public static readonly int Color3 = 0x194;
        public static readonly int Material = 0x0;
        public static readonly int Position = 0xe4;
        public static readonly int Primitive = 0x148;
        public static readonly int PrimitiveFlags = 0x1ae;
        public static readonly int PrimitiveOwner = 0x210;
        public static readonly int Rotation = 0xc0;
        public static readonly int Shape = 0x1b1;
        public static readonly int Size = 0x1b0;
        public static readonly int Transparency = 0xf0;
        public static readonly int ValidatePrimitive = 0x6;
    }

    public static class ByteCode
    {
        public static readonly int Pointer = 0x10;
        public static readonly int Size = 0x20;
    }

    public static class Camera
    {
        public static readonly int CameraSubject = 0xe8;
        public static readonly int CameraType = 0x158;
        public static readonly int FieldOfView = 0x160;
        public static readonly int Position = 0x11c;
        public static readonly int Rotation = 0xf8;
        public static readonly int Viewport = 0x2ac;
    }

    public static class ClickDetector
    {
        public static readonly int MaxActivationDistance = 0x100;
        public static readonly int MouseIcon = 0xe0;
    }

    public static class DataModel
    {
        public static readonly int CreatorId = 0x188;
        public static readonly int GameId = 0x190;
        public static readonly int GameLoaded = 0x5f8;
        public static readonly int JobId = 0x138;
        public static readonly int PlaceId = 0x198;
        public static readonly int PlaceVersion = 0x1b4;
        public static readonly int PrimitiveCount = 0x438;
        public static readonly int ScriptContext = 0x3f0;
        public static readonly int ServerIP = 0x5e0;
        public static readonly int Workspace = 0x178;
    }

    public static class FFlags
    {
        public static readonly int DebugDisableTimeoutDisconnect = 0x6831f18;
        public static readonly int EnableLoadModule = 0x68277d8;
        public static readonly int PartyPlayerInactivityTimeoutInSeconds = 0x67efa4c;
        public static readonly int PhysicsSenderMaxBandwidthBps = 0x67efef4;
        public static readonly int PhysicsSenderMaxBandwidthBpsScaling = 0x67eff00;
        public static readonly int TaskSchedulerTargetFps = 0x7548670;
        public static readonly int WebSocketServiceEnableClientCreation = 0x683ec00;
        public static readonly int WorldStepMax = 0x67f37f8;
        public static readonly int WorldStepsOffsetAdjustRate = 0x67f37f4;
    }

    public static class FakeDataModel
    {
        public static readonly int Pointer = 0x8014e88;
        public static readonly int RealDataModel = 0x1c0;
    }

    public static class GuiObject
    {
        public static readonly int BackgroundColor3 = 0x548;
        public static readonly int BorderColor3 = 0x554;
        public static readonly int Image = 0xa00;
        public static readonly int LayoutOrder = 0x584;
        public static readonly int Position = 0x518;
        public static readonly int RichText = 0xaa8;
        public static readonly int Rotation = 0x188;
        public static readonly int ScreenGui_Enabled = 0x4cc;
        public static readonly int Size = 0x538;
        public static readonly int Text = 0xe08;
        public static readonly int TextColor3 = 0xeb8;
        public static readonly int Visible = 0x5b1;
    }

    public static class Humanoid
    {
        public static readonly int AutoRotate = 0x1d9;
        public static readonly int FloorMaterial = 0x190;
        public static readonly int Health = 0x194;
        public static readonly int HipHeight = 0x1a0;
        public static readonly int HumanoidState = 0x8d8;
        public static readonly int HumanoidStateID = 0x20;
        public static readonly int Jump = 0x1dd;
        public static readonly int JumpHeight = 0x1ac;
        public static readonly int JumpPower = 0x1b0;
        public static readonly int MaxHealth = 0x1b4;
        public static readonly int MaxSlopeAngle = 0x1b8;
        public static readonly int MoveDirection = 0x158;
        public static readonly int RigType = 0x1c8;
        public static readonly int Walkspeed = 0x1d4;
        public static readonly int WalkspeedCheck = 0x3c0;
    }

    public static class Instance
    {
        public static readonly int AttributeContainer = 0x48;
        public static readonly int AttributeList = 0x18;
        public static readonly int AttributeToNext = 0x58;
        public static readonly int AttributeToValue = 0x18;
        public static readonly int ChildrenEnd = 0x8;
        public static readonly int ChildrenStart = 0x70;
        public static readonly int ClassBase = 0x1400;
        public static readonly int ClassDescriptor = 0x18;
        public static readonly int ClassName = 0x8;
        public static readonly int Name = 0xb0;
        public static readonly int Parent = 0x68;
    }

    public static class Lighting
    {
        public static readonly int Ambient = 0xd8;
        public static readonly int Brightness = 0x120;
        public static readonly int ClockTime = 0x1b8;
        public static readonly int ColorShift_Bottom = 0xf0;
        public static readonly int ColorShift_Top = 0xe4;
        public static readonly int ExposureCompensation = 0x12c;
        public static readonly int FogColor = 0xfc;
        public static readonly int FogEnd = 0x134;
        public static readonly int FogStart = 0x138;
        public static readonly int GeographicLatitude = 0x190;
        public static readonly int OutdoorAmbient = 0x108;
    }

    public static class LocalScript
    {
        public static readonly int ByteCode = 0x1a8;
    }

    public static class MeshPart
    {
        public static readonly int MeshId = 0x2e8;
        public static readonly int Texture = 0x318;
    }

    public static class Misc
    {
        public static readonly int Adornee = 0x108;
        public static readonly int AnimationId = 0xd0;
        public static readonly int RequireLock = 0x0;
        public static readonly int StringLength = 0x10;
        public static readonly int Value = 0xd0;
    }

    public static class Model
    {
        public static readonly int PrimaryPart = 0x278;
        public static readonly int Scale = 0x164;
    }

    public static class ModuleScript
    {
        public static readonly int ByteCode = 0x150;
    }

    public static class MouseService
    {
        public static readonly int InputObject = 0x100;
        public static readonly int MousePosition = 0xec;
        public static readonly int SensitivityPointer = 0x8074e80;
    }

    public static class Player
    {
        public static readonly int CameraMode = 0x318;
        public static readonly int Country = 0x110;
        public static readonly int DisplayName = 0x130;
        public static readonly int Gender = 0xea0;
        public static readonly int LocalPlayer = 0x130;
        public static readonly int MaxZoomDistance = 0x310;
        public static readonly int MinZoomDistance = 0x314;
        public static readonly int ModelInstance = 0x380;
        public static readonly int Mouse = 0xd10;
        public static readonly int Team = 0x290;
        public static readonly int UserId = 0x2b8;
    }

    public static class PlayerConfigurer
    {
        public static readonly int OverrideDuration = 0x3b8;
        public static readonly int Pointer = 0x7ff3058;
    }

    public static class PlayerMouse
    {
        public static readonly int Icon = 0xe0;
        public static readonly int Workspace = 0x168;
    }

    public static class PrimitiveFlags
    {
        public static readonly int Anchored = 0x2;
        public static readonly int CanCollide = 0x8;
        public static readonly int CanTouch = 0x10;
    }

    public static class ProximityPrompt
    {
        public static readonly int ActionText = 0xd0;
        public static readonly int Enabled = 0x156;
        public static readonly int GamepadKeyCode = 0x13c;
        public static readonly int HoldDuration = 0x140;
        public static readonly int KeyCode = 0x144;
        public static readonly int MaxActivationDistance = 0x148;
        public static readonly int ObjectText = 0xf0;
        public static readonly int RequiresLineOfSight = 0x157;
    }

    public static class RenderView
    {
        public static readonly int DeviceD3D11 = 0x8;
        public static readonly int VisualEngine = 0x10;
    }

    public static class RunService
    {
        public static readonly int HeartbeatFPS = 0xc0;
        public static readonly int HeartbeatTask = 0xe8;
    }

    public static class Sky
    {
        public static readonly int MoonAngularSize = 0x25c;
        public static readonly int MoonTextureId = 0xe0;
        public static readonly int SkyboxBk = 0x110;
        public static readonly int SkyboxDn = 0x140;
        public static readonly int SkyboxFt = 0x170;
        public static readonly int SkyboxLf = 0x1a0;
        public static readonly int SkyboxOrientation = 0x250;
        public static readonly int SkyboxRt = 0x1d0;
        public static readonly int SkyboxUp = 0x200;
        public static readonly int StarCount = 0x260;
        public static readonly int SunAngularSize = 0x254;
        public static readonly int SunTextureId = 0x230;
    }

    public static class SpecialMesh
    {
        public static readonly int MeshId = 0x108;
        public static readonly int Scale = 0x164;
    }

    public static class StatsItem
    {
        public static readonly int Value = 0x1c8;
    }

    public static class TaskScheduler
    {
        public static readonly int FakeDataModelToDataModel = 0x1b0;
        public static readonly int JobEnd = 0x1d8;
        public static readonly int JobName = 0x18;
        public static readonly int JobStart = 0x1d0;
        public static readonly int MaxFPS = 0x1b0;
        public static readonly int Pointer = 0x80ab1c8;
        public static readonly int RenderJobToFakeDataModel = 0x38;
        public static readonly int RenderJobToRenderView = 0x218;
    }

    public static class Team
    {
        public static readonly int BrickColor = 0xd0;
    }

    public static class Textures
    {
        public static readonly int Decal_Texture = 0x198;
        public static readonly int Texture_Texture = 0x198;
    }

    public static class VisualEngine
    {
        public static readonly int Dimensions = 0x720;
        public static readonly int Pointer = 0x7af2720;
        public static readonly int ToDataModel1 = 0x700;
        public static readonly int ToDataModel2 = 0x1c0;
        public static readonly int ViewMatrix = 0x120;
    }

    public static class Workspace
    {
        public static readonly int CurrentCamera = 0x460;
        public static readonly int DistributedGameTime = 0x480;
        public static readonly int Gravity = 0x1d0;
        public static readonly int GravityContainer = 0x3d8;
        public static readonly int PrimitivesPointer1 = 0x3d8;
        public static readonly int PrimitivesPointer2 = 0x240;
        public static readonly int ReadOnlyGravity = 0x9c0;
    }


}

