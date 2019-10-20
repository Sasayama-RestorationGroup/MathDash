using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class titleBGMScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("title", LoadSceneMode.Additive);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
