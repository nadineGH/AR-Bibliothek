using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeSpriteOnClick : MonoBehaviour
{

    /*bool mute = true;

   //GameObject.Find("SoundOff").GetComponent<Sprite();
    public Sprite soundOn;
    public Sprite soundOff;
    public Button soundMute;
public SpriteRenderer rend;

    void Start()
{
    Button btn = soundMute.GetComponent<Button> ();
    btn.onClick.AddListener (TaskOnClick);
}

    public void TaskOnClick()
    {
        if(mute)
        {
        this.GetComponent<SpriteRenderer> ().sprite = soundOff; 
        //soundMute.GameObject.Find ("SoundOff").GetComponent<Sprite> ();
        }
        else
        {
        //soundMute.GameObject.Find("SoundOn").GetComponent<Sprite>();
        this.GetComponent<SpriteRenderer> ().sprite = soundOn;
        }
    } */


    
        SpriteRenderer renderer;

        void Start()
        {
            renderer = gameObject.GetComponent<SpriteRenderer> ();
        }

        public void change(Sprite difSprite)
        {
            renderer.sprite = difSprite;
        }
    }
    

/*
    public Sprite[] s1;
    public Button bl;

    int count = 0;

    private void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("Sprites");
    }

    public void On_Click_Button()
    {
        count++;
        if (count == s1.Length)
        {
            count = 0;

        }
        bl.image.sprite = s1[count];
    }
}

*/

