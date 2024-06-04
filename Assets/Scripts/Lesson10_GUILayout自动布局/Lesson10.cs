using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour {
    private void OnGUI() {
        //GUILayout.BeginArea(new Rect(100, 100, 200, 300));

        GUILayout.BeginVertical();

        GUILayout.Button("123",GUILayout.Width(300));
        GUILayout.Button("245666");
        GUILayout.Button("235",GUILayout.ExpandWidth(false));

        GUILayout.EndVertical();

        //GUILayout.EndArea();
    }
}
