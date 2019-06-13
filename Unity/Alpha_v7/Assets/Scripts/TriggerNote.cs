using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNote : MonoBehaviour {

	bool handTrigger;
	GameObject hand;

	// Use this for initialization
	void Start () {
		handTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
    	handTrigger = true;
    	Debug.Log("NOTE");
	}
}
