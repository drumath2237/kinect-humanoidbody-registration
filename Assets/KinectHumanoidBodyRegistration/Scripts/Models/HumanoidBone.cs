using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectHumanoidBodyRegistration
{
    public class HumanoidBoneData
    {
        public Vector3 Position { get; private set; }
        public Quaternion Rotation { get; private set; }
        public void SetData(Vector3 pos, Quaternion rot)
        {
            Position = pos;
            Rotation = rot;
        }

        public void SetData(JointData data)
        {
            Position = data.Position;
            Rotation = data.Rotation;
        }
    }

}