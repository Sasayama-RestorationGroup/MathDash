using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {
    float radius;
    public float yspeed;
	// Use this for initialization
	void Start () {
        radius = 0;

        //StaticScript.select = 0;
	}

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 InputDirection = new Vector3(x, 0, y); 
        if(InputDirection.magnitude > 0)
        {
            this.transform.position += InputDirection * yspeed * Time.deltaTime;
        }
        radius += Time.deltaTime * 50;
        Vector3 _tmp = this.transform.position;
        _tmp.y = Mathf.Sin(radius * Mathf.PI / 180) + 4;
        this.transform.position = _tmp;
    }
}
