using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoRanking : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StaticScript.rankingflag = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush()
    {
        SceneManager.LoadScene("Ranking", LoadSceneMode.Additive);
        SceneManager.UnloadScene("title");
        StaticScript.rankingflag = 1;
    }
}
