﻿// Company: The Puzzlers
// Copyright (c) 2018 All Rights Reserved
// Author: Leonel Jara
// Date: 04/13/2018
/* Summary: 
 * Debugging use only for testing a puzzle base code
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTemplate: Puzzle {

	// Sets the parent fields
	void Awake () {
		puzzleName = "PuzzleTemplate";
		difficulty = NextSceneManager.instance.setPuzzledifficulty;
		placeholder = NextSceneManager.instance.placeholder;
		Debug.Log ("Difficulty for puzzle " + puzzleName + " is: "+ this.difficulty);
	}

    //Debugging Only
    public void FinishPuzzle() {
        PuzzleComplete();
    }

}
