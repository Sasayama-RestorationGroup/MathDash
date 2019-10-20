using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quiz : MonoBehaviour {
    int num1;
    int num2;
    int sisoku;
    int trueanswer;
    int falseanswer;
    int falseanswerjadge;
    int sisoku2;
    public GameObject Question;
    public GameObject Lanswer;
    public GameObject Ranswer;
    public GameObject Answernum;
	// Use this for initialization
	void Start () {
        StaticScript.numcreateflag = 1;
        falseanswer = 0;
    }

    // Update is called once per frame
    void Update() {

        if (StaticScript.vanishwordflag == 1)
        {
            Question.GetComponent<Text>().text = "";
            Lanswer.GetComponent<Text>().text = "";
            Ranswer.GetComponent<Text>().text = "";
        }
        else {
            if (StaticScript.controlflag == 1)
            {
                if (StaticScript.numcreateflag == 1)
                {
                    sisoku = Random.Range(0, 4);//+-*/0123
                    switch (sisoku)
                    {
                        case 0:
                            num1 = Random.Range(0, 9);
                            num2 = Random.Range(0, 9);
                            trueanswer = num1 + num2;
                            Question.GetComponent<Text>().text = "" + num1 + " + " + num2 + " =";
                            break;
                        case 1:
                            num2 = Random.Range(0, 9);
                            trueanswer = Random.Range(0, 9);
                            num1 = num2 + trueanswer;
                            Question.GetComponent<Text>().text = "" + num1 + " - " + num2 + " =";
                            break;
                        case 2:
                            num1 = Random.Range(0, 9);
                            num2 = Random.Range(0, 9);
                            trueanswer = num1 * num2;
                            Question.GetComponent<Text>().text = "" + num1 + " × " + num2 + " =";
                            break;
                        case 3:
                            num2 = Random.Range(1, 9);
                            trueanswer = Random.Range(0, 9);
                            num1 = num2 * trueanswer;
                            Question.GetComponent<Text>().text = "" + num1 + " ÷ " + num2 + " =";
                            break;
                    }



                    do
                    {
                        falseanswerjadge = Random.Range(1, 5);
                        switch (falseanswerjadge)
                        {
                            case 1:
                                //falseanswer をランダムでずらす
                                falseanswer = trueanswer + Random.Range(-3, -1);
                                break;
                            case 2:
                                falseanswer = trueanswer + Random.Range(1, 3);
                                break;
                            case 3:
                                //演算の種類を変える
                                sisoku2 = Random.Range(0, 3);
                                if (sisoku2 == sisoku)
                                {
                                    sisoku2++;
                                    if (sisoku2 == 4)
                                    {
                                        sisoku2 = 0;
                                    }
                                }
                                switch (sisoku2)
                                {
                                    case 0:
                                        falseanswer = num1 + num2;
                                        break;
                                    case 1:
                                        falseanswer = num1 - num2;
                                        break;
                                    case 2:
                                        falseanswer = num1 * num2;
                                        break;
                                    case 3:
                                        falseanswer = num1 / num2;
                                        break;
                                }
                                break;
                            case 4:
                                //完璧にランダム
                                falseanswer = Random.Range(1, 20);
                                break;
                                //その他


                                //
                        }
                    } while (falseanswer == trueanswer);
                    StaticScript.trueselect = Random.Range(-1, 1);
                    if (StaticScript.trueselect == 0)
                    {
                        StaticScript.trueselect = 1;
                    }
                    if (StaticScript.trueselect == -1)
                    {
                        Lanswer.GetComponent<Text>().text = "" + trueanswer;
                        Ranswer.GetComponent<Text>().text = "" + falseanswer;
                    }
                    else if (StaticScript.trueselect == 1)
                    {
                        Ranswer.GetComponent<Text>().text = "" + trueanswer;
                        Lanswer.GetComponent<Text>().text = "" + falseanswer;
                    }


                    StaticScript.numcreateflag = 0;
                }
            }
        }
        Answernum.GetComponent<Text>().text = "" + StaticScript.truenum;
    }
}
