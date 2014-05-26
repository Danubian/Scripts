using UnityEngine;
using System.Collections;

public class GUIController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 30), "Here");
    }
}