using UnityEngine;
using System.Collections;

public class walldestroy : MonoBehaviour {

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
            Destroy(this.transform.root.gameObject);
        }
    }
}
