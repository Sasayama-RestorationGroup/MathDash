using UnityEngine;
using System.Collections;

public class ButtonPushSE : MonoBehaviour {
    public AudioClip se1;
    // Use this for initialization
    public void ButtonPush()
    {
        this.GetComponent<AudioSource>().clip = se1;
        this.GetComponent<AudioSource>().Play();
    }
    
	
	// Update is called once per frame
	void Update () {
	
	}
}
