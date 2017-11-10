﻿using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {

	public float timeOut = 1.0f;
	public bool detachChildren = false;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Awake () {
		// invote the DestroyNow funtion to run after timeOut seconds
		Invoke ("DestroyNow", timeOut);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void DestroyNow ()
	{
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
        if (detachChildren) { // detach the children before destroying if specified
			transform.DetachChildren ();
		}
		DestroyObject (gameObject);
	}
}
