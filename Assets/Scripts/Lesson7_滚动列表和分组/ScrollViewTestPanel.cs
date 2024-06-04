using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewTestPanel : MonoBehaviour {
    public Rect scrollViewPos;
    public Rect contentPos;
    private Vector2 nowPos;

    public string[] strings;
    private void OnGUI() {
        contentPos.height = strings.Length * 30;
        nowPos = GUI.BeginScrollView(scrollViewPos, nowPos, contentPos);
        for (int i = 0; i < strings.Length; i++) {
            GUI.Label(new Rect(0, i * 30, 100, 30), strings[i]);
        }
        GUI.EndScrollView();
    }
}
