using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int min, max, guess;

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard!");
		StartGame();
	}
	
	void StartGame(){
		min = 0;
		max = 1000;
		print("=========================");
		print("Pick a number between " + min + " and " + max + ", but don't tell me.");
		print("UpArrow = higher, DownArrow = lower, Return = equal");
		NextGuess();
	}
	
	// Update is called once per frame
	void Update () {	
		if(Input.GetKeyDown(KeyCode.Return)){
			print("Win");
			StartGame();
		}	
		else if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}
	}
	
	void NextGuess(){
		guess = (int)Mathf.Floor((min + max) / 2);
		print("Is the number equal, lesser or higher than " + guess + "?");
	}
	
}
