using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanStepMotor
{
    internal class StepMotor
    {
        private int _stepPerRev;
        private double _pitchPerRev;
        private bool _isTrans = false;
        public StepMotor(int stepsPerRotation)
        { 
            _stepPerRev = stepsPerRotation;
        }

        public StepMotor(int stepPerRev, double pitchPerRev)
        {
            _pitchPerRev = pitchPerRev;
            _stepPerRev = stepPerRev;
            _isTrans = true;
        }

        public int Deg2Steps(double deg)
        {
            int retVal;
            retVal = Convert.ToInt32(Math.Round(_stepPerRev * deg / 360));
            return retVal;
        }
        public int Rad2Steps(double rad)
        {
            int retVal;
            retVal = Convert.ToInt32(Math.Round(_stepPerRev * rad / 2 * Math.PI));
            return retVal;
        }
        public int Trans2Steps(double transLength)
        {
            if(_isTrans)
            {
                int retVal;
                retVal = Convert.ToInt32(Math.Round(transLength / _pitchPerRev * _stepPerRev));
                return retVal;
            }
            else
            {
                throw new Exception("Not a translation motor");
            }
        }
    }
}
