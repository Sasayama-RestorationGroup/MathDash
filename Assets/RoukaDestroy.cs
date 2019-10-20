using UnityEngine;
using System.Collections;

public class RoukaDestroy : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.transform.root.gameObject);
        }
    }
}
