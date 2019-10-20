using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {
    float t = 0.0f;
    Vector3 startangle;
    int jadge = 1;
    int select;

	// Use this for initialization
	void Start () {
        StaticScript.changevector = 90;
        StaticScript.changeflag = 0;
        StaticScript.vanishwordflag = 0;
        StaticScript.truenum = 0;
    }

    // Update is called once per frame
    void Update () {
        if (StaticScript.changeflag == 1)
        {
            if(jadge == 1)
            {
                startangle = this.transform.eulerAngles;
                select = StaticScript.select;
                if(StaticScript.trueselect != StaticScript.select)
                    //正解と違う選択をしていたら文字が消えるフラグを建てる
                {
                    StaticScript.vanishwordflag = 1;
                }
                else
                {
                    StaticScript.truenum++;
                }
            }
            jadge = 0;

            if (select == 1)
            {
                if (t <= 1)
                {
                    t += Time.deltaTime *(1 + StaticScript.speedrate * 0.05f);
                    this.transform.eulerAngles = Vector3.Lerp(startangle, new Vector3(0, startangle.y + StaticScript.changevector, 0), t);
                }
                else
                {
                    t = 0.0f;
                    StaticScript.select = 0;
                    StaticScript.changeflag = 0;
                    jadge = 1;
                    this.transform.eulerAngles = new Vector3(0, startangle.y + StaticScript.changevector, 0);
                }
            }
            else if (select == -1)
            {
                if (t <= 1)
                {
                    t += Time.deltaTime;
                    this.transform.eulerAngles = Vector3.Lerp(startangle, new Vector3(0, startangle.y - StaticScript.changevector, 0), t);
                }
                else
                {
                    t = 0.0f;
                    StaticScript.select = 0;
                    StaticScript.changeflag = 0;
                    jadge = 1;
                    this.transform.eulerAngles = new Vector3(0, startangle.y - StaticScript.changevector, 0);
                }
            }
        }
    }
}
