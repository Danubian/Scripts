using UnityEngine;
using System.Collections;

public class FinnickyLight : MonoBehaviour {

    float intensity;
	// Use this for initialization
	void Start () {
        intensity = this.light.intensity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter () {
        this.light.intensity = 0;

        Invoke("TurnBack", Random.Range(5.0f, 20.0f));
	}

    void TurnBack()
    {
        this.light.intensity = intensity;
    }
}
