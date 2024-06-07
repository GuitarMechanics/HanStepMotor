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
using MetroFramework.Controls;

namespace HanStepMotor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MetroTextBox[] _kinAssistTxtBoxes = new MetroTextBox[3];

        private double _transLimit = 30;
        private double _angLimitDeg = 60;
        private double _curveRadius = 30; // in mm
        private double _curveLength = 40;
        private bool _isResultValid;
        private string _receiveData;
        CCInternalTube nitiTube;
        private SerialPort usbPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            updateSerialPort();
            _kinAssistTxtBoxes[0] = kinDepthTxtBox;
            _kinAssistTxtBoxes[1] = kinHoffTxtBox;
            _kinAssistTxtBoxes[2] = kinAngTxtBox;
            nitiTube = new CCInternalTube(_curveRadius, _curveLength);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateSerialPort()
        {
            serialListCBox.Items.Clear();
            foreach (var ports in SerialPort.GetPortNames()) serialListCBox.Items.Add(ports);
            if (serialListCBox.Items.Count == 1)
            {
                serialListCBox.SelectedIndex = 0;
                SerialConnectBtn.PerformClick();
            }
        }

        private void SerialConnectBtn_Click(object sender, EventArgs e)
        {
            if (!usbPort.IsOpen)
            {
                usbPort.PortName = serialListCBox.SelectedItem.ToString();
                usbPort.BaudRate = 9600;
                usbPort.Parity = Parity.None;
                usbPort.StopBits = StopBits.One;
                usbPort.DataBits = 8;
                usbPort.ReadBufferSize = 20000000;
                usbPort.DataReceived += portDataReceived;
                try { usbPort.Open(); } 
                catch(Exception ex) { MessageBox.Show(ex.Message , "Failed to open port"); }
            }
        }

        private void ProcessingData()
        {
            string tmpStr = _receiveData.ToString();
        }
        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { if (usbPort.IsOpen) _receiveData = usbPort.ReadLine(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                this.Invoke(new Action(ProcessingData));
            }
            catch(ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
        }

        private void directCalcBtn_Click(object sender, EventArgs e)
        {
            double transValue = this._readTxtBoxEntry(directTransTxtBox);
            double rotValue = this._readTxtBoxEntry(directRotTxtBox);

            _updateCalcValidity();
            if(_isResultValid) _writeKinValues(nitiTube.posFromTrans(transValue));
            _calcResultDisplay();
        }

        private void depthCalcBtn_Click(object sender, EventArgs e)
        {
            double depthEntry = this._readTxtBoxEntry(kinDepthTxtBox);
            this._writeKinValues(nitiTube.posFromDepth(depthEntry));
            this.directTransTxtBox.Text = nitiTube.getTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
            this.directCalcBtn.PerformClick();
        }

        private void hoffCalcBtn_Click(object sender, EventArgs e)
        {
            double hoffEntry = this._readTxtBoxEntry(kinHoffTxtBox);
            this._writeKinValues(nitiTube.posFromHorpos(hoffEntry));
            this.directTransTxtBox.Text = nitiTube.getTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
            this.directCalcBtn.PerformClick();
        }

        private void angCalcBtn_Click(object sender, EventArgs e)
        {
            double angleEntry = this._readTxtBoxEntry(kinAngTxtBox);
            this._writeKinValues(nitiTube.posFromAngle(angleEntry));
            this.directTransTxtBox.Text = nitiTube.getTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
            this.directCalcBtn.PerformClick();
        }

        private void _calcResultDisplay()
        {
            if(this._isResultValid)
            {
                calcValidLabel.Text = "VALID";
                calcValidLabel.ForeColor = Color.Green;
            }
            else
            {
                calcValidLabel.Text = "INVALID";
                calcValidLabel.ForeColor = Color.Red;
            }
        }

        private void _writeKinValues(double[] kinValues)
        {
            for(int i = 0 ; i < kinValues.Length ; i++)
            {
                if (i == 2)
                {
                    double angDeg = kinValues[i] * 180 / Math.PI;
                    _kinAssistTxtBoxes[i].Text = angDeg.ToString();
                }
                else
                {
                    _kinAssistTxtBoxes[i].Text = kinValues[i].ToString();
                }
            }
        }

        private double _readTxtBoxEntry(MetroTextBox txtBox)
        {
            double tmpVal;
            try { tmpVal = Convert.ToDouble(txtBox.Text); }
            catch(Exception) { txtBox.Text = "0"; tmpVal = 0; }
            
            return tmpVal;
        }

        private void _updateCalcValidity()
        {
            double transVal = this._readTxtBoxEntry(directTransTxtBox);
            _isResultValid = (transVal > _transLimit || transVal < 0) ? false : true;
        }
    }
}
