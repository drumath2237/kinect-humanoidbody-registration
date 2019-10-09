using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Kinect = Windows.Kinect;

namespace KinectHumanoidBodyRegistration
{
    public class KinectBodyDataModel
    {
        public static KinectBodyDataModel Instance = new KinectBodyDataModel();

        private Dictionary<Kinect.JointType, JointData> Joints = new Dictionary<Kinect.JointType, JointData>()
        {
            { Kinect.JointType.Head, new JointData() },
            { Kinect.JointType.Neck, new JointData() },
            { Kinect.JointType.SpineBase, new JointData() },
            { Kinect.JointType.SpineMid, new JointData() },
            { Kinect.JointType.SpineBase, new JointData() },
            { Kinect.JointType.ShoulderLeft, new JointData() },
            { Kinect.JointType.ShoulderRight, new JointData() },
            { Kinect.JointType.ElbowLeft, new JointData() },
            { Kinect.JointType.ElbowRight, new JointData() },
            { Kinect.JointType.WristLeft, new JointData() },
            { Kinect.JointType.WristRight, new JointData() },
            { Kinect.JointType.HipLeft, new JointData() },
            { Kinect.JointType.HipRight, new JointData() },
            { Kinect.JointType.KneeLeft, new JointData() },
            { Kinect.JointType.KneeRight, new JointData() },
            { Kinect.JointType.AnkleLeft, new JointData() },
            { Kinect.JointType.AnkleRight, new JointData() },
            { Kinect.JointType.FootLeft, new JointData() },
            { Kinect.JointType.FootRight, new JointData() },
        };
    }
}
