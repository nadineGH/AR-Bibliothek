using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zaehler : MonoBehaviour
{
    //[SerializeField]
    public Text anzahlText;
    public GameObject pilz;
    public GameObject pilz2;
    // Use this for initialization
    /*void Start () {
        anzahl = 0;
        UpdateAnzahl();
	}*/

    // Update is called once per frame
   public void UpdateAnzahl()
    {
        if (pilz.activeInHierarchy == false | pilz2.activeInHierarchy == false)
        {
            
            StatischeVariable.pilzAnzahl++;
            anzahlText.text = "Pilze: " + StatischeVariable.pilzAnzahl;
            Debug.Log(StatischeVariable.pilzAnzahl + "Pilze");
        }
    }
}