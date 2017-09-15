using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlaetterController : MonoBehaviour {

    public ParticleSystem particleObject;

    void Start()
    {
        particleObject = GetComponent<ParticleSystem>();
        particleObject.Stop();
    }


    void Update()
    {
        if (StatischeVariable.pilzAnzahl == 3)
        {
            Debug.Log("Running");
            particleObject.Play();
        }
    }

}
