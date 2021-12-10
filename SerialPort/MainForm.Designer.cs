/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3.12.2021
 * Time: 02:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SerialPort
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cBoxParityBits;
		private System.Windows.Forms.ComboBox cBoxStopBits;
		private System.Windows.Forms.ComboBox cBoxDataBits;
		private System.Windows.Forms.ComboBox CBoxBaudRate;
		private System.Windows.Forms.ComboBox cBoxCOMPORT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSendData;
		private System.Windows.Forms.TextBox tBoxDataOut;
		private System.Windows.Forms.TextBox RecivedDataScreen;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button ClearScreen;
		private System.Windows.Forms.TextBox AdcRecived;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TextStartClock;
		private System.Windows.Forms.Button StartClock;
		private System.Windows.Forms.Button LcdScreenClr;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cBoxParityBits = new System.Windows.Forms.ComboBox();
			this.cBoxStopBits = new System.Windows.Forms.ComboBox();
			this.cBoxDataBits = new System.Windows.Forms.ComboBox();
			this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
			this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnSendData = new System.Windows.Forms.Button();
			this.tBoxDataOut = new System.Windows.Forms.TextBox();
			this.RecivedDataScreen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ClearScreen = new System.Windows.Forms.Button();
			this.AdcRecived = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.TextStartClock = new System.Windows.Forms.TextBox();
			this.StartClock = new System.Windows.Forms.Button();
			this.LcdScreenClr = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM3";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cBoxParityBits);
			this.groupBox1.Controls.Add(this.cBoxStopBits);
			this.groupBox1.Controls.Add(this.cBoxDataBits);
			this.groupBox1.Controls.Add(this.CBoxBaudRate);
			this.groupBox1.Controls.Add(this.cBoxCOMPORT);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(326, 171);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "COM PORT SETTINGS";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "PARITY BITS";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "STOP BITS";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "DATA BITS";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "BAUDRATE";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "COM PORT";
			// 
			// cBoxParityBits
			// 
			this.cBoxParityBits.FormattingEnabled = true;
			this.cBoxParityBits.Items.AddRange(new object[] {
			"NONE",
			"ODD",
			"EVEN"});
			this.cBoxParityBits.Location = new System.Drawing.Point(110, 130);
			this.cBoxParityBits.Name = "cBoxParityBits";
			this.cBoxParityBits.Size = new System.Drawing.Size(140, 21);
			this.cBoxParityBits.TabIndex = 4;
			// 
			// cBoxStopBits
			// 
			this.cBoxStopBits.FormattingEnabled = true;
			this.cBoxStopBits.Items.AddRange(new object[] {
			"ONE",
			"TWO"});
			this.cBoxStopBits.Location = new System.Drawing.Point(110, 103);
			this.cBoxStopBits.Name = "cBoxStopBits";
			this.cBoxStopBits.Size = new System.Drawing.Size(140, 21);
			this.cBoxStopBits.TabIndex = 3;
			// 
			// cBoxDataBits
			// 
			this.cBoxDataBits.FormattingEnabled = true;
			this.cBoxDataBits.Items.AddRange(new object[] {
			"5",
			"6",
			"7",
			"8"});
			this.cBoxDataBits.Location = new System.Drawing.Point(110, 76);
			this.cBoxDataBits.Name = "cBoxDataBits";
			this.cBoxDataBits.Size = new System.Drawing.Size(140, 21);
			this.cBoxDataBits.TabIndex = 2;
			// 
			// CBoxBaudRate
			// 
			this.CBoxBaudRate.FormattingEnabled = true;
			this.CBoxBaudRate.Items.AddRange(new object[] {
			"2400",
			"4800",
			"7200",
			"9600",
			"115200"});
			this.CBoxBaudRate.Location = new System.Drawing.Point(110, 49);
			this.CBoxBaudRate.Name = "CBoxBaudRate";
			this.CBoxBaudRate.Size = new System.Drawing.Size(140, 21);
			this.CBoxBaudRate.TabIndex = 1;
			// 
			// cBoxCOMPORT
			// 
			this.cBoxCOMPORT.FormattingEnabled = true;
			this.cBoxCOMPORT.Items.AddRange(new object[] {
			"COM1",
			"COM2",
			"COM3",
			"COM4",
			"COM5",
			"COM6"});
			this.cBoxCOMPORT.Location = new System.Drawing.Point(111, 27);
			this.cBoxCOMPORT.Name = "cBoxCOMPORT";
			this.cBoxCOMPORT.Size = new System.Drawing.Size(140, 21);
			this.cBoxCOMPORT.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.progressBar1);
			this.groupBox2.Controls.Add(this.btnClose);
			this.groupBox2.Controls.Add(this.btnOpen);
			this.groupBox2.Location = new System.Drawing.Point(14, 189);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(230, 128);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Serial Port";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(15, 48);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(182, 72);
			this.progressBar1.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(110, 19);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(15, 19);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(87, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "OPEN";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// btnSendData
			// 
			this.btnSendData.Location = new System.Drawing.Point(251, 189);
			this.btnSendData.Name = "btnSendData";
			this.btnSendData.Size = new System.Drawing.Size(98, 42);
			this.btnSendData.TabIndex = 2;
			this.btnSendData.Text = "Send Data";
			this.btnSendData.UseVisualStyleBackColor = true;
			this.btnSendData.Click += new System.EventHandler(this.BtnSendDataClick);
			// 
			// tBoxDataOut
			// 
			this.tBoxDataOut.Location = new System.Drawing.Point(385, 37);
			this.tBoxDataOut.Multiline = true;
			this.tBoxDataOut.Name = "tBoxDataOut";
			this.tBoxDataOut.Size = new System.Drawing.Size(160, 222);
			this.tBoxDataOut.TabIndex = 3;
			// 
			// RecivedDataScreen
			// 
			this.RecivedDataScreen.BackColor = System.Drawing.SystemColors.MenuText;
			this.RecivedDataScreen.ForeColor = System.Drawing.SystemColors.Window;
			this.RecivedDataScreen.Location = new System.Drawing.Point(551, 37);
			this.RecivedDataScreen.Multiline = true;
			this.RecivedDataScreen.Name = "RecivedDataScreen";
			this.RecivedDataScreen.Size = new System.Drawing.Size(165, 222);
			this.RecivedDataScreen.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(417, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "SenderData";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(581, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "RecivedData";
			// 
			// ClearScreen
			// 
			this.ClearScreen.Location = new System.Drawing.Point(251, 237);
			this.ClearScreen.Name = "ClearScreen";
			this.ClearScreen.Size = new System.Drawing.Size(98, 43);
			this.ClearScreen.TabIndex = 7;
			this.ClearScreen.Text = "ClearScreen";
			this.ClearScreen.UseVisualStyleBackColor = true;
			this.ClearScreen.Click += new System.EventHandler(this.ClearScreenClick);
			// 
			// AdcRecived
			// 
			this.AdcRecived.Location = new System.Drawing.Point(487, 273);
			this.AdcRecived.Name = "AdcRecived";
			this.AdcRecived.Size = new System.Drawing.Size(165, 20);
			this.AdcRecived.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(385, 276);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Adc Data";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(385, 310);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "TextStartClock";
			// 
			// TextStartClock
			// 
			this.TextStartClock.Location = new System.Drawing.Point(487, 310);
			this.TextStartClock.Name = "TextStartClock";
			this.TextStartClock.Size = new System.Drawing.Size(165, 20);
			this.TextStartClock.TabIndex = 11;
			// 
			// StartClock
			// 
			this.StartClock.Location = new System.Drawing.Point(668, 310);
			this.StartClock.Name = "StartClock";
			this.StartClock.Size = new System.Drawing.Size(48, 23);
			this.StartClock.TabIndex = 12;
			this.StartClock.Text = "Start";
			this.StartClock.UseVisualStyleBackColor = true;
			this.StartClock.Click += new System.EventHandler(this.StartClockClick);
			// 
			// LcdScreenClr
			// 
			this.LcdScreenClr.Location = new System.Drawing.Point(251, 286);
			this.LcdScreenClr.Name = "LcdScreenClr";
			this.LcdScreenClr.Size = new System.Drawing.Size(98, 31);
			this.LcdScreenClr.TabIndex = 13;
			this.LcdScreenClr.Text = "LcdScreenClr";
			this.LcdScreenClr.UseVisualStyleBackColor = true;
			this.LcdScreenClr.Click += new System.EventHandler(this.LcdScreenClrClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 348);
			this.Controls.Add(this.LcdScreenClr);
			this.Controls.Add(this.StartClock);
			this.Controls.Add(this.TextStartClock);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.AdcRecived);
			this.Controls.Add(this.ClearScreen);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RecivedDataScreen);
			this.Controls.Add(this.tBoxDataOut);
			this.Controls.Add(this.btnSendData);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Name = "MainForm";
			this.Text = "C# COM PORT SERIAL";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
