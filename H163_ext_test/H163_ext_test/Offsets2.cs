using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://dumper.jonah.cool/offsets.hpp
//Roblox version: version-80c7b8e578f241ff
public static class Offsets2
{
    public static class Atmosphere
{
    public static readonly int Color = 0xD0;
    public static readonly int Decay = 0xDC;
    public static readonly int Density = 0xE8;
    public static readonly int Glare = 0xEC;
    public static readonly int Haze = 0xF0;
    public static readonly int Offset = 0xF4;
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

public static class BloomEffect
{
    public static readonly int Intensity = 0xD0;
    public static readonly int Size = 0xD4;
    public static readonly int Threshold = 0xD8;
}

public static class ByteCode
{
    public static readonly int Pointer = 0x10;
    public static readonly int Size = 0x20;
}

public static class Camera
{
    public static readonly int CFrame = 0xF8;
    public static readonly int FieldOfView = 0x160;
    public static readonly int Position = 0x11C;
    public static readonly int Rotation = 0xF8;
    public static readonly int ViewportInt16 = 0x2AC;
    public static readonly int ViewportSize = 0x2E8;
}

public static class CharacterMesh
{
    public static readonly int BaseTextureId = 0xD0;
    public static readonly int BodyPart = 0xE8;
    public static readonly int MeshId = 0xD8;
    public static readonly int OverlayTextureId = 0xE0;
}

public static class DataModel
{
    public static readonly int CreatorId = 0x188;
    public static readonly int GameId = 0x190;
    public static readonly int GameLoaded = 0x5F8;
    public static readonly int JobId = 0x138;
    public static readonly int PlaceId = 0x198;
    public static readonly int ServerIP = 0x5E0;
    public static readonly int Workspace = 0x178;
}

public static class FakeDataModel
{
    public static readonly int Pointer = 0x800F778;
    public static readonly int RealDataModel = 0x1C0;
}

public static class GuiBase2D
{
    public static readonly int AbsolutePosition = 0x10C;
    public static readonly int AbsoluteRotation = 0x188;
    public static readonly int AbsoluteSize = 0x118;
}

public static class GuiObject
{
    public static readonly int Active = 0x5AC;
    public static readonly int AnchorPoint = 0x560;
    public static readonly int AutomaticSize = 0x568;
    public static readonly int BackgroundColor3 = 0x548;
    public static readonly int BackgroundTransparency = 0x56C;
    public static readonly int BorderColor3 = 0x554;
    public static readonly int BorderMode = 0x570;
    public static readonly int BorderSizePixel = 0x574;
    public static readonly int ClipsDescendants = 0x5AD;
    public static readonly int GuiState = 0x580;
    public static readonly int Interactable = 0x5AF;
    public static readonly int LayoutOrder = 0x584;
    public static readonly int Position = 0x518;
    public static readonly int Rotation = 0x188;
    public static readonly int Selectable = 0x5B0;
    public static readonly int SelectionOrder = 0x5A0;
    public static readonly int Size = 0x538;
    public static readonly int SizeConstraint = 0x5A4;
    public static readonly int Visible = 0x5B1;
    public static readonly int ZIndex = 0x5A8;
}

public static class Humanoid
{
    public static readonly int AutoJumpEnabled = 0x1D8;
    public static readonly int AutoRotate = 0x1D9;
    public static readonly int AutomaticScalingEnabled = 0x1DA;
    public static readonly int BreakJointsOnDeath = 0x1DB;
    public static readonly int CameraOffset = 0x140;
    public static readonly int DisplayDistanceType = 0x18C;
    public static readonly int EvaluateStateMachine = 0x1DC;
    public static readonly int Health = 0x194;
    public static readonly int HealthDisplayDistance = 0x198;
    public static readonly int HealthDisplayType = 0x19C;
    public static readonly int HipHeight = 0x1A0;
    public static readonly int JumpHeight = 0x1AC;
    public static readonly int JumpPower = 0x1B0;
    public static readonly int MaxHealth = 0x1B4;
    public static readonly int MaxSlopeAngle = 0x1B8;
    public static readonly int NameDisplayDistance = 0x1BC;
    public static readonly int NameOcclusion = 0x1C0;
    public static readonly int RequiresNeck = 0x1DA;
    public static readonly int RigType = 0x1C8;
    public static readonly int Sit = 0x1E1;
    public static readonly int TargetPoint = 0x164;
    public static readonly int UseJumpPower = 0x1E3;
    public static readonly int WalkSpeed = 0x1D4;
    public static readonly int WalkSpeedCheck = 0x3C0;
    public static readonly int WalkToPoint = 0x17C;
}

public static class InputObject
{
    public static readonly int MousePosition = 0xEC;
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

public static class Lighting
{
    public static readonly int Ambient = 0xD8;
    public static readonly int Atmosphere = 0x1E8;
    public static readonly int Brightness = 0x120;
    public static readonly int ClockTime = 0x1B8;
    public static readonly int ColorShift_Bottom = 0xE4;
    public static readonly int ColorShift_Top = 0xF0;
    public static readonly int EnvironmentDiffuseScale = 0x124;
    public static readonly int EnvironmentSpecularScale = 0x128;
    public static readonly int GeographicLatitude = 0x190;
    public static readonly int OutdoorAmbient = 0x108;
    public static readonly int Sky = 0x1D8;
}

public static class LocalScript
{
    public static readonly int Bytecode = 0x1A8;
    public static readonly int Hash = 0xE8;
}

public static class MaterialColors
{
    public static readonly int Asphalt = 0x30;
    public static readonly int Basalt = 0x27;
    public static readonly int Brick = 0xF;
    public static readonly int Cobblestone = 0x33;
    public static readonly int Concrete = 0xC;
    public static readonly int CrackedLava = 0x2D;
    public static readonly int Glacier = 0x1B;
    public static readonly int Grass = 0x6;
    public static readonly int Ground = 0x2A;
    public static readonly int Ice = 0x36;
    public static readonly int LeafyGrass = 0x39;
    public static readonly int Limestone = 0x3F;
    public static readonly int Mud = 0x24;
    public static readonly int Pavement = 0x42;
    public static readonly int Rock = 0x18;
    public static readonly int Salt = 0x3C;
    public static readonly int Sand = 0x12;
    public static readonly int Sandstone = 0x21;
    public static readonly int Slate = 0x9;
    public static readonly int Snow = 0x1E;
    public static readonly int WoodPlanks = 0x15;
}

public static class MeshPart
{
    public static readonly int MeshId = 0x2E8;
    public static readonly int TextureId = 0x318;
}

public static class ModuleScript
{
    public static readonly int Bytecode = 0x150;
    public static readonly int Hash = 0xE8;
}

public static class MouseService
{
    public static readonly int InputObject = 0x110;
}

public static class Player
{
    public static readonly int AccountAge = 0x30C;
    public static readonly int Character = 0x380;
    public static readonly int DisplayName = 0x130;
    public static readonly int HealthDisplayDistance = 0x338;
    public static readonly int LocaleId = 0x6B8;
    public static readonly int NameDisplayDistance = 0x344;
    public static readonly int Team = 0x290;
    public static readonly int TeamColor = 0x350;
    public static readonly int UserId = 0x2B8;
}

public static class Players
{
    public static readonly int LocalPlayer = 0x130;
}

public static class Primitive
{
    public static readonly int AssemblyAngularVelocity = 0xFC;
    public static readonly int AssemblyLinearVelocity = 0xF0;
    public static readonly int CFrame = 0xC0;
    public static readonly int Material = 0x246;
    public static readonly int Orientation = 0xC0;
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

public static class RenderView
{
    public static readonly int LightingValid = 0x148;
    public static readonly int SkyboxValid = 0x28D;
}

public static class Sky
{
    public static readonly int MoonAngularSize = 0x25C;
    public static readonly int MoonTextureId = 0xE0;
    public static readonly int SkyboxBk = 0x110;
    public static readonly int SkyboxDn = 0x140;
    public static readonly int SkyboxFt = 0x170;
    public static readonly int SkyboxLf = 0x1A0;
    public static readonly int SkyboxOrientation = 0x250;
    public static readonly int SkyboxRt = 0x1D0;
    public static readonly int SkyboxUp = 0x200;
    public static readonly int StarCount = 0x260;
    public static readonly int SunAngularSize = 0x264;
    public static readonly int SunTextureId = 0x230;
}

public static class SpecialMesh
{
    public static readonly int MeshId = 0x108;
    public static readonly int Offset = 0xD0;
    public static readonly int Scale = 0xDC;
    public static readonly int TextureId = 0x130;
}

public static class Team
{
    public static readonly int TeamColor = 0xD0;
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

public static class TextButton
{
    public static readonly int AutoButtonColor = 0xA14;
    public static readonly int ContentText = 0xD28;
    public static readonly int Font = 0x1150;
    public static readonly int LineHeight = 0xD9C;
    public static readonly int LocalizedText = 0xD28;
    public static readonly int MaxVisibleGraphemes = 0x115C;
    public static readonly int Modal = 0xA15;
    public static readonly int RichText = 0xE45;
    public static readonly int Selected = 0xA16;
    public static readonly int Text = 0xD28;
    public static readonly int TextColor3 = 0x1138;
    public static readonly int TextDirection = 0xE48;
    public static readonly int TextScaled = 0xD98;
    public static readonly int TextSize = 0x1164;
    public static readonly int TextStrokeColor3 = 0x1144;
    public static readonly int TextStrokeTransparency = 0x1168;
    public static readonly int TextTransparency = 0x116C;
    public static readonly int TextTruncate = 0x1170;
    public static readonly int TextWrapped = 0xDE8;
    public static readonly int TextXAlignment = 0x1174;
    public static readonly int TextYAlignment = 0xDE4;
}

public static class TextLabel
{
    public static readonly int ContentText = 0xAA8;
    public static readonly int Font = 0xED0;
    public static readonly int LineHeight = 0xB1C;
    public static readonly int LocalizedText = 0xAA8;
    public static readonly int MaxVisibleGraphemes = 0xEDC;
    public static readonly int RichText = 0xBC5;
    public static readonly int Text = 0xAA8;
    public static readonly int TextColor3 = 0xEB8;
    public static readonly int TextDirection = 0xBC8;
    public static readonly int TextScaled = 0xB18;
    public static readonly int TextSize = 0xEE4;
    public static readonly int TextStrokeColor3 = 0xEC4;
    public static readonly int TextStrokeTransparency = 0xEE8;
    public static readonly int TextTransparency = 0xEEC;
    public static readonly int TextTruncate = 0xEF0;
    public static readonly int TextWrapped = 0xB68;
    public static readonly int TextXAlignment = 0xEF4;
    public static readonly int TextYAlignment = 0xB64;
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
    public static readonly int Tooltip = 0x450;
}

public static class Value
{
    public static readonly int Value1 = 0xD0;
}

public static class VisualEngine
{
    public static readonly int Dimensions = 0x720;
    public static readonly int FakeDataModel = 0x700;
    public static readonly int Pointer = 0x7AED020;
    public static readonly int RenderView = 0x800;
    public static readonly int ViewMatrix = 0x120;
}

public static class Workspace
{
    public static readonly int CurrentCamera = 0x460;
    public static readonly int ReadOnlyGravity = 0x9C0;
    public static readonly int World = 0x3D8;
}

public static class World
{
    public static readonly int Gravity = 0x1D0;
}
}






