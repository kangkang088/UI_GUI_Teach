using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginPanel : MonoBehaviour {
    private static LoginPanel instance;
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

    public Rect btn1Pos;
    public Rect btn2Pos;

    public Rect label1Pos;
    public Rect label2Pos;

    public Rect input1Pos;
    public Rect input2Pos;
    private string userName = "";
    private string password = "";

    public Rect backPos;
    public Texture backPic;

    private void OnGUI() {
        GUI.DrawTexture(backPos, backPic);

        if (GUI.Button(btn1Pos, "登录游戏")) {
            if (userName == "admin" && password == "8888") {
                SceneManager.LoadScene("GameScene");
            } else {
                Debug.Log("用户名或密码错误");
            }
        }
        if (GUI.Button(btn2Pos, "返回")) {
            Lesson2_Exercises.ShowMe();
            HideMe();
        }

        GUI.Label(label1Pos, "用户名");
        GUI.Label(label2Pos, "密码");

        userName = GUI.TextField(input1Pos, userName);
        password = GUI.PasswordField(input2Pos, password,'*');
        
    }
}
