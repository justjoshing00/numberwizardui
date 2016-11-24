using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class NumberWizard : MonoBehaviour {
	int min;
	int max;
	int GuessedNumber;
	int NumberOfGuesses;


    // Use this for initialization
	void Start () {
	
	StartGame();
	   
	    
	}
	
	void StartGame(){
	    min = 1;
	    max = 1000;
		GuessedNumber = 500;
		NumberOfGuesses = 0;
		}
		
	public void GuessHigher(){

		    //buuton stuff here 
       		min = GuessedNumber;
       		NextGuess();
       		WinCondition();

        }

	public void GuessLower(){

		    //buuton stuff here 
       		max = GuessedNumber;
       		NextGuess();
		    WinCondition();
        }	
        	
	
	void NextGuess(){
		GuessedNumber =(max + min)/2;

	}
	void WinCondition(){

	 NumberOfGuesses = NumberOfGuesses +1;
	 if (NumberOfGuesses == 5){
	 SceneManager.LoadScene("WinScene"); }
	 }

}
