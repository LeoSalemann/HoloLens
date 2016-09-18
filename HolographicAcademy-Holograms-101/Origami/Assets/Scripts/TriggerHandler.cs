using UnityEngine;
using System.Collections;

public class TriggerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActiveRecursively(true);
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActiveRecursively(false); ;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
