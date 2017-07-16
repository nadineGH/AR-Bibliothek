using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	[SerializeField]
	private Text text = null;


	// Use this for initialization
	void Start () {
		text.text = "Hallo Mensch";
	}

}
