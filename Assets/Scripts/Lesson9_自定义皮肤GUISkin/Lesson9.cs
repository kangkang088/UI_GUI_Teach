using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour {
    public GUISkin skin;
    private void OnGUI() {
        //GUI.color = Color.red;
        //GUI.Button(new Rect(0, 0, 100, 50), "测试按钮");
        //GUI.Label(new Rect(0, 50, 100, 50), "测试文本");
        GUI.skin = this.skin;
        GUI.Button(new Rect(0, 0, 100, 50), "测试按钮");
        GUI.Label(new Rect(0, 50, 100, 50), "测试文本");
    }
}
