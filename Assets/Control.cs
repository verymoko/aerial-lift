using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    int Force = 1000;
    Rigidbody Cabin; // Поле — частный случай члена класса
    
    // Start is called before the first frame update
    public void OnClick()
    {
        Cabin = GetComponent <Rigidbody>(); // Взяли первый попавшийся риджид
        Cabin.AddForce (new Vector3(Force,0,0), ForceMode.Impulse); // Сила (направлена по иксу с величиной 1000, действует кратковременно с учётом массы (https://docs.unity3d.com/ScriptReference/ForceMode.html))
        Force *= -1;
    }
}
