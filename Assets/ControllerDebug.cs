using UnityEngine;
using UnityEngine.UI;
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

    //22 images in total
    public Image aButton, bButton, xButton, yButton;
    public Image startButton, backButton;
    public Image rightBumper, leftBumper, rightTrigger, leftTrigger;
    public Image lsUp, lsDown, lsRight, lsLeft;
    public Image rsUp, rsDown, rsRight, rsLeft;
    public Image dpadUp, dpadDown, dpadRight, dpadLeft;

    #endregion

    void Start() { }

    void Update() {
        aButton.color = (Input.GetButton("Button_A")) ? Color.red : Color.white;
        bButton.color = ( Input.GetButton( "Button_B" ) ) ? Color.red : Color.white;
        xButton.color = ( Input.GetButton( "Button_X" ) ) ? Color.red : Color.white;
        yButton.color = ( Input.GetButton( "Button_Y" ) ) ? Color.red : Color.white;
        startButton.color = ( Input.GetButton( "Button_Start" ) ) ? Color.red : Color.white;
        backButton.color = ( Input.GetButton( "Button_Back" ) ) ? Color.red : Color.white;
        rightBumper.color = ( Input.GetButton( "Bumper_Right" ) ) ? Color.red : Color.white;
        leftBumper.color = ( Input.GetButton( "Bumper_Left" ) ) ? Color.red : Color.white;
    }

    Color CalculateColor(float input) {
        

        return Color.black;
    }

}