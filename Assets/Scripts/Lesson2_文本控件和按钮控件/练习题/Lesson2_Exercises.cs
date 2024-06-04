using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson2_Exercises : MonoBehaviour
{
    public Rect labelPos;
    public GUIContent labelContent;
    public GUIStyle labelStyle;
    public Rect btn1Pos;
    public Rect btn2Pos;
    public Rect btn3Pos;
    public GUIStyle btnStyle;

    public Rect backPos;
    public Texture backPic;

    private static Lesson2_Exercises instance;
    public static void ShowMe() {
        if(instance != null) {
            instance.gameObject.SetActive(true);
        }
    }
    public static void HideMe() {
        if (instance != null) {
            instance.gameObject.SetActive(false);
        }
    }
    private void Awake() {
        instance = this;
    }
    private void OnGUI() {
        GUI.DrawTexture(backPos, backPic);

        GUI.Label(labelPos, labelContent, labelStyle);
        if(GUI.Button(btn1Pos, "开始游戏", btnStyle)) {
            //SceneManager.LoadScene("GameScene");
            LoginPanel.ShowMe();
            HideMe();
        }
        if(GUI.Button(btn2Pos, "设置游戏", btnStyle)) {
            SettingsPanel.ShowMe();
            HideMe();
        }
        if(GUI.Button(btn3Pos, "退出游戏", btnStyle)) {
            ExitPanel.ShowMe();
            HideMe();
        }
    }
}
