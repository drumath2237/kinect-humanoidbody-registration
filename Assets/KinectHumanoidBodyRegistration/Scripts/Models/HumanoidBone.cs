using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KinectHumanoidBodyRegistration
{
    public class HumanoidBoneData
    {
        public Vector3 Position { get; private set; }
        public Quaternion Rotation { get; private set; }

        /// <summary>
        /// HumanoidBoneの情報を登録するメソッド
        /// </summary>
        /// <param name="pos">位置</param>
        /// <param name="rot">回転</param>
        public void SetData(Vector3 pos, Quaternion rot)
        {
            Position = pos;
            Rotation = rot;
        }

        /// <summary>
        /// JointDataから情報を登録
        /// </summary>
        /// <param name="data">Jointデータ</param>
        public void SetData(JointData data)
        {
            Position = data.Position;
            Rotation = data.Rotation;
        }
    }

}