using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class window : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorear")]
    public static void MostrarWindow()
    {
        GetWindow<window>("Colorear");
    }
    private void OnGUI()
    {
        GUILayout.Label("Colorear los objetos", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorear"))
        {
            Colorear();
        }

        void Colorear()
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.sharedMaterial.color = color;
                }
            }
        }
    }
}
