﻿using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
	public GameObject TeleportTo;
    public Material NewSkybox;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter (Collider other) {
        Vector3 displacement = other.transform.position - this.transform.position;

		other.transform.position = TeleportTo.transform.position;
		other.transform.position += displacement;

        RenderSettings.skybox = NewSkybox;
	}
}
