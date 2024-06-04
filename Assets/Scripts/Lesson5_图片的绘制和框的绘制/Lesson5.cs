using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour {
    public Rect rec;
    public Texture texture;
    public ScaleMode mode = ScaleMode.StretchToFill;
    public bool alpha;
    public float wh = 0;
    private void OnGUI() {
        //GUI.DrawTexture(rec, texture,mode,alpha,wh);
        GUI.Box(rec, "123");
    }
}
