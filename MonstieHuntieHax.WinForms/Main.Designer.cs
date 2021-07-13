
namespace MonstieHuntieHax.WinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.GroupSysBotConnection = new System.Windows.Forms.GroupBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.GroupSysBotStatus = new System.Windows.Forms.GroupBox();
            this.StatusConnection = new System.Windows.Forms.Label();
            this.StatusConnectionLabel = new System.Windows.Forms.Label();
            this.ButtonSysbotRead = new System.Windows.Forms.Button();
            this.SysBotTabControl = new System.Windows.Forms.TabControl();
            this.TabSysBotPlayer = new System.Windows.Forms.TabPage();
            this.GroupSysBotCurrencies = new System.Windows.Forms.GroupBox();
            this.CountSysBotBottleCaps = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotBottleCaps = new System.Windows.Forms.Label();
            this.CountSysBotZeni = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotZeni = new System.Windows.Forms.Label();
            this.TabSysBotItems = new System.Windows.Forms.TabPage();
            this.GroupSysBotCharms = new System.Windows.Forms.GroupBox();
            this.CountSysBotCharmAdamant = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmMight = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmGathering = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmTraining = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmMounting = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmSelling = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmFinding = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotCharmAdamant = new System.Windows.Forms.Label();
            this.LabelSysBotCharmMight = new System.Windows.Forms.Label();
            this.LabelSysBotCharmGathering = new System.Windows.Forms.Label();
            this.LabelSysBotCharmTraining = new System.Windows.Forms.Label();
            this.LabelSysBotCharmMounting = new System.Windows.Forms.Label();
            this.LabelSysBotCharmSelling = new System.Windows.Forms.Label();
            this.CountSysBotCharmRecovery = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotCharmFinding = new System.Windows.Forms.Label();
            this.CountSysBotCharmBuying = new System.Windows.Forms.NumericUpDown();
            this.CountSysBotCharmLucky = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotCharmRecovery = new System.Windows.Forms.Label();
            this.LabelSysBotCharmBuying = new System.Windows.Forms.Label();
            this.LabelSysBotCharmLucky = new System.Windows.Forms.Label();
            this.TabSysBotMonsties = new System.Windows.Forms.TabPage();
            this.LabelWIP = new System.Windows.Forms.Label();
            this.TabSysBotLog = new System.Windows.Forms.TabPage();
            this.SysBotLog = new System.Windows.Forms.RichTextBox();
            this.GroupSysBotConnection.SuspendLayout();
            this.GroupSysBotStatus.SuspendLayout();
            this.SysBotTabControl.SuspendLayout();
            this.TabSysBotPlayer.SuspendLayout();
            this.GroupSysBotCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotBottleCaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotZeni)).BeginInit();
            this.TabSysBotItems.SuspendLayout();
            this.GroupSysBotCharms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmAdamant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmMight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmGathering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmMounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmFinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmRecovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmBuying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmLucky)).BeginInit();
            this.TabSysBotMonsties.SuspendLayout();
            this.TabSysBotLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.AccessibleName = "TextBoxIP";
            this.TextBoxIP.Location = new System.Drawing.Point(51, 32);
            this.TextBoxIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(111, 23);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.Text = "192.168.0.1";
            this.TextBoxIP.TextChanged += new System.EventHandler(this.TextBoxIP_TextChanged);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AccessibleName = "ButtonConnect";
            this.ButtonConnect.Location = new System.Drawing.Point(51, 93);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(98, 28);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // GroupSysBotConnection
            // 
            this.GroupSysBotConnection.AccessibleName = "GroupSysBotConnection";
            this.GroupSysBotConnection.Controls.Add(this.LabelPort);
            this.GroupSysBotConnection.Controls.Add(this.LabelIP);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxPort);
            this.GroupSysBotConnection.Controls.Add(this.ButtonConnect);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxIP);
            this.GroupSysBotConnection.Location = new System.Drawing.Point(432, 503);
            this.GroupSysBotConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotConnection.Name = "GroupSysBotConnection";
            this.GroupSysBotConnection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotConnection.Size = new System.Drawing.Size(196, 137);
            this.GroupSysBotConnection.TabIndex = 3;
            this.GroupSysBotConnection.TabStop = false;
            this.GroupSysBotConnection.Text = "Connection";
            // 
            // LabelPort
            // 
            this.LabelPort.AccessibleName = "LabelPort";
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(10, 66);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(32, 15);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            // 
            // LabelIP
            // 
            this.LabelIP.AccessibleName = "LabelIP";
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(21, 36);
            this.LabelIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 15);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.AccessibleName = "TextBoxPort";
            this.TextBoxPort.Location = new System.Drawing.Point(51, 62);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(111, 23);
            this.TextBoxPort.TabIndex = 3;
            this.TextBoxPort.Text = "6000";
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBoxPort_TextChanged);
            // 
            // GroupSysBotStatus
            // 
            this.GroupSysBotStatus.AccessibleName = "GroupSysBotStatus";
            this.GroupSysBotStatus.Controls.Add(this.StatusConnection);
            this.GroupSysBotStatus.Controls.Add(this.StatusConnectionLabel);
            this.GroupSysBotStatus.Controls.Add(this.ButtonSysbotRead);
            this.GroupSysBotStatus.Location = new System.Drawing.Point(14, 503);
            this.GroupSysBotStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotStatus.Name = "GroupSysBotStatus";
            this.GroupSysBotStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotStatus.Size = new System.Drawing.Size(411, 137);
            this.GroupSysBotStatus.TabIndex = 4;
            this.GroupSysBotStatus.TabStop = false;
            this.GroupSysBotStatus.Text = "Status";
            // 
            // StatusConnection
            // 
            this.StatusConnection.AccessibleName = "StatusConnection";
            this.StatusConnection.AutoSize = true;
            this.StatusConnection.ForeColor = System.Drawing.Color.Red;
            this.StatusConnection.Location = new System.Drawing.Point(78, 18);
            this.StatusConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusConnection.Name = "StatusConnection";
            this.StatusConnection.Size = new System.Drawing.Size(79, 15);
            this.StatusConnection.TabIndex = 15;
            this.StatusConnection.Text = "Disconnected";
            // 
            // StatusConnectionLabel
            // 
            this.StatusConnectionLabel.AccessibleName = "StatusConnectionLabel";
            this.StatusConnectionLabel.AutoSize = true;
            this.StatusConnectionLabel.Location = new System.Drawing.Point(7, 18);
            this.StatusConnectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusConnectionLabel.Name = "StatusConnectionLabel";
            this.StatusConnectionLabel.Size = new System.Drawing.Size(72, 15);
            this.StatusConnectionLabel.TabIndex = 10;
            this.StatusConnectionLabel.Text = "Connection:";
            // 
            // ButtonSysbotRead
            // 
            this.ButtonSysbotRead.AccessibleName = "ButtonSysbotRead";
            this.ButtonSysbotRead.Enabled = false;
            this.ButtonSysbotRead.Location = new System.Drawing.Point(316, 104);
            this.ButtonSysbotRead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSysbotRead.Name = "ButtonSysbotRead";
            this.ButtonSysbotRead.Size = new System.Drawing.Size(88, 27);
            this.ButtonSysbotRead.TabIndex = 14;
            this.ButtonSysbotRead.Text = "Refresh All";
            this.ButtonSysbotRead.UseVisualStyleBackColor = true;
            this.ButtonSysbotRead.Click += new System.EventHandler(this.ButtonSysbotRead_Click);
            // 
            // SysBotTabControl
            // 
            this.SysBotTabControl.AccessibleName = "SysBotTabControl";
            this.SysBotTabControl.Controls.Add(this.TabSysBotPlayer);
            this.SysBotTabControl.Controls.Add(this.TabSysBotItems);
            this.SysBotTabControl.Controls.Add(this.TabSysBotMonsties);
            this.SysBotTabControl.Controls.Add(this.TabSysBotLog);
            this.SysBotTabControl.Location = new System.Drawing.Point(2, 3);
            this.SysBotTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SysBotTabControl.Name = "SysBotTabControl";
            this.SysBotTabControl.SelectedIndex = 0;
            this.SysBotTabControl.Size = new System.Drawing.Size(630, 497);
            this.SysBotTabControl.TabIndex = 0;
            // 
            // TabSysBotPlayer
            // 
            this.TabSysBotPlayer.AccessibleName = "TabSysBotPlayer";
            this.TabSysBotPlayer.Controls.Add(this.GroupSysBotCurrencies);
            this.TabSysBotPlayer.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotPlayer.Name = "TabSysBotPlayer";
            this.TabSysBotPlayer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotPlayer.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotPlayer.TabIndex = 0;
            this.TabSysBotPlayer.Text = "Player";
            this.TabSysBotPlayer.UseVisualStyleBackColor = true;
            // 
            // GroupSysBotCurrencies
            // 
            this.GroupSysBotCurrencies.AccessibleName = "GroupSysBotCurrencies";
            this.GroupSysBotCurrencies.Controls.Add(this.CountSysBotBottleCaps);
            this.GroupSysBotCurrencies.Controls.Add(this.LabelSysBotBottleCaps);
            this.GroupSysBotCurrencies.Controls.Add(this.CountSysBotZeni);
            this.GroupSysBotCurrencies.Controls.Add(this.LabelSysBotZeni);
            this.GroupSysBotCurrencies.Location = new System.Drawing.Point(477, 384);
            this.GroupSysBotCurrencies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotCurrencies.Name = "GroupSysBotCurrencies";
            this.GroupSysBotCurrencies.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotCurrencies.Size = new System.Drawing.Size(141, 79);
            this.GroupSysBotCurrencies.TabIndex = 10;
            this.GroupSysBotCurrencies.TabStop = false;
            this.GroupSysBotCurrencies.Text = "Currencies";
            // 
            // CountSysBotBottleCaps
            // 
            this.CountSysBotBottleCaps.AccessibleName = "CountSysBotBottleCaps";
            this.CountSysBotBottleCaps.Enabled = false;
            this.CountSysBotBottleCaps.Location = new System.Drawing.Point(92, 47);
            this.CountSysBotBottleCaps.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotBottleCaps.Name = "CountSysBotBottleCaps";
            this.CountSysBotBottleCaps.Size = new System.Drawing.Size(41, 23);
            this.CountSysBotBottleCaps.TabIndex = 6;
            this.CountSysBotBottleCaps.ValueChanged += new System.EventHandler(this.CountSysBotBottleCaps_ValueChanged);
            // 
            // LabelSysBotBottleCaps
            // 
            this.LabelSysBotBottleCaps.AccessibleName = "LabelSysBotBottleCaps";
            this.LabelSysBotBottleCaps.AutoSize = true;
            this.LabelSysBotBottleCaps.Location = new System.Drawing.Point(15, 49);
            this.LabelSysBotBottleCaps.Name = "LabelSysBotBottleCaps";
            this.LabelSysBotBottleCaps.Size = new System.Drawing.Size(70, 15);
            this.LabelSysBotBottleCaps.TabIndex = 5;
            this.LabelSysBotBottleCaps.Text = "Bottle Caps:";
            // 
            // CountSysBotZeni
            // 
            this.CountSysBotZeni.AccessibleName = "CountSysBotZeni";
            this.CountSysBotZeni.Enabled = false;
            this.CountSysBotZeni.Location = new System.Drawing.Point(63, 18);
            this.CountSysBotZeni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CountSysBotZeni.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CountSysBotZeni.Name = "CountSysBotZeni";
            this.CountSysBotZeni.Size = new System.Drawing.Size(70, 23);
            this.CountSysBotZeni.TabIndex = 1;
            this.CountSysBotZeni.ValueChanged += new System.EventHandler(this.SysBotZeniCount_ValueChanged);
            // 
            // LabelSysBotZeni
            // 
            this.LabelSysBotZeni.AccessibleName = "LabelSysBotZeni";
            this.LabelSysBotZeni.AutoSize = true;
            this.LabelSysBotZeni.Location = new System.Drawing.Point(15, 20);
            this.LabelSysBotZeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSysBotZeni.Name = "LabelSysBotZeni";
            this.LabelSysBotZeni.Size = new System.Drawing.Size(33, 15);
            this.LabelSysBotZeni.TabIndex = 0;
            this.LabelSysBotZeni.Text = "Zeni:";
            // 
            // TabSysBotItems
            // 
            this.TabSysBotItems.AccessibleName = "TabSysBotItems";
            this.TabSysBotItems.Controls.Add(this.GroupSysBotCharms);
            this.TabSysBotItems.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotItems.Name = "TabSysBotItems";
            this.TabSysBotItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotItems.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotItems.TabIndex = 1;
            this.TabSysBotItems.Text = "Items";
            this.TabSysBotItems.UseVisualStyleBackColor = true;
            // 
            // GroupSysBotCharms
            // 
            this.GroupSysBotCharms.AccessibleName = "GroupSysBotCharms";
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmAdamant);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmMight);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmGathering);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmTraining);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmMounting);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmSelling);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmFinding);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmAdamant);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmMight);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmGathering);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmTraining);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmMounting);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmSelling);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmRecovery);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmFinding);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmBuying);
            this.GroupSysBotCharms.Controls.Add(this.CountSysBotCharmLucky);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmRecovery);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmBuying);
            this.GroupSysBotCharms.Controls.Add(this.LabelSysBotCharmLucky);
            this.GroupSysBotCharms.Location = new System.Drawing.Point(6, 6);
            this.GroupSysBotCharms.Name = "GroupSysBotCharms";
            this.GroupSysBotCharms.Size = new System.Drawing.Size(122, 306);
            this.GroupSysBotCharms.TabIndex = 6;
            this.GroupSysBotCharms.TabStop = false;
            this.GroupSysBotCharms.Text = "Prayer Charms";
            // 
            // CountSysBotCharmAdamant
            // 
            this.CountSysBotCharmAdamant.AccessibleName = "CountSysBotCharmAdamant";
            this.CountSysBotCharmAdamant.Enabled = false;
            this.CountSysBotCharmAdamant.Location = new System.Drawing.Point(71, 278);
            this.CountSysBotCharmAdamant.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmAdamant.Name = "CountSysBotCharmAdamant";
            this.CountSysBotCharmAdamant.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmAdamant.TabIndex = 26;
            // 
            // CountSysBotCharmMight
            // 
            this.CountSysBotCharmMight.AccessibleName = "CountSysBotCharmMight";
            this.CountSysBotCharmMight.Enabled = false;
            this.CountSysBotCharmMight.Location = new System.Drawing.Point(71, 249);
            this.CountSysBotCharmMight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmMight.Name = "CountSysBotCharmMight";
            this.CountSysBotCharmMight.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmMight.TabIndex = 25;
            // 
            // CountSysBotCharmGathering
            // 
            this.CountSysBotCharmGathering.AccessibleName = "CountSysBotCharmGathering";
            this.CountSysBotCharmGathering.Enabled = false;
            this.CountSysBotCharmGathering.Location = new System.Drawing.Point(71, 220);
            this.CountSysBotCharmGathering.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmGathering.Name = "CountSysBotCharmGathering";
            this.CountSysBotCharmGathering.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmGathering.TabIndex = 24;
            // 
            // CountSysBotCharmTraining
            // 
            this.CountSysBotCharmTraining.AccessibleName = "CountSysBotCharmTraining";
            this.CountSysBotCharmTraining.Enabled = false;
            this.CountSysBotCharmTraining.Location = new System.Drawing.Point(71, 191);
            this.CountSysBotCharmTraining.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmTraining.Name = "CountSysBotCharmTraining";
            this.CountSysBotCharmTraining.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmTraining.TabIndex = 23;
            // 
            // CountSysBotCharmMounting
            // 
            this.CountSysBotCharmMounting.AccessibleName = "CountSysBotCharmMounting";
            this.CountSysBotCharmMounting.Enabled = false;
            this.CountSysBotCharmMounting.Location = new System.Drawing.Point(71, 162);
            this.CountSysBotCharmMounting.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmMounting.Name = "CountSysBotCharmMounting";
            this.CountSysBotCharmMounting.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmMounting.TabIndex = 22;
            // 
            // CountSysBotCharmSelling
            // 
            this.CountSysBotCharmSelling.AccessibleName = "CountSysBotCharmSelling";
            this.CountSysBotCharmSelling.Enabled = false;
            this.CountSysBotCharmSelling.Location = new System.Drawing.Point(71, 133);
            this.CountSysBotCharmSelling.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmSelling.Name = "CountSysBotCharmSelling";
            this.CountSysBotCharmSelling.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmSelling.TabIndex = 21;
            // 
            // CountSysBotCharmFinding
            // 
            this.CountSysBotCharmFinding.AccessibleName = "CountSysBotCharmFinding";
            this.CountSysBotCharmFinding.Enabled = false;
            this.CountSysBotCharmFinding.Location = new System.Drawing.Point(71, 104);
            this.CountSysBotCharmFinding.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmFinding.Name = "CountSysBotCharmFinding";
            this.CountSysBotCharmFinding.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmFinding.TabIndex = 20;
            // 
            // LabelSysBotCharmAdamant
            // 
            this.LabelSysBotCharmAdamant.AccessibleName = "LabelSysBotCharmAdamant";
            this.LabelSysBotCharmAdamant.AutoSize = true;
            this.LabelSysBotCharmAdamant.Location = new System.Drawing.Point(7, 280);
            this.LabelSysBotCharmAdamant.Name = "LabelSysBotCharmAdamant";
            this.LabelSysBotCharmAdamant.Size = new System.Drawing.Size(59, 15);
            this.LabelSysBotCharmAdamant.TabIndex = 19;
            this.LabelSysBotCharmAdamant.Text = "Adamant:";
            // 
            // LabelSysBotCharmMight
            // 
            this.LabelSysBotCharmMight.AccessibleName = "LabelSysBotCharmMight";
            this.LabelSysBotCharmMight.AutoSize = true;
            this.LabelSysBotCharmMight.Location = new System.Drawing.Point(7, 251);
            this.LabelSysBotCharmMight.Name = "LabelSysBotCharmMight";
            this.LabelSysBotCharmMight.Size = new System.Drawing.Size(42, 15);
            this.LabelSysBotCharmMight.TabIndex = 18;
            this.LabelSysBotCharmMight.Text = "Might:";
            // 
            // LabelSysBotCharmGathering
            // 
            this.LabelSysBotCharmGathering.AccessibleName = "LabelSysBotCharmGathering";
            this.LabelSysBotCharmGathering.AutoSize = true;
            this.LabelSysBotCharmGathering.Location = new System.Drawing.Point(7, 222);
            this.LabelSysBotCharmGathering.Name = "LabelSysBotCharmGathering";
            this.LabelSysBotCharmGathering.Size = new System.Drawing.Size(62, 15);
            this.LabelSysBotCharmGathering.TabIndex = 17;
            this.LabelSysBotCharmGathering.Text = "Gathering:";
            // 
            // LabelSysBotCharmTraining
            // 
            this.LabelSysBotCharmTraining.AccessibleName = "LabelSysBotCharmTraining";
            this.LabelSysBotCharmTraining.AutoSize = true;
            this.LabelSysBotCharmTraining.Location = new System.Drawing.Point(7, 193);
            this.LabelSysBotCharmTraining.Name = "LabelSysBotCharmTraining";
            this.LabelSysBotCharmTraining.Size = new System.Drawing.Size(52, 15);
            this.LabelSysBotCharmTraining.TabIndex = 16;
            this.LabelSysBotCharmTraining.Text = "Training:";
            // 
            // LabelSysBotCharmMounting
            // 
            this.LabelSysBotCharmMounting.AccessibleName = "LabelSysBotCharmMounting";
            this.LabelSysBotCharmMounting.AutoSize = true;
            this.LabelSysBotCharmMounting.Location = new System.Drawing.Point(7, 164);
            this.LabelSysBotCharmMounting.Name = "LabelSysBotCharmMounting";
            this.LabelSysBotCharmMounting.Size = new System.Drawing.Size(63, 15);
            this.LabelSysBotCharmMounting.TabIndex = 15;
            this.LabelSysBotCharmMounting.Text = "Mounting:";
            // 
            // LabelSysBotCharmSelling
            // 
            this.LabelSysBotCharmSelling.AccessibleName = "LabelSysBotCharmSelling";
            this.LabelSysBotCharmSelling.AutoSize = true;
            this.LabelSysBotCharmSelling.Location = new System.Drawing.Point(7, 135);
            this.LabelSysBotCharmSelling.Name = "LabelSysBotCharmSelling";
            this.LabelSysBotCharmSelling.Size = new System.Drawing.Size(45, 15);
            this.LabelSysBotCharmSelling.TabIndex = 14;
            this.LabelSysBotCharmSelling.Text = "Selling:";
            // 
            // CountSysBotCharmRecovery
            // 
            this.CountSysBotCharmRecovery.AccessibleName = "CountSysBotCharmRecovery";
            this.CountSysBotCharmRecovery.Enabled = false;
            this.CountSysBotCharmRecovery.Location = new System.Drawing.Point(71, 75);
            this.CountSysBotCharmRecovery.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmRecovery.Name = "CountSysBotCharmRecovery";
            this.CountSysBotCharmRecovery.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmRecovery.TabIndex = 13;
            // 
            // LabelSysBotCharmFinding
            // 
            this.LabelSysBotCharmFinding.AccessibleName = "LabelSysBotCharmFinding";
            this.LabelSysBotCharmFinding.AutoSize = true;
            this.LabelSysBotCharmFinding.Location = new System.Drawing.Point(7, 106);
            this.LabelSysBotCharmFinding.Name = "LabelSysBotCharmFinding";
            this.LabelSysBotCharmFinding.Size = new System.Drawing.Size(50, 15);
            this.LabelSysBotCharmFinding.TabIndex = 12;
            this.LabelSysBotCharmFinding.Text = "Finding:";
            // 
            // CountSysBotCharmBuying
            // 
            this.CountSysBotCharmBuying.AccessibleName = "CountSysBotCharmBuying";
            this.CountSysBotCharmBuying.Enabled = false;
            this.CountSysBotCharmBuying.Location = new System.Drawing.Point(71, 46);
            this.CountSysBotCharmBuying.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmBuying.Name = "CountSysBotCharmBuying";
            this.CountSysBotCharmBuying.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmBuying.TabIndex = 11;
            // 
            // CountSysBotCharmLucky
            // 
            this.CountSysBotCharmLucky.AccessibleName = "CountSysBotCharmLucky";
            this.CountSysBotCharmLucky.Enabled = false;
            this.CountSysBotCharmLucky.Location = new System.Drawing.Point(71, 17);
            this.CountSysBotCharmLucky.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountSysBotCharmLucky.Name = "CountSysBotCharmLucky";
            this.CountSysBotCharmLucky.Size = new System.Drawing.Size(43, 23);
            this.CountSysBotCharmLucky.TabIndex = 10;
            // 
            // LabelSysBotCharmRecovery
            // 
            this.LabelSysBotCharmRecovery.AccessibleName = "LabelSysBotCharmRecovery";
            this.LabelSysBotCharmRecovery.AutoSize = true;
            this.LabelSysBotCharmRecovery.Location = new System.Drawing.Point(7, 77);
            this.LabelSysBotCharmRecovery.Name = "LabelSysBotCharmRecovery";
            this.LabelSysBotCharmRecovery.Size = new System.Drawing.Size(58, 15);
            this.LabelSysBotCharmRecovery.TabIndex = 9;
            this.LabelSysBotCharmRecovery.Text = "Recovery:";
            // 
            // LabelSysBotCharmBuying
            // 
            this.LabelSysBotCharmBuying.AccessibleName = "LabelSysBotCharmBuying";
            this.LabelSysBotCharmBuying.AutoSize = true;
            this.LabelSysBotCharmBuying.Location = new System.Drawing.Point(7, 48);
            this.LabelSysBotCharmBuying.Name = "LabelSysBotCharmBuying";
            this.LabelSysBotCharmBuying.Size = new System.Drawing.Size(47, 15);
            this.LabelSysBotCharmBuying.TabIndex = 8;
            this.LabelSysBotCharmBuying.Text = "Buying:";
            // 
            // LabelSysBotCharmLucky
            // 
            this.LabelSysBotCharmLucky.AccessibleName = "LabelSysBotCharmLucky";
            this.LabelSysBotCharmLucky.AutoSize = true;
            this.LabelSysBotCharmLucky.Location = new System.Drawing.Point(7, 19);
            this.LabelSysBotCharmLucky.Name = "LabelSysBotCharmLucky";
            this.LabelSysBotCharmLucky.Size = new System.Drawing.Size(41, 15);
            this.LabelSysBotCharmLucky.TabIndex = 7;
            this.LabelSysBotCharmLucky.Text = "Lucky:";
            // 
            // TabSysBotMonsties
            // 
            this.TabSysBotMonsties.AccessibleName = "TabSysBotMonsties";
            this.TabSysBotMonsties.Controls.Add(this.LabelWIP);
            this.TabSysBotMonsties.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotMonsties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotMonsties.Name = "TabSysBotMonsties";
            this.TabSysBotMonsties.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotMonsties.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotMonsties.TabIndex = 2;
            this.TabSysBotMonsties.Text = "Monsties";
            this.TabSysBotMonsties.UseVisualStyleBackColor = true;
            // 
            // LabelWIP
            // 
            this.LabelWIP.AccessibleName = "LabelWIP";
            this.LabelWIP.AutoSize = true;
            this.LabelWIP.Location = new System.Drawing.Point(148, 205);
            this.LabelWIP.Name = "LabelWIP";
            this.LabelWIP.Size = new System.Drawing.Size(320, 15);
            this.LabelWIP.TabIndex = 0;
            this.LabelWIP.Text = "Work in progress! Thanks for using my tool so far though. :)";
            // 
            // TabSysBotLog
            // 
            this.TabSysBotLog.AccessibleName = "TabSysBot4Log";
            this.TabSysBotLog.Controls.Add(this.SysBotLog);
            this.TabSysBotLog.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotLog.Name = "TabSysBotLog";
            this.TabSysBotLog.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotLog.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotLog.TabIndex = 3;
            this.TabSysBotLog.Text = "Log";
            this.TabSysBotLog.UseVisualStyleBackColor = true;
            // 
            // SysBotLog
            // 
            this.SysBotLog.AccessibleName = "SysBotLog";
            this.SysBotLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SysBotLog.Location = new System.Drawing.Point(7, 7);
            this.SysBotLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SysBotLog.Name = "SysBotLog";
            this.SysBotLog.Size = new System.Drawing.Size(607, 460);
            this.SysBotLog.TabIndex = 5;
            this.SysBotLog.Text = "Started application.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 643);
            this.Controls.Add(this.SysBotTabControl);
            this.Controls.Add(this.GroupSysBotStatus);
            this.Controls.Add(this.GroupSysBotConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "MonstieHuntieHax";
            this.Load += new System.EventHandler(this.SysBotUI_Load);
            this.GroupSysBotConnection.ResumeLayout(false);
            this.GroupSysBotConnection.PerformLayout();
            this.GroupSysBotStatus.ResumeLayout(false);
            this.GroupSysBotStatus.PerformLayout();
            this.SysBotTabControl.ResumeLayout(false);
            this.TabSysBotPlayer.ResumeLayout(false);
            this.GroupSysBotCurrencies.ResumeLayout(false);
            this.GroupSysBotCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotBottleCaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotZeni)).EndInit();
            this.TabSysBotItems.ResumeLayout(false);
            this.GroupSysBotCharms.ResumeLayout(false);
            this.GroupSysBotCharms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmAdamant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmMight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmGathering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmMounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmFinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmRecovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmBuying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotCharmLucky)).EndInit();
            this.TabSysBotMonsties.ResumeLayout(false);
            this.TabSysBotMonsties.PerformLayout();
            this.TabSysBotLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.GroupBox GroupSysBotConnection;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.GroupBox GroupSysBotStatus;
        private System.Windows.Forms.TabControl SysBotTabControl;
        private System.Windows.Forms.TabPage TabSysBotPlayer;
        private System.Windows.Forms.TabPage TabSysBotMonsties;
        private System.Windows.Forms.Button ButtonSysbotRead;
        private System.Windows.Forms.TabPage TabSysBotLog;
        private System.Windows.Forms.RichTextBox SysBotLog;
        private System.Windows.Forms.Label StatusConnection;
        private System.Windows.Forms.Label StatusConnectionLabel;
        private System.Windows.Forms.GroupBox GroupSysBotCurrencies;
        private System.Windows.Forms.Label LabelSysBotZeni;
        private System.Windows.Forms.NumericUpDown CountSysBotZeni;
        private System.Windows.Forms.TabPage TabSysBotItems;
        private System.Windows.Forms.NumericUpDown CountSysBotBottleCaps;
        private System.Windows.Forms.Label LabelSysBotBottleCaps;
        private System.Windows.Forms.GroupBox GroupSysBotCharms;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmAdamant;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmMight;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmGathering;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmTraining;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmMounting;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmSelling;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmFinding;
        private System.Windows.Forms.Label LabelSysBotCharmAdamant;
        private System.Windows.Forms.Label LabelSysBotCharmMight;
        private System.Windows.Forms.Label LabelSysBotCharmGathering;
        private System.Windows.Forms.Label LabelSysBotCharmTraining;
        private System.Windows.Forms.Label LabelSysBotCharmMounting;
        private System.Windows.Forms.Label LabelSysBotCharmSelling;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmRecovery;
        private System.Windows.Forms.Label LabelSysBotCharmFinding;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmBuying;
        private System.Windows.Forms.NumericUpDown CountSysBotCharmLucky;
        private System.Windows.Forms.Label LabelSysBotCharmRecovery;
        private System.Windows.Forms.Label LabelSysBotCharmBuying;
        private System.Windows.Forms.Label LabelSysBotCharmLucky;
        private System.Windows.Forms.Label LabelWIP;
    }
}