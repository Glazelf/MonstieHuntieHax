using MonstieHuntieHax.Core;
using MonstieHuntieHax.Injection;
using SysBot.Base;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonstieHuntieHax.WinForms
{
    public partial class Main : Form
    {
#pragma warning disable CA1416 // Do not catch Win7 warning

        private static readonly string WorkingDirectory = Application.StartupPath;
        //private static readonly string ConfigPath = Path.CombineArrays(WorkingDirectory, "config.json");

        public Main()
        {
            InitializeComponent();
        }

        public Injector SwitchInjector = new();
        readonly SwitchConnectionConfig cfg = new();
        readonly PointerHandler PointerHandler = new();
        public bool Connected = false;
        public ISwitchConnectionSync sb;

        // Declare offsets


        public void SysBotUI_Load(object sender, EventArgs e)
        {
            TextBoxPort.Text = Settings.Default.Port;
            TextBoxIP.Text = Settings.Default.IP;
        }

        private void TextBoxPort_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Port = TextBoxPort.Text;
            Settings.Default.Save();
        }

        private void TextBoxIP_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.IP = TextBoxIP.Text;
            Settings.Default.Save();
        }

        // sb and getting values
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == false)
            {
                // Connect button behaviour
                cfg.IP = TextBoxIP.Text;
                cfg.Port = Port;
                sb = cfg.CreateSync();
                sb.Connect();

                ReloadValues();
                // Toggle buttons and fields
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;
                ButtonSysbotRead.Enabled = true;

                StatusConnection.ForeColor = Color.Green;
                StatusConnection.Text = "Connected";
                Connected = true;
                ButtonConnect.Text = "Disconnect";
                SysBotLog.Text += Environment.NewLine + "Connected.";
            }
            else
            {
                // Disconnect button behaviour
                sb.Disconnect();
                // Toggle buttons and fields
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;
                ButtonSysbotRead.Enabled = false;
                // Player
                CountSysBotZeni.Enabled = false;
                CountSysBotBottleCaps.Enabled = false;

                StatusConnection.ForeColor = Color.Red;
                StatusConnection.Text = "Disconnected";
                Connected = false;
                ButtonConnect.Text = "Connect";
                SysBotLog.Text += Environment.NewLine + "Disconnected.";
            }
        }
        private void ButtonSysbotRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void SysBotZeniCount_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Zeni: {CountSysBotZeni.Value}";
            byte[] ZeniBytes = BitConverter.GetBytes((uint)CountSysBotZeni.Value);
            PointerHandler.WritePointer(sb, DataOffsets.PointerZeni, ZeniBytes);
        }

        private void CountSysBotBottleCaps_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Bottle Caps: {CountSysBotBottleCaps.Value}";
            byte[] BottleCapsBytes = BitConverter.GetBytes((uint)CountSysBotBottleCaps.Value);
            PointerHandler.WritePointer(sb, DataOffsets.PointerBottleCaps, BottleCapsBytes);
        }

        private void ReloadValues()
        {
            try
            {
                uint Zeni = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerZeni);
                CountSysBotZeni.Value = Zeni;
                CountSysBotZeni.Enabled = true;
                uint BottleCaps = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerBottleCaps);
                CountSysBotBottleCaps.Value = BottleCaps;
                CountSysBotBottleCaps.Enabled = true;
            }
            catch (Exception ex)
            {
                CountSysBotZeni.Enabled = false;
                CountSysBotBottleCaps.Enabled = false;
                LogError(ex);
            }

            SysBotLog.Text += Environment.NewLine + "Loaded values.";
        }

        public void LogError(Exception ex)
        {
            SysBotLog.Text += Environment.NewLine + $"{ex.Message}\n{ex.StackTrace}";
        }
    }
}