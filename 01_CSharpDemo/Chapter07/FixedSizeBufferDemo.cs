using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    struct COORD
    {
        public short X, Y;
    }

    struct SMALL_RECT
    {
        public short Left, Top, Right, Bottom;
    }

    unsafe struct CONSOLE_SCREEN_BUFFER_INFOEX
    {
        public int StructureSize;
        public COORD ConsoleSize, CursorPosition;
        public short Attributes;
        public SMALL_RECT DisplayWindow;
        public COORD MaximumWindowSize;
        public short PopupAttributes;
        public int FullScreenSupported;
        public fixed int ColorTable[16];
    }

    static class FixedSizeBufferDemo
    {
        const int StdOutputHandle = -11;
        [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleScreenBufferInfoEx(IntPtr handle, ref CONSOLE_SCREEN_BUFFER_INFOEX info);

        public unsafe static void MainDemo()
        {
            IntPtr handle = GetStdHandle(StdOutputHandle);
            CONSOLE_SCREEN_BUFFER_INFOEX info;
            info = new CONSOLE_SCREEN_BUFFER_INFOEX();
            info.StructureSize = sizeof(CONSOLE_SCREEN_BUFFER_INFOEX);
            GetConsoleScreenBufferInfoEx(handle, ref info);

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"{info.ColorTable[i]}:x6");
            }
        }

    }
}
