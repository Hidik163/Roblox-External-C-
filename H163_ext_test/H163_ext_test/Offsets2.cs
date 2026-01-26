using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://dumper.jonah.cool/offsets.hpp
//Roblox version: version-0f5223fb6e7e4955
public static class Offsets2
{
    public static class VisualEngine
{
    public static readonly int FakeToRealDataModel = 0x1C0;
    public static readonly int Pointer = 0x7A7F950;
    public static readonly int RenderView = 0x800;
    public static readonly int ToFakeDataModel = 0x700;
    public static readonly int ViewMatrix = 0x180;
    public static readonly int WindowDimensions = 0x720;
}

public static class RenderView
{
    public static readonly int InvalidateLighting = 0x148;
}

public static class DataModel
{
    public static readonly int ClientReplicator = 0x3D8;
    public static readonly int CreatorId = 0x188;
    public static readonly int GameId = 0x190;
    public static readonly int GameLoaded = 0x5F8;
    public static readonly int JobId = 0x138;
    public static readonly int PlaceId = 0x198;
    public static readonly int RunService = 0x390;
    public static readonly int ServerIP = 0x5E0;
    public static readonly int UserInputService = 0x3A0;
    public static readonly int Workspace = 0x178;
}

public static class Instance
{
    public static readonly int AttributeContainer = 0x48;
    public static readonly int AttributeList = 0x18;
    public static readonly int AttributeToNext = 0x58;
    public static readonly int AttributeToValue = 0x18;
    public static readonly int ChildrenEnd = 0x8;
    public static readonly int ChildrenStart = 0x70;
    public static readonly int ClassDescriptor = 0x18;
    public static readonly int ClassName = 0x8;
    public static readonly int Name = 0xB0;
    public static readonly int Parent = 0x68;
}

public static class Workspace
{
    public static readonly int Camera = 0x460;
    public static readonly int Gravity = 0x9B8;
}

public static class Players
{
    public static readonly int LocalPlayer = 0x130;
}

public static class Player
{
    public static readonly int Character = 0x370;
    public static readonly int DisplayName = 0x130;
    public static readonly int Team = 0x280;
    public static readonly int UserId = 0x2A8;
}

public static class Team
{
    public static readonly int Color = 0xD0;
}

public static class BasePart
{
    public static readonly int CastShadow = 0xF5;
    public static readonly int Color3 = 0x194;
    public static readonly int Locked = 0xF6;
    public static readonly int Massless = 0xF7;
    public static readonly int Primitive = 0x148;
    public static readonly int Reflectance = 0xEC;
    public static readonly int Shape = 0x1B1;
    public static readonly int Transparency = 0xF0;
}

public static class Primitive
{
    public static readonly int AssemblyAngularVelocity = 0xFC;
    public static readonly int AssemblyLinearVelocity = 0xF0;
    public static readonly int Material = 0x246;
    public static readonly int Position = 0xE4;
    public static readonly int PrimitiveFlags = 0x1AE;
    public static readonly int Rotation = 0xC0;
    public static readonly int Size = 0x1B0;
}

public static class PrimitiveFlags
{
    public static readonly int Anchored = 0x2;
    public static readonly int CanCollide = 0x8;
    public static readonly int CanTouch = 0x10;
}

public static class Humanoid
{
    public static readonly int AutoJumpEnabled = 0x1D8;
    public static readonly int AutoRotate = 0x1D9;
    public static readonly int BreakJointsOnDeath = 0x1DB;
    public static readonly int FloorMaterial = 0x190;
    public static readonly int Health = 0x194;
    public static readonly int HealthDisplayDistance = 0x198;
    public static readonly int HipHeight = 0x1A0;
    public static readonly int IsWalking = 0x956;
    public static readonly int Jump = 0x1DD;
    public static readonly int JumpHeight = 0x1AC;
    public static readonly int JumpPower = 0x1B0;
    public static readonly int MaxHealth = 0x1B4;
    public static readonly int MaxSlopeOffset = 0x1B8;
    public static readonly int MoveDirection = 0x158;
    public static readonly int NameDisplayDistance = 0x1BC;
    public static readonly int RequiresNeck = 0x1E0;
    public static readonly int RigType = 0x1C8;
    public static readonly int UseJumpPower = 0x1E3;
    public static readonly int WalkSpeed = 0x1D4;
    public static readonly int WalkSpeedCheck = 0x3C0;
    public static readonly int WalkToPoint = 0x17C;
}

public static class Mesh
{
    public static readonly int MeshId = 0x2E8;
    public static readonly int TextureId = 0x318;
}

public static class Value
{
    public static readonly int Value1 = 0xD0;
}

public static class SpecialMesh
{
    public static readonly int MeshId = 0x108;
    public static readonly int Scale = 0xDC;
}

public static class Lighting
{
    public static readonly int Ambient = 0xD8;
    public static readonly int Atmosphere = 0x1E8;
    public static readonly int Brightness = 0x120;
    public static readonly int ClockTime = 0x1B8;
    public static readonly int ColorShift_Bottom = 0xE4;
    public static readonly int ColorShift_Top = 0xF0;
    public static readonly int EnvironmentDiffuseScale = 0x10C;
    public static readonly int EnvironmentSpecularScale = 0x128;
    public static readonly int OutdoorAmbient = 0x108;
    public static readonly int Sky = 0x1D8;
}

public static class Sky
{
    public static readonly int MoonAngularSize = 0x25C;
    public static readonly int MoonTextureId = 0xE0;
    public static readonly int SkyboxBk = 0x110;
    public static readonly int SkyboxDn = 0x140;
    public static readonly int SkyboxFt = 0x170;
    public static readonly int SkyboxLf = 0x1A0;
    public static readonly int SkyboxOrientation = 0x254;
    public static readonly int SkyboxRt = 0x1D0;
    public static readonly int SkyboxUp = 0x200;
    public static readonly int StarCount = 0x260;
    public static readonly int SunAngularSize = 0x264;
    public static readonly int SunTextureId = 0x230;
}

public static class Atmosphere
{
    public static readonly int Color = 0xD0;
    public static readonly int Decay = 0xDC;
    public static readonly int Density = 0xE8;
    public static readonly int Glare = 0xEC;
    public static readonly int Haze = 0xF0;
    public static readonly int Offset = 0xF4;
}

public static class BloomEffect
{
    public static readonly int Intensity = 0xD0;
    public static readonly int Size = 0xD4;
    public static readonly int Threshold = 0xD8;
}

public static class SunRaysEffect
{
    public static readonly int Intensity = 0xD0;
    public static readonly int Spread = 0xD0;
}

public static class ColorCorrectionEffect
{
    public static readonly int Brightness = 0xDC;
    public static readonly int Contrast = 0xE0;
    public static readonly int Saturation = 0xE4;
    public static readonly int TintColor = 0xD0;
}

public static class DepthOfFieldEffect
{
    public static readonly int Density = 0xD0;
    public static readonly int FocusDistance = 0xD4;
    public static readonly int InFocusRadius = 0xD8;
    public static readonly int NearIntensity = 0xDC;
}

public static class MouseService
{
    public static readonly int InputObject = 0x110;
    public static readonly int Position = 0xEC;
}

public static class UIGradient
{
    public static readonly int Color = 0x134;
    public static readonly int Offset = 0x158;
    public static readonly int Rotation = 0x160;
    public static readonly int Transparency = 0xF4;
}

public static class GuiObject
{
    public static readonly int AbsolutePositionX = 0x110;
    public static readonly int AbsolutePositionY = 0x114;
    public static readonly int AbsoluteSizeX = 0x118;
    public static readonly int AbsoluteSizeY = 0x11C;
    public static readonly int AnchorPoint = 0x570;
    public static readonly int BackgroundColor3 = 0x558;
    public static readonly int BackgroundTransparency = 0x57C;
    public static readonly int BorderColor3 = 0x564;
    public static readonly int BorderSizePixel = 0x584;
    public static readonly int LayoutOrder = 0x594;
    public static readonly int Position = 0x528;
    public static readonly int Rotation = 0x188;
    public static readonly int Size = 0x548;
    public static readonly int Visible = 0x5C1;
    public static readonly int ZIndex = 0x5B8;
}

public static class TextLabel
{
    public static readonly int ContentText = 0xAC8;
    public static readonly int LineHeight = 0xB3C;
    public static readonly int MaxVisibleGraphemes = 0xEFC;
    public static readonly int Text = 0xE28;
    public static readonly int TextBounds = 0xD00;
    public static readonly int TextColor3 = 0xED8;
    public static readonly int TextSize = 0xD04;
    public static readonly int TextStrokeColor3 = 0xEE4;
    public static readonly int TextStrokeTransparency = 0xF08;
    public static readonly int TextTransparency = 0xF0C;
}

public static class TextButton
{
    public static readonly int ContentText = 0xD48;
    public static readonly int LineHeight = 0xDBC;
    public static readonly int Text = 0x10A8;
    public static readonly int TextBounds = 0xF80;
    public static readonly int TextColor3 = 0x1158;
    public static readonly int TextSize = 0xF84;
    public static readonly int TextStrokeColor3 = 0x1164;
    public static readonly int TextTransparency = 0x118C;
}

public static class TextBox
{
    public static readonly int ContentText = 0xAC0;
    public static readonly int LineHeight = 0xB34;
    public static readonly int Text = 0xE20;
    public static readonly int TextBounds = 0xCF8;
    public static readonly int TextColor3 = 0xEFC;
    public static readonly int TextSize = 0xCFC;
    public static readonly int TextStrokeColor3 = 0xF08;
    public static readonly int TextTransparency = 0xF40;
}

public static class Tool
{
    public static readonly int CanBeDropped = 0x4A0;
    public static readonly int Enabled = 0x4A1;
    public static readonly int Grip = 0x470;
    public static readonly int GripForward = 0x488;
    public static readonly int GripPos = 0x494;
    public static readonly int GripRight = 0x470;
    public static readonly int GripUp = 0x47C;
    public static readonly int ManualActivationOnly = 0x4A2;
    public static readonly int RequiresHandle = 0x4A3;
    public static readonly int ToolTip = 0x450;
}

public static class Highlight
{
    public static readonly int DepthMode = 0xF8;
    public static readonly int FillColor = 0xE0;
    public static readonly int FillTransparency = 0xFC;
    public static readonly int OutlineColor = 0xEC;
    public static readonly int OutlineTransparency = 0xF0;
}

public static class ProximityPrompt
{
    public static readonly int ActionText = 0xD0;
    public static readonly int Enabled = 0x156;
    public static readonly int HoldDuration = 0x140;
    public static readonly int KeyboardKeyCode = 0x144;
    public static readonly int MaxActivationDistance = 0x148;
    public static readonly int ObjectText = 0xF0;
    public static readonly int RequiresLineOfSight = 0x157;
}

public static class ByteCode
{
    public static readonly int Pointer = 0x10;
    public static readonly int Size = 0x20;
}

public static class ModuleScript
{
    public static readonly int Bytecode = 0x150;
    public static readonly int Hash = 0x160;
}

public static class LocalScript
{
    public static readonly int Bytecode = 0x1A8;
    public static readonly int Hash = 0x1B8;
}

public static class Terrain
{
    public static readonly int GrassLength = 0x1F8;
    public static readonly int MaterialColors = 0x280;
    public static readonly int WaterColor = 0x1E8;
    public static readonly int WaterReflectance = 0x200;
    public static readonly int WaterTransparency = 0x204;
    public static readonly int WaterWaveSize = 0x208;
    public static readonly int WaterWaveSpeed = 0x20C;
}

public static class MaterialColors
{
    public static readonly int Asphalt = 0x10;
    public static readonly int Basalt = 0xD;
    public static readonly int Brick = 0x5;
    public static readonly int Cobblestone = 0x11;
    public static readonly int Concrete = 0x4;
    public static readonly int CrackedLava = 0xF;
    public static readonly int Glacier = 0x9;
    public static readonly int Grass = 0x2;
    public static readonly int Ground = 0xE;
    public static readonly int Ice = 0x12;
    public static readonly int LeafyGrass = 0x13;
    public static readonly int Limestone = 0x15;
    public static readonly int Mud = 0xC;
    public static readonly int Pavement = 0x16;
    public static readonly int Rock = 0x8;
    public static readonly int Salt = 0x14;
    public static readonly int Sand = 0x6;
    public static readonly int Sandstone = 0xB;
    public static readonly int Slate = 0x3;
    public static readonly int Snow = 0xA;
    public static readonly int WoodPlanks = 0x7;
}

public static class Camera
{
    public static readonly int FieldOfView = 0x160;
    public static readonly int Position = 0x11C;
    public static readonly int Rotation = 0xF8;
}
}


