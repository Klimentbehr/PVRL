using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PVRL.Functions
{
    internal static class Program
    {
        // Constants for setting console to fullscreen
        private const int SW_MAXIMIZE = 3;
        private const int STD_OUTPUT_HANDLE = -11;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetCurrentConsoleFontEx(IntPtr consoleOutput, bool maximumWindow, ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);

        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {
            internal short X;
            internal short Y;

            internal COORD(short x, short y)
            {
                X = x;
                Y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal unsafe struct CONSOLE_FONT_INFO_EX
        {
            internal uint cbSize;
            internal uint nFont;
            internal COORD dwFontSize;
            internal int FontFamily;
            internal int FontWeight;
            internal fixed char FaceName[32];
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            SetConsoleFontSize(24); // Adjust the font size here
            SetConsoleToFullscreen();
            ShowLoadingScreen();

            FreeConsole();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        static void SetConsoleToFullscreen()
        {
            IntPtr consoleWindow = GetConsoleWindow();
            ShowWindow(consoleWindow, SW_MAXIMIZE);
        }

        static unsafe void SetConsoleFontSize(int fontSize)
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
            info.cbSize = (uint)Marshal.SizeOf(info);
            info.FaceName[0] = 'C'; // "Consolas" font, C is enough as it is default font in console
            info.dwFontSize = new COORD((short)fontSize, (short)fontSize);
            SetCurrentConsoleFontEx(hnd, false, ref info);
        }

        static void ShowLoadingScreen()
        {
            Console.Clear();
            Console.CursorVisible = false;

            // Display the ASCII Art Logo
            string logo = @"
░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░        
░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
░▒▓███████▓▒░ ░▒▓█▓▒▒▓█▓▒░░▒▓███████▓▒░░▒▓█▓▒░        
░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
░▒▓█▓▒░        ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
░▒▓█▓▒░         ░▒▓██▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ 
                                                      
                                                       ";
            Console.WriteLine(logo);

            string[] spinner = { "/", "-", "\\", "|" };
            int spinnerIndex = 0;

            int consoleWidth = Console.WindowWidth;
            int progressBarWidth = consoleWidth - 10; // Leave some space for the spinner and brackets

            Random random = new Random();
            int progress = 0;

            // List of random words and messages
            string[] messages = new[]
            {
                "Initializing modules...",
                "Loading resources...",
                "Connecting to server...",
                "Fetching data...",
                "Starting services...",
                "Preparing UI...",
                "Finalizing setup...",
                "Checking dependencies...",
                "Synchronizing data...",
                "Optimizing performance...",
                "Compiling assets...",
                "Updating database...",
                "Configuring environment..."
            };

            while (progress < 100)
            {
                int increment = random.Next(1, 3); // Random increment between 1 and 2
                progress = Math.Min(progress + increment, 100);

                Console.SetCursorPosition(0, 12); // Position below the logo
                Console.Write("[");

                int position = (progress * progressBarWidth) / 100;
                for (int j = 0; j < position; j++)
                {
                    Console.Write("#");
                }

                for (int j = position; j < progressBarWidth; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("]");

                Console.SetCursorPosition(progressBarWidth + 2, 12); // Position for the spinner
                Console.Write(spinner[spinnerIndex]);
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;

                // Display random message
                Console.SetCursorPosition(0, 14);
                string message = messages[random.Next(messages.Length)];
                Console.WriteLine(message.PadRight(consoleWidth)); // Ensure the message covers the line

                Thread.Sleep(random.Next(100, 250)); // Random delay between 200 and 500 milliseconds
            }

            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}
