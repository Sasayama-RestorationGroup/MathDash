using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Gameover : MonoBehaviour {

    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
