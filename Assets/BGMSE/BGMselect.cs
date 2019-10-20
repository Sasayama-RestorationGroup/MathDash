using UnityEngine;
using System.Collections;

public class BGMselect : MonoBehaviour {
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;

	// Use this for initialization
	void Start () {
    /*    AudioClip[] audioclip = GetComponents<AudioClip>();
        music1 = audioclip[0];
        music2 = audioclip[1];
        music3 = audioclip[2];*/
        int musicselect;
        musicselect = Random.Range(1, 4);
        switch (musicselect)
        {
            case 1:
                this.GetComponent<AudioSource>().clip = music1;
                break;
            case 2:
                this.GetComponent<AudioSource>().clip = music2;
                break;
            case 3:
                this.GetComponent<AudioSource>().clip = music3;
                break;


        }
        this.GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
