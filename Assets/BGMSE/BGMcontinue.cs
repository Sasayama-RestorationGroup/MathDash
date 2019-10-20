using UnityEngine;
using System.Collections;


public class BGMcontinue : MonoBehaviour {
    public GameObject target;

    void Start()
    {
        GameObject obj = GameObject.Find("target");
        if (obj != null)
        {
            Destroy(this.gameObject);
        }
    }
    void Awake()
    { 
        DontDestroyOnLoad(this.gameObject);
    }
}
