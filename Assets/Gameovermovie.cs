using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gameovermovie : MonoBehaviour {
    public float speed;
    public float meido;

    public GameObject gotitle;
    public GameObject gogame;
    public GameObject rankingname;
    public GameObject text1;
    public GameObject text2;
    // Use this for initialization
    void Start () {
        meido = -100;
        gotitle.SetActive(false);
        gogame.SetActive(false);
        rankingname.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        StaticScript.rankinginputnameflag = 1;
    }

    // Update is called once per frame
    void Update()
    {
            if (meido < 200)
            {
                meido += Time.deltaTime * speed;
            }
            if (meido >= 0)
            {
                Color _tmp = this.GetComponent<Text>().color;
                _tmp.a = meido / 255.0f;
                this.GetComponent<Text>().color = _tmp;
            }
        if (meido >= 200)
        {
            gotitle.SetActive(true);
            gogame.SetActive(true);
            if (StaticScript.rankinginputnameflag == 1)
            {
                rankingname.SetActive(true);
                text1.SetActive(true);
                text2.SetActive(true);
            }
            else
            {
                rankingname.SetActive(false);
                text1.SetActive(false);
                text2.SetActive(false);
            }
        }
    }
   /* void AppearButton()
    {
        gotitle.SetActive(true);
        gogame.SetActive(true);
        rankingname.SetActive(false);
    }*/
}


