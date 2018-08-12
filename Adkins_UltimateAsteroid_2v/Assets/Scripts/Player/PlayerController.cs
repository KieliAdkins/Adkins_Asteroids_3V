using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Declaring our variables
    public static PlayerController pController; 
    public static PlayerPawn pawn; 
    public static Player starship; 

	// Use this for initialization
	void Start () {
        pController = this; 
	}
	
	// Update is called once per frame
	void Update () {

        // Calling the pawn move function
        starship.Move(); 
	}
}
