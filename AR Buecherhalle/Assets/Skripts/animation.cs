using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {
    public Animator eule;
    int num = 1;
    // Use this for initialization
    void Start () {

        eule = GetComponent<Animator>();
	}

    public void BewegungA()
    {
        
       eule.Play("Armature|Nicken");
        
    }
    public void BewegungB()
    {
       eule.Play("Armature|KoerperDrehen");
    }
    public void BewegungC()
    {
        eule.Play("Armature|kopfDrehenR");
    }
    public void BewegungD()
    {
        eule.Play("Armature|kopfDrehenL 1");
    }
    public void BewegungE()
    {
        eule.Play("Armature|KopfLinksSchief");
    }
    public void BewegungF()
    {
        eule.Play("Armature|KopfRechtsSchief");
    }
    /*if (num == 2)
    {
        eule.Play("Armature|Nicken");
        num ++;
    }
    if (num == 3)
    {
        eule.Play("Armature|kopfDrehenL 1");
    }
    */

    //eule.Play("Armature|KopfRechtsSchief");
    //StartCoroutine(MyMethod());
    //eule.Play("Armature|KopfLinksSchief");
    //StartCoroutine(MyMethod());

    // StartCoroutine(MyMethod());
    //eule.Play("Armature|kopfDrehenL 1");
    //StartCoroutine(MyMethod());
    // eule.Play("Armature|kopfDrehenR");
    //StartCoroutine(MyMethod());
    //eule.Play("Armature|KoerperDrehen");

}

    /*IEnumerator MyMethod()
    {

        yield return new WaitForSeconds(1);

    }*/

