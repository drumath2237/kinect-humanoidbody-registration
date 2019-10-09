using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectHumanoidBodyRegistration
{
    public class HumanoidBoneData
    {
        public Vector3 Position { get; private set; }
        public Quaternion Rotation { get; private set; }
    }
}