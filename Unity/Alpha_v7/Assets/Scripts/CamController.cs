using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamController : MonoBehaviour {

	float x;
    float y;
    Vector3 rotateValue;

	void Start () {
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			rotateValue = new Vector3(0, 90, 0);
			transform.eulerAngles = transform.eulerAngles + rotateValue;
			
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			rotateValue = new Vector3(0, 90, 0);
			transform.eulerAngles = transform.eulerAngles - rotateValue;
			
		}
	}

}
