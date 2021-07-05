using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AerialLift;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

[CustomEditor(typeof(TransformEventHandler))]
internal sealed class TransformEventHandlerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.HelpBox("To use this component call it from Button's On Click or by similar means", MessageType.None);
    }
}
