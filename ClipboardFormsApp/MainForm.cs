using ClipboardFormsApp.Helpers;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ClipboardFormsApp
{
    public partial class MainForm : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
            RegisterHotKeys();
            LoadFile();
        }

        private bool LoadFile()
        {
            return FileHelper.LoadMemoryTexts();
        }

        private void RegisterHotKeys()
        {
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...

            //RegisterHotKey(this.Handle, EMIT_CLIPBOARD_1, 2, (int)Keys.D1);
            for (var memoryTextNumber = 0; memoryTextNumber <= 9; memoryTextNumber++)
            {
                var key = 48 + memoryTextNumber; // D0 = 48, D1 = 49...
                RegisterHotKey(this.Handle, memoryTextNumber, 2, key);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                // My hotkey has been typed

                try
                {
                    var previousMemoryText = GetMemoryText();

                    var memorySet = SetMemoryText(m.WParam.ToInt32());
                    if (memorySet)
                    {
                        EmitPasteEvent();
                    }
                    RestoreMemoryText(previousMemoryText);
                }
                catch (Exception)
                {
                    // logger;
                }
            }
            base.WndProc(ref m);
        }

        private string GetMemoryText()
        {
            return Clipboard.GetText();
        }

        private bool SetMemoryText(int textIndex)
        {
            var text = FileHelper.MemoryTexts[textIndex];

            if (string.IsNullOrWhiteSpace(text)) return false;

            Clipboard.SetText(text);
            return true;
        }

        // DLA CTRL+11 MOŻNA KOMBINOWAĆ ZE SLEEPEM LUB METODĄ ModifiedKeyStroke(VirtualKeyCode.CONTROL, new List<VirtualKeyCode> { VirtualKeyCode.VK_1, VirtualKeyCode.VK_1 });            
        // new InputSimulator().Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, new List<VirtualKeyCode> { VirtualKeyCode.VK_1, VirtualKeyCode.VK_1 });
        private void EmitPasteEvent()
        {
            new InputSimulator().Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V); // wklej 
        }

        private void RestoreMemoryText(string text)
        {
            System.Threading.Thread.Sleep(1000); // hak, żeby najpierw poszedł event Ctrl+V, a dopiero później przywrócić tekst do pamięci
            Clipboard.SetText(text);
        }

        private void Btn_ReloadClipboardFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}
