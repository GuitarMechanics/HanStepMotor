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

        private double _transLimit = 25;
        private double _angLimitDeg = 60;
        private double _curveRadius = 30; // in mm
        private double _curveLength = 40;
        private bool _isResultValid;
        CCInternalTube nitiTube;

        public Form1()
        {
            InitializeComponent();
            _kinAssistTxtBoxes[0] = kinDepthTxtBox;
            _kinAssistTxtBoxes[1] = kinHoffTxtBox;
            _kinAssistTxtBoxes[2] = kinAngTxtBox;
            nitiTube = new CCInternalTube(_curveRadius, _curveLength);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void directCalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(directTransTxtBox.Text);
            }
            catch(Exception) { directTransTxtBox.Text = "0"; }
            double transValue = Convert.ToDouble(directTransTxtBox.Text);

            try
            {
                Convert.ToDouble(directRotTxtBox.Text);
            }
            catch(Exception) { directRotTxtBox.Text = "0"; }
            double rotValue = Convert.ToDouble(directRotTxtBox.Text);

            if (transValue > _transLimit || transValue < 0) _isResultValid = false;
            else
            {
                _isResultValid = true;
                _writeKinValues(nitiTube.posFromTrans(transValue));
            }
            _calcResultDisplay();
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

        
    }
}
