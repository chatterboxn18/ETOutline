using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlineFile : ScriptableObject {
    public Section[] sections;

}
[System.Serializable]
public class Section
{
    public string title;
    public string[] content;
}