using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EuleAnimationen : MonoBehaviour {

    public Animator eule;

    // Use this for initialization
    void Start()
    {

        eule = GetComponent<Animator>();
    }

    
    void Bewegung()
    {
       
       // eule.Play("Armature|KopfRechtsSchief");
        /*StartCoroutine(MyMethod());
        eule.Play("Armature|KopfLinksSchief");
        StartCoroutine(MyMethod());
        eule.Play("Armature|Nicken");
        StartCoroutine(MyMethod());
        eule.Play("Armature|kopfDrehenL");
        StartCoroutine(MyMethod());
        eule.Play("Armature|kopfDrehenR");
        StartCoroutine(MyMethod());
        eule.Play("Armature|KoerperDrehen");*/
        
    }

    IEnumerator MyMethod()
    {
        
        yield return new WaitForSeconds(2);
        
    }
}