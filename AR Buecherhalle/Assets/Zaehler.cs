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
    public Animator popUpText;
    //public Animation popUp;
    
   public void UpdateAnzahl()
    {
        if (pilz.activeInHierarchy == false | pilz2.activeInHierarchy == false)
        {
            
            StatischeVariable.pilzAnzahl++;
            anzahlText.text = "Pilze: " + StatischeVariable.pilzAnzahl;
            Debug.Log(StatischeVariable.pilzAnzahl + "Pilze");
            popUpText.GetComponent<Animator>().Play("PopUpTextAnimation");
                
        }
    }
}