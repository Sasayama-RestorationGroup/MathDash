using UnityEngine;
using System.Collections;

public class ButtonSE : MonoBehaviour {
    public AudioClip se1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetAxis("Horizontal") == true || Input.GetAxis("Vertical") == true)
        {
            this.GetComponent<AudioSource>().clip = se1;
            this.GetComponent<AudioSource>().Play();
        }*/
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<AudioSource>().clip = se1;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
