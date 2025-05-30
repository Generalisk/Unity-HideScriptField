using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Object), true)]
public class HideScriptField : Editor
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
