using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Swed64;
using H163_ext_test;
namespace Shoto_tyt_esti
{
    public static class World
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        
        public static instance Lighting()
        {
            return base_s.GT().findfirstchild("Lighting");
        }
        public static instance Sky()
        {
            return Lighting().findfirstchild("Sky");
        }
        public static instance Terrain()
        {
            return base_s._workspace().findfirstchild("Terrain");
        }
        public static void Set_Gravity(float a)
        {
            var cont = local.ReadPointer(base_s._workspace().address + Offsets.Workspace.GravityContainer);
            local.WriteFloat(cont + Offsets.Workspace.Gravity, a);
        }
        public static instance MatterialColors()
        {
            var mat = local.ReadPointer(Terrain().address + Offsets2.Terrain.MaterialColors);
            var mat_inc = new instance(mat);
            return mat_inc;
        }
        public static instance Atmosphere()
        {
            var mat = local.ReadPointer(Lighting().address + Offsets2.Lighting.Atmosphere);
            var mat_inc = new instance(mat);
            return mat_inc;
        }
        public static instance Bloom()
        {
            return Lighting().findfirstchild("Bloom");
        }
        public static instance SunRays()
        {
            return Lighting().findfirstchild("SunRays");
        }
        //Lighting
        public static void Set_Brightness(float z)
        {
            local.WriteFloat(Lighting().address + Offsets.Lighting.Brightness, z);
        }
        public static void Set_Ambient(float red, float green, float blue)
        {
            //local.WriteVec(Lighting().address + Offsets.Lighting.Ambient, new Vector3(red / 255f, green / 255f, blue / 255f));
            local.WriteVec(Lighting().address + Offsets.Lighting.Ambient, new Vector3(red, green, blue));
        }
        public static void Set_OutdoorAmbient(float red, float green, float blue)
        {
            //local.WriteVec(Lighting().address + Offsets.Lighting.OutdoorAmbient, new Vector3(red / 255f, green / 255f, blue / 255f));
            local.WriteVec(Lighting().address + Offsets.Lighting.OutdoorAmbient, new Vector3(red, green, blue));
        }
        public static void Set_ColorShift_Top(float red, float green, float blue)
        {
            local.WriteVec(Lighting().address + Offsets.Lighting.ColorShift_Top, new Vector3(red, green, blue));
        }
        public static void Set_ColorShift_Bottom(float red, float green, float blue)
        {
            local.WriteVec(Lighting().address + Offsets.Lighting.ColorShift_Bottom, new Vector3(red, green, blue));
        }
        public static void Set_ExposureCompensation(float z)
        {
            local.WriteFloat(Lighting().address + Offsets.Lighting.ExposureCompensation, z);
        }
        //Sky
        public static void Set_MoonAngularSize(float z)
        {
            local.WriteFloat(Sky().address + Offsets.Sky.MoonAngularSize, z);
        }
        public static void Set_SunAngularSize(float z)
        {
            local.WriteFloat(Sky().address + Offsets2.Sky.SunAngularSize, z);
        }
        //Terrain
        public static void Set_GlassLenght(float z)
        {
            local.WriteFloat(Terrain().address + Offsets2.Terrain.GrassLength, z);
        }
        public static void Set_WaterColor(float red, float green, float blue)
        {
            //local.WriteVec(Terrain().address + Offsets2.Terrain.WaterColor, new Vector3(red / 255f, green / 255f, blue / 255f));
            local.WriteVec(Terrain().address + Offsets2.Terrain.WaterColor, new Vector3(red, green, blue));
        }
        public static void Set_WaterReflectance(float z)
        {
            local.WriteFloat(Terrain().address + Offsets2.Terrain.WaterReflectance, z);
        }
        public static void Set_WaterTransparency(float z)
        {
            local.WriteFloat(Terrain().address + Offsets2.Terrain.WaterTransparency, z);
        }
        public static void Set_WaterWaveSize(float z)
        {
            local.WriteFloat(Terrain().address + Offsets2.Terrain.WaterWaveSize, z);
        }
        public static void Set_WaterWaveSpeed(float z)
        {
            local.WriteFloat(Terrain().address + Offsets2.Terrain.WaterWaveSpeed, z);
        }   
        ///Atmosphere
        public static void Set_AtmosphereColor(float red, float green, float blue)
        {
            //local.WriteVec(Atmosphere().address + Offsets2.Atmosphere.Color, new Vector3(red / 255f, green / 255f, blue / 255f));
            local.WriteVec(Atmosphere().address + Offsets2.Atmosphere.Color, new Vector3(red, green, blue));
        }
        public static void Set_AtmosphereDensity(float z)
        {
            local.WriteFloat(Atmosphere().address + Offsets2.Atmosphere.Density, z);
        }
        public static void Set_AtmosphereOffset(float z)
        {
            local.WriteFloat(Atmosphere().address + Offsets2.Atmosphere.Offset, z);
        }
        //Bloom
        public static void Set_BloomIntensity(float z)
        {
            local.WriteFloat(Bloom().address + Offsets2.BloomEffect.Intensity, z);
        }
        public static void Set_BloomSize(float z)
        {
            local.WriteFloat(Bloom().address + Offsets2.BloomEffect.Size, z);
        }
        public static void Set_BloomThreshold(float z)
        {
            local.WriteFloat(Bloom().address + Offsets2.BloomEffect.Threshold, z);
        }
        //SunRays
        public static void Set_SunRaysIntensity(float z)
        {
            local.WriteFloat(SunRays().address + Offsets2.SunRaysEffect.Intensity, z);
        }
        //MatterialColor
        public static void Set_GlassColor(int al)
        {
            if (al == 0)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.441f, 0)); //White
            if (al == 1)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0, 0, 0)); //Black
            if (al == 2)
                   local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.2f, 0)); //Light-Green
            if (al == 3)
                    local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.334f, 0)); //Blue
            if (al == 4)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.652f, 0)); //Green
            if (al == 5)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.111f, 0)); //Pink
            if (al == 6)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.2043f, 0)); //Black-blue
            if (al == 7)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.2503f, 0)); //Purple
            if (al == 8)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.2506f, 0)); //Black-pink
            if (al == 9)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.25097f, 0)); //Turquoise
            if (al == 10)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.341f, 0)); //Grey
            if (al == 11)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.371f, 0)); //Light-Green-2
            if (al == 12)                                                                                                             
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.528f, 0)); //Black-Green
            if (al == 13)
                local.WriteVec(MatterialColors().address + Offsets2.MaterialColors.Grass, new Vector3(0.0f, 0.537f, 0)); //Orange
        }
    }
}
