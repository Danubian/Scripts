using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
    float playerHeight;
	// Use this for initialization
	void Start () {
        playerHeight = 1.32f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other) {
        print(gameObject.name);
        Vector3 displacement = other.transform.position - this.transform.position;
        if(gameObject.name.Equals("Teleporter_A")){
            other.transform.position = GameObject.Find("End_A").transform.position;
            other.transform.position += displacement;
        }
        else if (gameObject.name.Equals("Teleporter_B"))
        {
            other.transform.position = GameObject.Find("End_B").transform.position;
            other.transform.position += displacement;
        }
	}
}
