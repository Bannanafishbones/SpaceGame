using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float rotacionPlaneta = 3f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0f, rotacionPlaneta, 0f) * Time.deltaTime);


	}
}
