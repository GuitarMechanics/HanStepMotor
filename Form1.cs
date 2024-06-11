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

        private const double _transLimit = 30;
        private const double _angLimitDeg = 60;
        private const double _curveRadius = 30; // in mm
        private const double _curveLength = 40;

        private const int _transPitch = 10;
        private const int _transSteps = 800;
        private const int _rotSteps = 800;

        private int _mtRotOffset = 0;
        private int _mtTransOffset = 0;
        private int _mtRotTarget;
        private int _mtTransTarget;

        private double _mtRotTargetDeg;
        private double _mtTransTargetmm;

        private bool _isResultValid;
        private string _receiveData;

        private bool _isMtAvail = true;
        private bool _isFuncIdle = true;

        private CCInternalTube nitiTube;
        private StepMotor transMotor;
        private StepMotor rotMotor;
        private SerialPort usbPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            UpdateSerialPort();
            _kinAssistTxtBoxes[0] = kinDepthTxtBox;
            _kinAssistTxtBoxes[1] = kinHoffTxtBox;
            _kinAssistTxtBoxes[2] = kinAngTxtBox;
            nitiTube = new CCInternalTube(_curveRadius, _curveLength);
            transMotor = new StepMotor(_transSteps, _transPitch);
            rotMotor = new StepMotor(_rotSteps);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSerialPort()
        {
            serialListCBox.Items.Clear();
            foreach (var ports in SerialPort.GetPortNames()) serialListCBox.Items.Add(ports);
            if (serialListCBox.Items.Count == 1)
            {
                serialListCBox.SelectedIndex = 0;
                usbPort.PortName = serialListCBox.SelectedItem.ToString();
                usbPort.BaudRate = 9600;
                usbPort.Parity = Parity.None;
                usbPort.StopBits = StopBits.One;
                usbPort.DataBits = 8;
                usbPort.ReadBufferSize = 20000000;
                usbPort.DataReceived += PortDataReceived;
                try { usbPort.Open(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Failed to open port"); }
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
                usbPort.DataReceived += PortDataReceived;
                try { usbPort.Open(); } 
                catch(Exception ex) { MessageBox.Show(ex.Message , "Failed to open port"); }
            }
        }

        private void ProcessingData()
        {
            string tmpStr = _receiveData.ToString();
            Console.WriteLine(tmpStr);
            try { _isMtAvail = (Convert.ToInt32(tmpStr) == 11) ? true : false; }
            catch(Exception) { };
            _MtStatusDisplay();
        }
        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { if (usbPort.IsOpen) _receiveData = usbPort.ReadLine(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                this.Invoke(new Action(ProcessingData));
            }
            catch(ObjectDisposedException ex) { Console.WriteLine(ex.Message); }
        }

        private void _MtStatusDisplay()
        {
            if(_isMtAvail)
            {
                mtAvailLabel.Text = "AVAIL";
                mtAvailLabel.ForeColor = Color.Green;
            }
            else
            {
                mtAvailLabel.Text = "RUNNING";
                mtAvailLabel.ForeColor = Color.DarkRed;
            }
        }

        private void DirectCalcBtn_Click(object sender, EventArgs e)
        {
            double transValue = this._readTxtBoxEntry(directTransTxtBox);
            double rotValue = this._readTxtBoxEntry(directRotTxtBox);

            _updateCalcValidity();
            if(_isResultValid) _writeKinValues(nitiTube.PosFromTrans(transValue));
            _calcResultDisplay();
        }

        private void DepthCalcBtn_Click(object sender, EventArgs e)
        {
            double depthEntry = this._readTxtBoxEntry(kinDepthTxtBox);
            this._writeKinValues(nitiTube.PosFromDepth(depthEntry));
            this.directTransTxtBox.Text = nitiTube.GetTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
            this.directCalcBtn.PerformClick();
        }

        private void HoffCalcBtn_Click(object sender, EventArgs e)
        {
            double hoffEntry = this._readTxtBoxEntry(kinHoffTxtBox);
            this._writeKinValues(nitiTube.PosFromHorpos(hoffEntry));
            this.directTransTxtBox.Text = nitiTube.GetTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
            this.directCalcBtn.PerformClick();
        }

        private void AngCalcBtn_Click(object sender, EventArgs e)
        {
            double angleEntry = this._readTxtBoxEntry(kinAngTxtBox);
            this._writeKinValues(nitiTube.PosFromAngle(angleEntry));
            this.directTransTxtBox.Text = nitiTube.GetTransFromAngDeg(this._readTxtBoxEntry(kinAngTxtBox)).ToString();
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
                calcValidLabel.ForeColor = Color.DarkRed;
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

        private void mtZeroBtn_Click(object sender, EventArgs e)
        {
            this._mtRotTarget = 0;
            this._mtTransTarget = 0;
            this._mtRotTargetDeg = 0;
            this._mtTransTargetmm = 0;
            this._mtPosSend();
        }

        private void _mtPosSend()
        {
            string sendStr = 0.ToString() + "," + (_mtTransOffset + _mtTransTarget).ToString() + "," + (_mtRotOffset + _mtRotTarget).ToString();
            usbPort.WriteLine(sendStr);
            this._writeMotorLabelValue();
            Console.WriteLine("Sent : " + sendStr);
        }

        private void _mtZeroPosSend()
        {
            string sendStr = 1.ToString() + "," + (_mtTransOffset + _mtTransTarget).ToString() + "," + (_mtRotOffset + _mtRotTarget).ToString();
            usbPort.WriteLine(sendStr);
            this._writeMotorLabelValue();
            Console.WriteLine("Sent : " + sendStr);
        }

        private void mtRunBtn_Click(object sender, EventArgs e)
        {
            this._mtRotTarget = rotMotor.Deg2Steps(this._readTxtBoxEntry(this.directRotTxtBox));
            this._mtTransTarget = transMotor.Trans2Steps(this._readTxtBoxEntry(this.directTransTxtBox));
            this._mtRotTargetDeg = this._readTxtBoxEntry(this.directRotTxtBox);
            this._mtTransTargetmm = this._readTxtBoxEntry(this.directTransTxtBox);
            this._mtPosSend();
            this._isMtAvail = false;
            this._MtStatusDisplay();
        }

        private void _writeMotorLabelValue()
        {
            this.transStatusLabel.Text = this._mtTransTargetmm.ToString();
            this.rotStatusLabel.Text = this._mtRotTargetDeg.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(usbPort.IsOpen)
            {
                this._mtRotTarget = 0;
                this._mtTransTarget = 0;
                this._mtRotTargetDeg = 0;
                this._mtTransTargetmm = 0;
                this._mtPosSend();
            }
        }

        private void zeroingPosTrans_Click(object sender, EventArgs e)
        {
            this._mtTransOffset += transMotor.Trans2Steps(1.0); this._mtZeroPosSend();
        }

        private void zeroingNegTrans_Click(object sender, EventArgs e)
        {
            this._mtTransOffset -= transMotor.Trans2Steps(1.0); this._mtZeroPosSend();
        }

        private void zeroingPosRot_Click(object sender, EventArgs e)
        {
            this._mtRotOffset += rotMotor.Deg2Steps(1.0); this._mtZeroPosSend();
        }

        private void zeroingNegRot_Click(object sender, EventArgs e)
        {
            this._mtRotOffset -= rotMotor.Deg2Steps(1.0); this._mtZeroPosSend();
        }
    }
}
