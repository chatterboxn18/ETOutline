using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class scriptedOutline : MonoBehaviour {

    [MenuItem("Assets/Create/outlineFile")]
    public static void CreateOutline()
    {
        outlineFile outline = ScriptableObject.CreateInstance<outlineFile>();
        AssetDatabase.CreateAsset(outline, "Assets/Resources/outlineFile.asset");
        AssetDatabase.SaveAssets();
    }

}
