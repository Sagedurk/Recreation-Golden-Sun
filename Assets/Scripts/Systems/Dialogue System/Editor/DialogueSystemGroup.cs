using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DialogueSystemGroup : Group
{
    public string oldTitle;
    private Color defaultBorderColor;
    private float defaultBorderWidth;

    public DialogueSystemGroup(string groupTitle, Vector2 position)
    {

        title = groupTitle;
        oldTitle = groupTitle;
        SetPosition(new Rect(position, Vector2.zero));

        defaultBorderColor = contentContainer.style.borderBottomColor.value;
        defaultBorderWidth = contentContainer.style.borderBottomWidth.value;
    }

    public void SetErrorStyle(Color color)
    {
        contentContainer.style.borderBottomColor = color;
        contentContainer.style.borderBottomWidth = 2.0f;
    }

    public void ResetStyle()
    {
        contentContainer.style.borderBottomColor = defaultBorderColor;
        contentContainer.style.borderBottomWidth = defaultBorderWidth;
    }



}
