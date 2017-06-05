using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {
    public Animator pilzAnim;
    // Use this for initialization
    void Start () {

        pilzAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("q"))
        {
            pilzAnim.Play("Windig");
        }

        if (Input.GetKeyDown("w"))
        {
            pilzAnim.Play("ArmatureAction");
        }
    }
}
