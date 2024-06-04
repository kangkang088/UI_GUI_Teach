using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    private string inputString = "";
    private string inputPassword = "";

    private float nowValue = 0.5f;
    private void OnGUI() {
        inputString = GUI.TextField(new Rect(0, 0, 100, 30), inputString);
        inputPassword = GUI.PasswordField(new Rect(0, 100, 100, 60), inputPassword,'*');

        nowValue = GUI.HorizontalSlider(new Rect(0, 170, 100, 50), nowValue, 0.0f, 1.0f);
        Debug.Log(nowValue);
        nowValue = GUI.VerticalSlider(new Rect(100, 300, 100, 50), nowValue, 0, 1);
    }
}
