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

        public Injector SwitchInjector = new Injector();
        readonly SwitchConnectionConfig cfg = new SwitchConnectionConfig();
        readonly PointerHandler PointerHandler = new PointerHandler();
        public bool Connected = false;
        public ISwitchConnectionSync sb;

        // Declare offsets

        ulong OffsetZeni;

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
                SysBotLog.Text += Environment.NewLine + "Successfully connected.";
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
                SysBotZeniCount.Enabled = false;

                StatusConnection.ForeColor = Color.Red;
                StatusConnection.Text = "Disconnected";
                Connected = false;
                ButtonConnect.Text = "Connect";
                SysBotLog.Text += Environment.NewLine + "Successfully disconnected.";
            }
        }
        private void ButtonSysbotRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void SysBotZeniCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotZeniCount.Value, OffsetZeni, sb);
        }

        private void ReloadValues()
        {
            try
            {
                OffsetZeni = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerZeni);
                float Zeni = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetZeni, 4), 0);
                SysBotZeniCount.Value = (decimal)Zeni;
                SysBotZeniCount.Enabled = true;
            }
            catch (Exception ex)
            {
                SysBotZeniCount.Enabled = false;
                LogError(ex);
            }

            SysBotLog.Text += Environment.NewLine + "Successfully loaded values.";
        }

        public void LogError(Exception ex)
        {
            SysBotLog.Text += Environment.NewLine + $"{ex.Message}\n{ex.StackTrace}";
        }
    }
}