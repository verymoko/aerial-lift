using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

namespace AerialLift
{
    public sealed class TransformEventHandler : MonoBehaviour
    {
        public void RotateX(float degrees) => transform.Rotate(Vector3.right, degrees, Space.Self);
        public void RotateY(float degrees) => transform.Rotate(Vector3.up, degrees, Space.Self);
        public void RotateZ(float degrees) => transform.Rotate(Vector3.forward, degrees, Space.Self);
    }
}
