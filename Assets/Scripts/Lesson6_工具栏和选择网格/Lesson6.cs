using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    private int toolbarIndex = 0;
    private string[] toolbarInfos = new string[] { "选项一", "选项二", "选项三" };

    private int selectGridIndex = 0;
    private void OnGUI() {
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 200, 30), toolbarIndex, toolbarInfos); 
        
        //多了一个水平方向最多显示按钮数量的参数
        selectGridIndex = GUI.SelectionGrid(new Rect(0, 50, 200, 60), selectGridIndex, toolbarInfos,3);
    }
}
