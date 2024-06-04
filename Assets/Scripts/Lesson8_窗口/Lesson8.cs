using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour {
    private Rect r = new Rect(400,400,200,150);
    private void OnGUI() {
        GUI.Window(1, new Rect(100, 100, 200, 150), DrawWindow, "测试窗口");
        //GUI.ModalWindow(3, new Rect(300, 500, 200, 150), DrawWindow, "模态窗口");
        r = GUI.Window(4, r, DrawWindow, "拖动窗口");
    }
    private void DrawWindow(int id) {
        switch (id) {
            case 1:
                GUI.Button(new Rect(0, 0, 30, 20), "1");
                break;
            case 3:
                GUI.Button(new Rect(0, 50, 30, 20), "3");
                break;
            case 4:
                GUI.Button(new Rect(0, 50, 30, 20), "4");
                GUI.DragWindow();
                break;
            default:
                break;
        }


    }
}
