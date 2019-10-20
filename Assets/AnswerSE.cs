using UnityEngine;
using System.Collections;

public class AnswerSE : MonoBehaviour {
    public AudioClip se1;
    public int num;
    public int i;
    // Use this for initialization
    void Start () {
         num = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (num < StaticScript.truenum)
        {
            this.GetComponent<AudioSource>().clip = se1;
            this.GetComponent<AudioSource>().Play();

        }
        num = StaticScript.truenum;
    }
}
