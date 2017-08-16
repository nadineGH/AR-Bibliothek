using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Button weiterButton;
	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;
	
	void Start () {

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }
	
	// Update is called once per frame
	void Update () {

        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }
    }

    public void Weiter()
    {
        theText.text = textLines[currentLine];
        currentLine += 1;
        if (currentLine == 10)
        {
            textBox.SetActive(false);
            weiterButton.gameObject.SetActive(false);

        }
    }

}

