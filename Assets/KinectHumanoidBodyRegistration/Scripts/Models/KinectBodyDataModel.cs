using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectHumanoidBodyRegistration
{
    public class KinectBodyDataModel
    {
        public static KinectBodyDataModel Instance = new KinectBodyDataModel();

        public JointData Head { get; private set; }
        public JointData Neck { get; private set; }
        public JointData SpineShoulder { get; private set; }
        public JointData SpineMid { get; private set; }
        public JointData SpineBase { get; private set; }
        public JointData ShoulderLeft { get; private set; }
        public JointData ShoulderRight { get; private set; }
        public JointData ElbowLeft { get; private set; }
        public JointData ElbowRight { get; private set; }
        public JointData WristLeft { get; private set; }
        public JointData WristRight { get; private set; }
        public JointData HipLeft { get; private set; }
        public JointData HipRight { get; private set; }
        public JointData KneeLeft { get; private set; }
        public JointData KneeRight { get; private set; }
        public JointData AnkleLeft { get; private set; }
        public JointData AnkleRight { get; private set; }
        public JointData FootLeft { get; private set; }
        public JointData FootRight { get; private set; }
    }
}
