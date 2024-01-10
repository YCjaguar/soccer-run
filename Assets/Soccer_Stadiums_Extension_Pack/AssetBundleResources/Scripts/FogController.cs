using UnityEngine;
using System.Collections;

#if UNITY_EDITOR

using UnityEditor;

[CustomEditor(typeof(FogController))]
public class FogControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var fog = target as FogController;

        EditorGUI.BeginChangeCheck();

        fog.isFogActive = EditorGUILayout.Toggle("フォグの有効/無効", fog.isFogActive);

        fog.fogColor = EditorGUILayout.ColorField("RGB", fog.fogColor);

        fog.fogMode = (FogMode)EditorGUILayout.EnumPopup(fog.fogMode);

        fog.fogStartDistance = EditorGUILayout.FloatField("Start",fog.fogStartDistance);

        fog.fogEndDistance = EditorGUILayout.FloatField("End", fog.fogEndDistance);

        if (EditorGUI.EndChangeCheck())
        {
            fog.SetFog();
        }

        
    }
}

#endif

public class FogController:MonoBehaviour {

    public bool isFogActive;

    public Color fogColor;

    public FogMode fogMode;

    public float fogStartDistance;

    public float fogEndDistance;

    /*[Button("SetFog","反映")]
    public int SetFogButton;*/

    public void Start() {
        SetFog();
    }

    public void SetFog()
    {
        RenderSettings.fog = isFogActive;
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogMode = fogMode;
        RenderSettings.fogStartDistance = fogStartDistance;
        RenderSettings.fogEndDistance = fogEndDistance;
    }

}
