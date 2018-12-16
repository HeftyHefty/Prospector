﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Prospector : MonoBehaviour {

	static public Prospector 	S;

	[Header("Set in Inspector")]
	public TextAsset			deckXML;


	[Header("Set Dynamically")]
	public Deck					deck;

	void Awake(){
		S = this; //set up a Singleton for Prospector 
	}

	void Start() {
		deck = GetComponent<Deck> (); //Get the Deck
		deck.InitDeck (deckXML.text); //Pass DeckXML to it 
	}

}
