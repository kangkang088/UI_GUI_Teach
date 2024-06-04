using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour {
    public Rect groupPos;
    public Rect scrollPos;
    public Rect showPos;
    public Vector2 nowPos;

    private string[] strings = new string[] { "111", "2464", "874864", "198796464" };
    private void OnGUI() {
        GUI.BeginGroup(groupPos);
        GUI.Button(new Rect(0, 0, 100, 100),"测试分组");
        GUI.EndGroup();

        nowPos = GUI.BeginScrollView(scrollPos,nowPos, showPos);
        GUI.Toolbar(new Rect(0, 0, 300, 50), 0, strings);
        GUI.Toolbar(new Rect(0, 60, 300, 50), 0, strings);
        GUI.Toolbar(new Rect(0, 120, 300, 50), 0, strings);
        GUI.Toolbar(new Rect(0, 180, 300, 50), 0, strings);
        GUI.EndScrollView();
    }
}
