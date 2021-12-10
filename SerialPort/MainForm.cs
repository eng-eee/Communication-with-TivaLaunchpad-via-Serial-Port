using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string dataOut,recivedData;
		bool control=false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{

		}
		void BtnOpenClick(object sender, EventArgs e)
		{
			try {
			
			serialPort1.PortName = cBoxCOMPORT.Text;
			serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
			serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
			//serialPort1.StopBits = (StopBits)Enum.Parse((StopBits),cBoxStopBits.Text);
			serialPort1.Open();
			progressBar1.Value = 100;
			} catch (Exception err) {
				
				MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
				serialPort1.Close();
			progressBar1.Value = 0;
		}
		void BtnSendDataClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen){
				dataOut = tBoxDataOut.Text; // Lcd 2. satirda gözükecek metinler
				serialPort1.Write(dataOut);
			}
		}
		void SerialPort1DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			recivedData = serialPort1.ReadExisting();
			if(recivedData[0]=='*'){ // merhaba yazısı oku 
				control=false;
			}
			if(recivedData[0]=='#'){ // adc oku
				control=true;
			}
			if(control==true)
				this.Invoke(new EventHandler(DisplayAdc));
			else if(control==false)
				this.Invoke(new EventHandler(DisplayText));
		}
		private void DisplayAdc(object sender, EventArgs e){
			AdcRecived.Text =""; // ayni satirda gosterir
			AdcRecived.Text += recivedData;
		}
		private void DisplayText(object sender, EventArgs e){
			RecivedDataScreen.Text += recivedData; // merhaba yazisi alir
		}
		void ClearScreenClick(object sender, EventArgs e)
		{
			RecivedDataScreen.Text=""; // recived data ekranini temizler
		}
		void StartClockClick(object sender, EventArgs e)
		{
			serialPort1.Write("*"+TextStartClock.Text); // saatin ilk degerleri gönder
		}
		void LcdScreenClrClick(object sender, EventArgs e)
		{
			serialPort1.Write("#"); // Lcd 2. satir sil 
		}
	}
}
