using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initializingWords : MonoBehaviour {

    public string selectionName;
    //public string gameType;
    public outlineFile EToutline;
    public RectTransform panelSize;
    public GameObject textSample;

    private float panelWidth;
    private float panelHeight;

    private string symbols;

    private void Awake()
    {
        panelSize = this.GetComponent<RectTransform>();
        panelHeight = panelSize.rect.height;
        panelWidth = panelSize.rect.width;
        symbols = ".',";
    }

    // Initialize the game board
    void Start () {
        string[] words;
        //char[] splitters = { ' ' };
        for (int j = 0; j < EToutline.sections[0].content.Length; j++)
        {
            words = EToutline.sections[0].content[j].Split(' ');
            string oneLine = " ";
            for (int i = 1; i < words.Length; i++)
            {
                //code
                Debug.Log("The word is " + words[i]);
                oneLine += " " + CreateWord(words[i]);
                //textObject.GetComponent<Text>().text = CreateWord(words[i]);
                //textObject.transform.position = new Vector3(0, panelHeight / words.Length * 30, 0);
                //CreateWord(words[i]);
            }
            GameObject textObject = GameObject.Instantiate(textSample, transform, false);
            textObject.GetComponent<Text>().text = words[0] + oneLine;
            textObject.transform.position = new Vector3(0, -40 * j,0);
        }
		
	}

    public string CreateWord(string word)
    {
        string finishedWord = "";
        for (int i = 0; i < word.Length; i++){
            if (symbols.Contains(word[i].ToString()))
                finishedWord += word[i].ToString();
            else
                finishedWord += "_";
        }     
        Debug.Log(finishedWord);
        return finishedWord;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
