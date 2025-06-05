using UnityEditor;
using UnityEngine;

namespace Generalisk.HideSceriptField.Editor
{
    [CustomEditor(typeof(Object), true)]
    public sealed class HideScriptField : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
            DrawPropertiesExcluding(serializedObject, "m_Script");
            if (EditorGUI.EndChangeCheck())
            { serializedObject.ApplyModifiedProperties(); }
        }
    }
}
