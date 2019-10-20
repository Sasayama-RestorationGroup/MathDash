using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush()
    {
        SceneManager.LoadScene("title", LoadSceneMode.Additive);
        SceneManager.UnloadScene("gamecomplain");
        SceneManager.UnloadScene("Ranking");
        StaticScript.rankingflag = 0;

    }
}
