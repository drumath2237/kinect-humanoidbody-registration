using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectHumanoidBodyRegistration
{
    public class JointData
    {
        public Vector3 Position { get; private set; } = new Vector3();
        public Quaternion Rotation { get; private set; } = Quaternion.identity;

        public void SetPosition(Vector3 pos)
        {
            Position = pos;
        }

        public void SetRotation(Quaternion rot)
        {
            Rotation = rot;
        }
    }
}