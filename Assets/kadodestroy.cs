using UnityEngine;
using System.Collections;

public class kadodestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StaticScript.controlflag = 1;
            StaticScript.numcreateflag = 1;
            Destroy(this.transform.root.gameObject);
        }
    }
}
