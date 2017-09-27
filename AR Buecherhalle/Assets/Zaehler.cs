using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zaehler : MonoBehaviour
{
    public Text anzahlText;
    public GameObject pilz;
    public GameObject pilz2;
    public GameObject pilz3;
    public GameObject euleMitUmhang;
    public GameObject euleOhneUmhang;
    public GameObject korb;
    public Animator popUpText;
    //public Animation popUp;

    public AudioClip clip;
    public AudioClip mysound;
    public AudioClip anzahlErreicht;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        // audioSource.PlayOneShot(mysound, 0.5f);
        //audioSource.loop = true;
    }

    public void UpdateAnzahl()
    {
        if (pilz.activeInHierarchy == false | pilz2.activeInHierarchy == false | pilz3.activeInHierarchy == false)
        {
            audioSource.PlayOneShot(clip, 0.9f);
            StatischeVariable.pilzAnzahl++;
            anzahlText.text = "Pilze: " + StatischeVariable.pilzAnzahl;
            Debug.Log(StatischeVariable.pilzAnzahl + "Pilze");
            popUpText.GetComponent<Animator>().Play("PopUpTextAnimation");
        }

        if (StatischeVariable.pilzAnzahl == 3)
        {
            audioSource.PlayOneShot(anzahlErreicht, 1.0f);
            euleOhneUmhang.SetActive(false);
            StartCoroutine(Warten());
            
        }
    }

    IEnumerator Warten()
    {
        yield return new WaitForSeconds(1);
        euleMitUmhang.SetActive(true);
        korb.SetActive(true);
        yield break;
    }
}