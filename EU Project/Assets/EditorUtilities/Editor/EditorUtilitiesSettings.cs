using UnityEngine;
using System.Collections.Generic;

public class EditorUtilitiesSettings : ScriptableObject
{
    public bool showEditorState = true;
    public bool showSceneShortcuts = true;
    public List<string> launchSceneShortcuts = new List<string>();
    public List<string> workingSceneShortcuts = new List<string>();
}