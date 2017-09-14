using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrettBrechen : MonoBehaviour {

    public float health;
    public GameObject destroyed_obj;

	
	// Update is called once per frame
	public void Brechen () {
        // if (Input.GetKeyDown("h"))
         {
        Debug.Log("Brett zerbricht");
            Destroy(destroyed_obj);// this.transform.SendMessageUpwards("GetBulledDamage", 20, SendMessageOptions.DontRequireReceiver);
        }
		
	}
    /* void GetBulledDamage (float damage)
    {
        health -= damage;

        if(health <=  0)
        { GameObject destroy_obj = Instantiate(destroyed_obj, this.transform.position, this.transform.rotation) as GameObject;
            Destroy(gameObject);

        }
    }*/
}
