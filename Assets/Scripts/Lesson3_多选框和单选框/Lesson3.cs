using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    private bool isSel;
    private bool isSel2;
    public GUIStyle style;

    private int nowSelIndex = 1;
    private void OnGUI() {
        isSel = GUI.Toggle(new Rect(0, 0, 100, 50), isSel, "choice");
        isSel2 = GUI.Toggle(new Rect(0, 50, 100, 20), isSel2, "音效开关",style);

        if(GUI.Toggle(new Rect(0,100,100,50),nowSelIndex == 1, "选项一")){
            nowSelIndex = 1;
        }
        if (GUI.Toggle(new Rect(0, 160, 100, 50), nowSelIndex == 2, "选项二")){
            nowSelIndex = 2;
        }
        if (GUI.Toggle(new Rect(0, 210, 100, 50), nowSelIndex == 3, "选项三")){
            nowSelIndex = 3;
        }
    }
}
