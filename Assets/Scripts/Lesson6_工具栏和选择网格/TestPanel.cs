using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPanel : MonoBehaviour {
    public Rect toolbarPos;
    public Rect selectGridPos;
    public string[] strings = new string[] { "装备", "进阶", "幻化" };
    private int nowSelIndex = 0;
    public Rect rectLabelPos;
    private void OnGUI() {
        nowSelIndex = GUI.Toolbar(toolbarPos, nowSelIndex, strings);
        nowSelIndex = GUI.SelectionGrid(selectGridPos, nowSelIndex, strings,1);
        switch (nowSelIndex) {
            case 0:
                GUI.Label(rectLabelPos, "装备信息");
                break;
            case 1:
                GUI.Label(rectLabelPos, "进阶信息");
                break;
            case 2:
                GUI.Label(rectLabelPos, "幻化信息");
                break;
        }
    }
}
