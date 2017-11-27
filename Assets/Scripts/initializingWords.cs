using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializingWords : MonoBehaviour {

    public string selectionName;
    //public string gameType;
    public outlineFile EToutline;

    private float panelWidth;
    private float panelHeight;

    private void Awake()
    {
        Rect panelSize = GetComponent<Rect>();
        panelHeight = panelSize.height;
        panelWidth = panelSize.width;
    }

    // Initialize the game board
    void Start () {
        string[] words;
        //char[] splitters = { ' ' };
        words = EToutline.sections[0].content[0].Split(' ');
        int _length = words.Length - 1;
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
