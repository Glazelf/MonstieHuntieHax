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
            WriteHeap(CountSysBotZeni.Value, DataOffsets.PointerZeni);
        }

        private void CountSysBotBottleCaps_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Bottle Caps: {CountSysBotBottleCaps.Value}";
            WriteHeap(CountSysBotBottleCaps.Value, DataOffsets.PointerBottleCaps);
        }

        private void CountSysBotCharmTraining_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Training Charms: {CountSysBotCharmTraining.Value}";
            WriteHeap(CountSysBotCharmTraining.Value, DataOffsets.PointerCharmTraining);
        }

        private void CountSysBotCharmGathering_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Gathering Charms: {CountSysBotCharmGathering.Value}";
            WriteHeap(CountSysBotCharmGathering.Value, DataOffsets.PointerCharmGathering);
        }

        private void CountSysBotCharmLucky_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Lucky Charms: {CountSysBotCharmLucky.Value}";
            WriteHeap(CountSysBotCharmLucky.Value, DataOffsets.PointerCharmLucky);
        }

        private void CountSysBotCharmFinding_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Finding Charms: {CountSysBotCharmFinding.Value}";
            WriteHeap(CountSysBotCharmFinding.Value, DataOffsets.PointerCharmFinding);
        }

        private void CountSysBotCharmMounting_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Mounting Charms: {CountSysBotCharmMounting.Value}";
            WriteHeap(CountSysBotCharmMounting.Value, DataOffsets.PointerCharmMounting);
        }

        private void CountSysBotCharmSelling_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Selling Charms: {CountSysBotCharmSelling.Value}";
            WriteHeap(CountSysBotCharmSelling.Value, DataOffsets.PointerCharmSelling);
        }

        private void CountSysBotCharmBuying_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Buying Charms: {CountSysBotCharmBuying.Value}";
            WriteHeap(CountSysBotCharmBuying.Value, DataOffsets.PointerCharmBuying);
        }

        private void CountSysBotCharmAdamant_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Adamant Charms: {CountSysBotCharmAdamant.Value}";
            WriteHeap(CountSysBotCharmAdamant.Value, DataOffsets.PointerCharmAdamant);
        }

        private void CountSysBotCharmMight_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Might Charms: {CountSysBotCharmMight.Value}";
            WriteHeap(CountSysBotCharmMight.Value, DataOffsets.PointerCharmMight);
        }

        private void CountSysBotCharmRecovery_ValueChanged(object sender, EventArgs e)
        {
            SysBotLog.Text += Environment.NewLine + $"Writing Recovery Charms: {CountSysBotCharmRecovery.Value}";
            WriteHeap(CountSysBotCharmRecovery.Value, DataOffsets.PointerCharmRecovery);
        }

        private void ReloadValues()
        {
            // Currencies
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
            // Charms
            try
            {
                uint TrainingCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmTraining);
                CountSysBotCharmTraining.Value = TrainingCharms;
                CountSysBotCharmTraining.Enabled = true;
                uint GatheringCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmGathering);
                CountSysBotCharmGathering.Value = GatheringCharms;
                CountSysBotCharmGathering.Enabled = true;
                uint LuckyCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmLucky);
                CountSysBotCharmLucky.Value = LuckyCharms;
                CountSysBotCharmLucky.Enabled = true;
                uint FindingCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmFinding);
                CountSysBotCharmFinding.Value = FindingCharms;
                CountSysBotCharmFinding.Enabled = true;
                uint MountingCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmMounting);
                CountSysBotCharmMounting.Value = MountingCharms;
                CountSysBotCharmMounting.Enabled = true;
                uint SellingCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmSelling);
                CountSysBotCharmSelling.Value = SellingCharms;
                CountSysBotCharmSelling.Enabled = true;
                uint BuyingCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmBuying);
                CountSysBotCharmBuying.Value = BuyingCharms;
                CountSysBotCharmBuying.Enabled = true;
                uint AdamantCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmAdamant);
                CountSysBotCharmAdamant.Value = AdamantCharms;
                CountSysBotCharmAdamant.Enabled = true;
                uint MightCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmMight);
                CountSysBotCharmMight.Value = MightCharms;
                CountSysBotCharmMight.Enabled = true;
                uint RecoveryCharms = (uint)PointerHandler.GetPointerAddress(sb, DataOffsets.PointerCharmRecovery);
                CountSysBotCharmRecovery.Value = RecoveryCharms;
                CountSysBotCharmRecovery.Enabled = true;

                SysBotLog.Text += Environment.NewLine + $"{DataOffsets.PointerCharmRecovery}"; 
            } catch (Exception ex)
            {
                CountSysBotCharmTraining.Enabled = false;
                CountSysBotCharmGathering.Enabled = false;
                CountSysBotCharmLucky.Enabled = false;
                CountSysBotCharmFinding.Enabled = false;
                CountSysBotCharmMounting.Enabled = false;
                CountSysBotCharmSelling.Enabled = false;
                CountSysBotCharmBuying.Enabled = false;
                CountSysBotCharmAdamant.Enabled = false;
                CountSysBotCharmMight.Enabled = false;
                CountSysBotCharmRecovery.Enabled = false;
                LogError(ex);
            }

            SysBotLog.Text += Environment.NewLine + "Loaded values.";
        }

        private void WriteHeap(decimal input, string pointer)
        {
            byte[] writeBytes = BitConverter.GetBytes((uint)input);
            PointerHandler.WritePointer(sb, pointer, writeBytes);
        }

        public void LogError(Exception ex)
        {
            SysBotLog.Text += Environment.NewLine + $"{ex.Message}\n{ex.StackTrace}";
        }
    }
}