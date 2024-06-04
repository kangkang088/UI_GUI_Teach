using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanel : MonoBehaviour {
    public Rect winPos;

    public Rect labelPos;
    public Rect btn1Pos;
    public Rect btn2Pos;

    private static ExitPanel instance;
    public static ExitPanel Instance {
        get { return instance; }
    }
    private void Awake() {
        instance = this;
        HideMe();
    }
    public static void ShowMe() {
        if (instance != null) {
            instance.gameObject.SetActive(true);
        }
    }
    public static void HideMe() {
        if (instance != null) {
            instance.gameObject.SetActive(false);
        }
    }
    private void OnGUI() {
        GUI.ModalWindow(1, winPos, DrawWindow, "提示");
    }
    private void DrawWindow(int id) {
        GUI.Label(labelPos, "确定退出？");
        if(GUI.Button(btn1Pos, "确定")) {
            Application.Quit();
        }
        if(GUI.Button(btn2Pos, "取消")) {
            Lesson2_Exercises.ShowMe();
            HideMe();
        }
    }
}
