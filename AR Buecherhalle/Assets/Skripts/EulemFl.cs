using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulemFl : MonoBehaviour {

    public Animator eule;
    
    void Start () {

        eule = GetComponent<Animator>();
        //StartCoroutine(MyMethod());
        //eule.Play("Armature|Flügel");
        //StartCoroutine(MyMethod());
        //eule.Play("Armature|Nicken");

    }

    void Update ()
    {
        if (Input.GetKeyDown("1"))
        {

            eule.Play("Armature|Nicken");

        }
    }
    IEnumerator MyMethod()
    {

       yield return new WaitForSeconds(1);


    }

    
}
