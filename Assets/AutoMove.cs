using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour
{
    public float speed;
    Vector3 dire = Vector3.forward;
    float radius;
    public float yspeed;

    // Use this for initialization
    void Start()
    {
        StaticScript.speedrate = 0;
        radius = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (speed <= 80.0f)
        {
            StaticScript.speedrate = StaticScript.truenum / 3;
            speed = 20.0f + StaticScript.speedrate * 3;
        }
        this.transform.position += dire * speed * Time.deltaTime;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "magare")
        {
            if (StaticScript.nowvector == 0)
            {
                dire = Vector3.forward;
            }
            else if (StaticScript.nowvector == 1)
            {
                dire = Vector3.right;
            }
            else if (StaticScript.nowvector == 2)
            {
                dire = Vector3.back;
            }
            else if (StaticScript.nowvector == 3)
            {
                dire = Vector3.left;
            }
            StaticScript.changeflag = 1;
        }
    }

 /*   void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 300, 120), "control:" + StaticScript.controlflag);
        GUI.Label(new Rect(0, 30, 300, 30), "changeF:" + StaticScript.changeflag);
        GUI.Label(new Rect(0, 60, 300, 30), "changeV:" + StaticScript.changevector);
        GUI.Label(new Rect(0, 90, 300, 30), "select:" + StaticScript.select);
        //GUI.Label(new Rect(0, 120, 200, 30), "" + StaticScript.controlflag);

    }*/
}

/*
    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "magare")
        {
            if (StaticScript.nowvector == 0)
            {
                 this.transform.LookAt(this.transform.position + Vector3.forward);
            }
            else if (StaticScript.nowvector == 1)
            {
                this.transform.LookAt(this.transform.position + Vector3.right);
            }
            else if (StaticScript.nowvector == 2)
            {
                this.transform.LookAt(this.transform.position + Vector3.back);
            }
            else if (StaticScript.nowvector == 3)
            {
                this.transform.LookAt(this.transform.position + Vector3.left);
            }
            StaticScript.changeflag = 1;
        }
    }

    */