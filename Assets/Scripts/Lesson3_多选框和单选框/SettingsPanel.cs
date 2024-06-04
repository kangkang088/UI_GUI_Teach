using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPanel : MonoBehaviour {
    public Rect toggleMusicPos;
    public Rect tpggleSongPos;
    private bool isSelMusic =true;
    private bool isSelSong = true;

    public Rect buttonPos;
    public GUIStyle style;

    private float musicValue = 1;
    public Rect musicPos;
    private float songValue = 1;
    public Rect songPos;

    public Rect backPos;
    public Texture backPic;

    private static SettingsPanel instance;
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
    private void Awake() {
        instance = this;
        HideMe();
    }
    private void OnGUI() {
        GUI.DrawTexture(backPos, backPic);

        isSelMusic = GUI.Toggle(toggleMusicPos, isSelMusic, "音乐开关");
        isSelSong = GUI.Toggle(tpggleSongPos, isSelSong, "音效开关");

        musicValue = GUI.HorizontalSlider(musicPos, musicValue, 0, 1);
        songValue = GUI.HorizontalSlider(songPos, songValue, 0, 1);

        if (GUI.Button(buttonPos, "", style)) {
            HideMe();
            Lesson2_Exercises.ShowMe();
        }
    }
}
