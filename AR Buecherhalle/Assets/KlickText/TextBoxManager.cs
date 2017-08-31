using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Button weiterButton;
    public Button jaButton;
    public Button neinButton;
    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public GameObject demoPilz;
    public GameObject pilz;

    void Start()
    {

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
    void Update()
    {

        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        // Ein Pilz wurde gesammelt -> Glückwunsch Text
        if (StatischeVariable.pilzAnzahl == 1)
        {
            StatischeVariable.pilzAnzahl++;
            textBox.SetActive(true);
            currentLine = 16;
            StartCoroutine(MyMethod());
        }
    }

    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(5);
        textBox.SetActive(false);
        yield break;
    }

    public void Weiter()
    {
        weiterButton.gameObject.SetActive(true);
        theText.text = textLines[currentLine];
        currentLine += 1;
        //Demo Pilz verschwinden lassen
        /* if (currentLine == 4)
         {
             demoPilz.SetActive(false);
             pilz.SetActive(true);
             textBox.SetActive(false);
             weiterButton.gameObject.SetActive(false);
         }*/
        if (currentLine == 11)
        {
            jaButton.gameObject.SetActive(true);
            neinButton.gameObject.SetActive(true);
            //textBox.SetActive(false);
            weiterButton.gameObject.SetActive(false);

        }
        if (currentLine == 15)
        {
            demoPilz.SetActive(false);
            pilz.SetActive(true);
            textBox.SetActive(false);
            weiterButton.gameObject.SetActive(false);
        }

    }
    public void Ja()
    {
        neinButton.gameObject.SetActive(false);
        theText.text = textLines[currentLine];
        currentLine += 1;
        Weiter();
        

    }
}