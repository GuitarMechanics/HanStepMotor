using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanStepMotor
{
    internal class CCInternalTube
    {
        private double _curveRadius;
        private double _curveLength;
        private double _straightLength;

        public CCInternalTube(double curveRadius, double curveLength)
        {
            this._curveRadius = curveRadius;
            this._curveLength = curveLength;
        }

        public double[] posFromAngle(double targetAngleDeg)
        {
            double[] pos = new double[3];
            double angRad = this._deg2Rad(targetAngleDeg);
            double depth = this._curveRadius * Math.Sin(angRad);
            double horpos = this._curveRadius * (1 - Math.Cos(angRad));
            pos[0] = depth;
            pos[1] = horpos;
            pos[2] = targetAngleDeg;
            return pos;
        }

        public double[] posFromDepth(double targetDepth)
        {
            double[] pos = new double[3];
            double depth = targetDepth;
            double angRad = Math.Asin(depth / this._curveRadius);
            double horpos = this._curveRadius * (1 - Math.Cos(angRad));
            pos[0] = depth;
            pos[1] = horpos;
            pos[2] = angRad;
            return pos;
        }

        public double[] posFromHorpos(double horpos)
        {
            double[] pos = new double[3];
            double angRad = Math.Acos(1 - horpos / this._curveRadius);
            double depth = this._curveRadius * Math.Sin(angRad);
            pos[0] = depth;
            pos[1] = horpos;
            pos[2] = angRad;
            return pos;
        }

        public double[] posFromTrans(double trans)
        {
            double[] pos = new double[3];
            double angRad = trans / this._curveRadius;
            return posFromAngle(angRad);
        }

        public double getTransFromAng(double angRad)
        {
            double transVal;
            transVal = this._curveRadius * angRad;
            return transVal;
        }

        private double _deg2Rad(double deg)
        {
            double retVal;
            retVal = Math.PI * 2 * deg / 360.0;
            return retVal;
        }
    }
}
