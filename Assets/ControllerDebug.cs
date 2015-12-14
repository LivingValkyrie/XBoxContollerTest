using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: NewBehaviourScript 
/// </summary>
public class ControllerDebug : MonoBehaviour {
    #region Fields

    #endregion

    void Start() { }

    void Update() {
        print(Input.GetAxis("LeftJoystick_Horizontal"));
    }

}