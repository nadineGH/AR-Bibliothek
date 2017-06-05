using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour {
    public Animator pilzAnim;
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
        pilzAnim.Play("Windig");
    }
}
