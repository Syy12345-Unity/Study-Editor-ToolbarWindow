using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolbarWindow : EditorWindow {
    [MenuItem("Tools/Toolbar")]
    public static void Open()
    {
        GetWindow<ToolbarWindow>();
    }

    void OnGUI()
    {
        var backgroundRect = new Rect(
            0,
            0,
            EditorGUIUtility.currentViewWidth,
            EditorGUIUtility.singleLineHeight
        );

        if(Event.current.type == EventType.Repaint)
        {
            EditorStyles.toolbar.Draw( backgroundRect,false,true,true,false);
        }

        using(new EditorGUILayout.HorizontalScope())
        {

            GUILayout.Label("Toolbar Name");
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Button 1", EditorStyles.toolbarButton))
            {

            }
            if (GUILayout.Button("Button 2", EditorStyles.toolbarButton))
            {

            }
        }
    }
}
