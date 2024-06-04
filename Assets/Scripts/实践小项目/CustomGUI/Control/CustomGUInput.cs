﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomGUInput : CustomGUIControl {
    public event UnityAction<string> textChange;
    private string oldString = "";
    protected override void StyleOffDraw() {
        content.text = GUI.TextField(guiPos.Pos, content.text);
        if (oldString != content.text) {
            textChange?.Invoke(oldString);
            oldString = content.text;
        }
    }

    protected override void StyleOnDraw() {
        content.text = GUI.TextField(guiPos.Pos, content.text,style);
        if (oldString != content.text) {
            textChange?.Invoke(oldString);
            oldString = content.text;
        }
    }
}
