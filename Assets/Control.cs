using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StaticScript.select = 0;
        StaticScript.nowvector = 0;
        StaticScript.controlflag = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (StaticScript.controlflag == 1)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                StaticScript.select = -1;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                StaticScript.select = 1;
            }
        }
    }
}
