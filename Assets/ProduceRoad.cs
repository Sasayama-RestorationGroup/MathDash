using UnityEngine;
using System.Collections;

public class ProduceRoad : MonoBehaviour
{
    public Transform kado;
    public Transform Rouka;
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
            //        Instantiate(kado, new Vector3(this.transform.position.x, 0, this.transform.position.z), Quaternion.Euler(0, 0, 0));
            switch (StaticScript.select + StaticScript.nowvector)
            {
                case 0:
                case 4:
                    Instantiate(kado, new Vector3(this.transform.position.x, 0, transform.position.z + 90), Quaternion.Euler(0, 0, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 30, 0, transform.position.z + 90), Quaternion.Euler(0, 90, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 30, 0, transform.position.z + 90), Quaternion.Euler(0, 270, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 60, 0, transform.position.z + 90), Quaternion.Euler(0, 90, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 60, 0, transform.position.z + 90), Quaternion.Euler(0, 270, 0));
                    break;
                case 1:
                    Instantiate(kado, new Vector3(this.transform.position.x + 90, 0, this.transform.position.z), Quaternion.Euler(0, 90, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 90, 0, this.transform.position.z - 30), Quaternion.Euler(0, 180, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 90, 0, this.transform.position.z + 30), Quaternion.Euler(0, 0, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 90, 0, this.transform.position.z - 60), Quaternion.Euler(0, 180, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 90, 0, this.transform.position.z + 60), Quaternion.Euler(0, 0, 0));
                    break;
                case 2:
                    Instantiate(kado, new Vector3(this.transform.position.x, 0, this.transform.position.z - 90), Quaternion.Euler(0, 180, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 30, 0, this.transform.position.z - 90), Quaternion.Euler(0, 270, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 30, 0, this.transform.position.z - 90), Quaternion.Euler(0, 90, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 60, 0, this.transform.position.z - 90), Quaternion.Euler(0, 270, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x + 60, 0, this.transform.position.z - 90), Quaternion.Euler(0, 90, 0));
                    break;
                case -1:
                case 3:
                    Instantiate(kado, new Vector3(this.transform.position.x - 90, 0, this.transform.position.z), Quaternion.Euler(0, 270, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 90, 0, this.transform.position.z + 30), Quaternion.Euler(0, 0, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 90, 0, this.transform.position.z - 30), Quaternion.Euler(0, 180, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 90, 0, this.transform.position.z + 60), Quaternion.Euler(0, 0, 0));
                    Instantiate(Rouka, new Vector3(this.transform.position.x - 90, 0, this.transform.position.z - 60), Quaternion.Euler(0, 180, 0));
                    break;
            }
            if (StaticScript.select == 1)
            {
                StaticScript.nowvector++;
                if (StaticScript.nowvector == 4)
                {
                    StaticScript.nowvector = 0;
                }
            }
            else if (StaticScript.select == -1)
            {
                StaticScript.nowvector--;
                if (StaticScript.nowvector == -1)
                {
                    StaticScript.nowvector = 3;
                }
            }
            StaticScript.controlflag = 0;
        }
    }
}
