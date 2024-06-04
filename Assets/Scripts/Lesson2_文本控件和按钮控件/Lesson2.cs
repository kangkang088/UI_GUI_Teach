using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture tex;
    public Rect rec;
    public GUIContent content;
    public GUIStyle style;
    public GUIStyle btnStyle;
    public GUIContent btnContent;
    public Rect btnRect;
    private void OnGUI() {
        GUI.Label(new Rect(0, 0, 100, 200), "kangkang");
        GUI.Label(rec, content,style);
        GUI.Button(btnRect, btnContent,btnStyle);
    }
}
