
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
            this.CountSysBotZeni = new System.Windows.Forms.NumericUpDown();
            this.LabelSysBotZeni = new System.Windows.Forms.Label();
            this.TabSysBotItems = new System.Windows.Forms.TabPage();
            this.TabSysBotMonsties = new System.Windows.Forms.TabPage();
            this.TabSysBotLog = new System.Windows.Forms.TabPage();
            this.SysBotLog = new System.Windows.Forms.RichTextBox();
            this.LabelSysBotBottleCaps = new System.Windows.Forms.Label();
            this.CountSysBotBottleCaps = new System.Windows.Forms.NumericUpDown();
            this.GroupSysBotConnection.SuspendLayout();
            this.GroupSysBotStatus.SuspendLayout();
            this.SysBotTabControl.SuspendLayout();
            this.TabSysBotPlayer.SuspendLayout();
            this.GroupSysBotCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotZeni)).BeginInit();
            this.TabSysBotLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotBottleCaps)).BeginInit();
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
            this.GroupSysBotCurrencies.Location = new System.Drawing.Point(451, 384);
            this.GroupSysBotCurrencies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotCurrencies.Name = "GroupSysBotCurrencies";
            this.GroupSysBotCurrencies.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupSysBotCurrencies.Size = new System.Drawing.Size(167, 79);
            this.GroupSysBotCurrencies.TabIndex = 10;
            this.GroupSysBotCurrencies.TabStop = false;
            this.GroupSysBotCurrencies.Text = "Currencies";
            // 
            // CountSysBotZeni
            // 
            this.CountSysBotZeni.AccessibleName = "CountSysBotZeni";
            this.CountSysBotZeni.Enabled = false;
            this.CountSysBotZeni.Location = new System.Drawing.Point(63, 18);
            this.CountSysBotZeni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CountSysBotZeni.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.CountSysBotZeni.Name = "CountSysBotZeni";
            this.CountSysBotZeni.Size = new System.Drawing.Size(97, 23);
            this.CountSysBotZeni.TabIndex = 1;
            this.CountSysBotZeni.ValueChanged += new System.EventHandler(this.SysBotZeniCount_ValueChanged);
            // 
            // LabelSysBotZeni
            // 
            this.LabelSysBotZeni.AccessibleName = "LabelSysBotZeni";
            this.LabelSysBotZeni.AutoSize = true;
            this.LabelSysBotZeni.Location = new System.Drawing.Point(7, 21);
            this.LabelSysBotZeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSysBotZeni.Name = "LabelSysBotZeni";
            this.LabelSysBotZeni.Size = new System.Drawing.Size(33, 15);
            this.LabelSysBotZeni.TabIndex = 0;
            this.LabelSysBotZeni.Text = "Zeni:";
            // 
            // TabSysBotItems
            // 
            this.TabSysBotItems.AccessibleName = "TabSysBotItems";
            this.TabSysBotItems.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotItems.Name = "TabSysBotItems";
            this.TabSysBotItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotItems.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotItems.TabIndex = 1;
            this.TabSysBotItems.Text = "Items";
            this.TabSysBotItems.UseVisualStyleBackColor = true;
            // 
            // TabSysBotMonsties
            // 
            this.TabSysBotMonsties.AccessibleName = "TabSysBotMonsties";
            this.TabSysBotMonsties.Location = new System.Drawing.Point(4, 24);
            this.TabSysBotMonsties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotMonsties.Name = "TabSysBotMonsties";
            this.TabSysBotMonsties.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSysBotMonsties.Size = new System.Drawing.Size(622, 469);
            this.TabSysBotMonsties.TabIndex = 2;
            this.TabSysBotMonsties.Text = "Monsties";
            this.TabSysBotMonsties.UseVisualStyleBackColor = true;
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
            // LabelSysBotBottleCaps
            // 
            this.LabelSysBotBottleCaps.AccessibleName = "LabelSysBotBottleCaps";
            this.LabelSysBotBottleCaps.AutoSize = true;
            this.LabelSysBotBottleCaps.Location = new System.Drawing.Point(7, 49);
            this.LabelSysBotBottleCaps.Name = "LabelSysBotBottleCaps";
            this.LabelSysBotBottleCaps.Size = new System.Drawing.Size(70, 15);
            this.LabelSysBotBottleCaps.TabIndex = 5;
            this.LabelSysBotBottleCaps.Text = "Bottle Caps:";
            // 
            // CountSysBotBottleCaps
            // 
            this.CountSysBotBottleCaps.AccessibleName = "CountSysBotBottleCaps";
            this.CountSysBotBottleCaps.Enabled = false;
            this.CountSysBotBottleCaps.Location = new System.Drawing.Point(83, 47);
            this.CountSysBotBottleCaps.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CountSysBotBottleCaps.Name = "CountSysBotBottleCaps";
            this.CountSysBotBottleCaps.Size = new System.Drawing.Size(77, 23);
            this.CountSysBotBottleCaps.TabIndex = 6;
            this.CountSysBotBottleCaps.ValueChanged += new System.EventHandler(this.CountSysBotBottleCaps_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotZeni)).EndInit();
            this.TabSysBotLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountSysBotBottleCaps)).EndInit();
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
    }
}