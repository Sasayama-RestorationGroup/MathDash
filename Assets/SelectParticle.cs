using UnityEngine;
using System.Collections;

public class SelectParticle : MonoBehaviour {
    public GameObject Lselect;
    public GameObject Rselect;

	// Use this for initialization
	void Start () {
        Lselect.SetActive(false);
        Rselect.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if(StaticScript.select == 0)
        {
            Lselect.SetActive(false);
            Rselect.SetActive(false);
        }
        if(StaticScript.select == -1)
        {
            Lselect.SetActive(true);
            Rselect.SetActive(false);
        }
	    if(StaticScript.select == 1)
        {
            Lselect.SetActive(false);
            Rselect.SetActive(true);
        }
	}
}
