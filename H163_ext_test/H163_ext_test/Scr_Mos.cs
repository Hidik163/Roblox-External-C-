using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using H163_ext_test;
using Swed64;

namespace Shoto_tyt_esti
{
    public static class Scr_Mos
    {
        static Swed local = new Swed("RobloxPlayerBeta");
        public static Vector2 world_to_screen(Vector3 world, Vector2 dimensions, Matrix4x4 viewmatrix) //copy paste
        {
            Vector4 quaternion = new Vector4();

            quaternion.X = (world.X * viewmatrix.M11) + (world.Y * viewmatrix.M12) + (world.Z * viewmatrix.M13) + viewmatrix.M14;
            quaternion.Y = (world.X * viewmatrix.M21) + (world.Y * viewmatrix.M22) + (world.Z * viewmatrix.M23) + viewmatrix.M24;
            quaternion.Z = (world.X * viewmatrix.M31) + (world.Y * viewmatrix.M32) + (world.Z * viewmatrix.M33) + viewmatrix.M34;
            quaternion.W = (world.X * viewmatrix.M41) + (world.Y * viewmatrix.M42) + (world.Z * viewmatrix.M43) + viewmatrix.M44;

            if (quaternion.W < 0.1f)
                return new Vector2(-1, -1);

            float inv_w = 1.0f / quaternion.W;
            Vector3 ndc;
            ndc.X = quaternion.X * inv_w;
            ndc.Y = quaternion.Y * inv_w;
            ndc.Z = quaternion.Z * inv_w;

            return new Vector2((dimensions.X / 2 * ndc.X) + (ndc.X + dimensions.X / 2), -(dimensions.Y / 2 * ndc.Y) + (ndc.Y + dimensions.Y / 2));

        }
        public struct POINT
        {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static POINT GetMousePosition()
        {
            GetCursorPos(out POINT p);
            return p;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public int type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx, dy;
            public uint mouseData, dwFlags, time;
            public IntPtr extra;
        }

        const int INPUT_MOUSE = 0;
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;


        [DllImport("user32.dll")]
        static extern uint SendInput(uint n, INPUT[] p, int size);


        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_MOVE = 0x0001;
        public static void MoveMouse(int dx, int dy)
        {
            mouse_event(MOUSEEVENTF_MOVE, dx, dy, 0, 0);
        }
        public static void Click()
        {
            mouse_event(0x0002, 0, 0, 0, 0);
            Thread.Sleep(10);
            mouse_event(0x0004, 0, 0, 0, 0);
        }
        public static void MoveAbsolute(int x, int y)
        {
            int screenWidth = 1920;
            int screenHeight = 1080;

            int absX = x * 65535 / screenWidth;
            int absY = y * 65535 / screenHeight;

            SendInput(1, new[] {
                new INPUT {
                    type = INPUT_MOUSE,
                    mi = new MOUSEINPUT { dx = absX, dy = absY, dwFlags = MOUSEEVENTF_MOVE | MOUSEEVENTF_ABSOLUTE }
                }
            }, Marshal.SizeOf<INPUT>());
        }
    }
}
