using UnityEngine;
using System.Collections;

public class Createwall : MonoBehaviour
{
    public Transform falsewall;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switch (StaticScript.nowvector-StaticScript.select)
            {
                case 0:
                case 4:
                    if (StaticScript.trueselect == -1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x + 50, 0, transform.position.z), Quaternion.Euler(0, 90, 0));
                    }
                    else if (StaticScript.trueselect == 1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x - 50, 0, transform.position.z), Quaternion.Euler(0, 90, 0));
                    }
                    break;
                case 1:
                    if (StaticScript.trueselect == -1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x, 0, transform.position.z - 50), Quaternion.Euler(0, 0, 0));
                    }
                    else if (StaticScript.trueselect == 1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x, 0, transform.position.z + 50), Quaternion.Euler(0, 0, 0));
                    }
                    break;
                case 2:
                    if (StaticScript.trueselect == -1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x - 50, 0, transform.position.z), Quaternion.Euler(0, 90, 0));
                    }
                    else if (StaticScript.trueselect == 1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x + 50, 0, transform.position.z), Quaternion.Euler(0, 90, 0));
                    }
                    break;
                case -1:
                case 3:
                    if (StaticScript.trueselect == -1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x, 0, transform.position.z + 50), Quaternion.Euler(0, 0, 0));
                    }
                    else if (StaticScript.trueselect == 1)
                    {
                        Instantiate(falsewall, new Vector3(this.transform.position.x, 0, transform.position.z - 50), Quaternion.Euler(0, 0, 0));
                    }
                    break;
            }



        }
    }

}
