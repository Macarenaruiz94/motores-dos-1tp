using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    Change change;

    [MenuItem("Window/ShapeShifter")]
    public static void ShowWindow ()
    {
        GetWindow<ExampleWindow>("ShapeShifter");
    }
    private void OnGUI()
    {
        GUILayout.Label("Change the object!", EditorStyles.boldLabel);

        change = EditorGUILayout.ObjectField("Change", change);

        if (GUILayout.Button("Change"))
        {
            ChangeShape();
        }
    }

    void ChangeShape()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.change = change;
            }
        }
    }
}
