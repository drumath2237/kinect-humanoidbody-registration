using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Kinect = Windows.Kinect;

namespace KinectHumanoidBodyRegistration
{
    public class KinectBodyDataModel
    {
        public static KinectBodyDataModel Instance = new KinectBodyDataModel();

        /// <summary>
        /// jointの種類とjointデータが対になったデータ
        /// </summary>
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

        /// <summary>
        /// JointDataのデータを登録するためのメソッド
        /// </summary>
        /// <param name="joint_type">Jointの種類</param>
        /// <param name="data">Jointデータ</param>
        public void SetJointDataValue(Kinect.JointType joint_type, JointData data)
        {
            if (Joints[joint_type] == null) return;
            if (data.Rotation == null) return;

            Joints[joint_type] = data;
        }

        /// <summary>
        /// Jointデータを取得するためのメソッド
        /// </summary>
        /// <param name="joint_type"></param>
        /// <returns></returns>
        public JointData GetJointDataValue(Kinect.JointType joint_type)
        {
            return Joints[joint_type] == null ? new JointData() : Joints[joint_type];
        }
    }
}
