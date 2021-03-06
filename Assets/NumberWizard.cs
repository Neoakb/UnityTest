﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	public int maxGuessesAllowed = 20;
	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min,max+1)/2;
		text.text = guess.ToString();
		maxGuessesAllowed--;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
