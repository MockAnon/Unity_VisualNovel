﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterTesting : MonoBehaviour 
{
    public Character Raelin;
    public Character Avira;

	// Use this for initialization
	void Start () 
    {
        Raelin = CharacterManager.instance.GetCharacter ("Raelin", enableCreatedCharacterOnStart: false);	
        Avira = CharacterManager.instance.GetCharacter("Avira", enableCreatedCharacterOnStart: false);
	}

    public string[] speech;
    int i = 0;

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown (KeyCode.Space)) 
        {
            if (i < speech.Length)
                Raelin.Say(speech[i]);
            else
                DialogueSystem.instance.Close();

            i++;
        }
        if (Input.GetKey (KeyCode.M)) 
        {
            Raelin.Move(Vector3.left * amt)   
        }
		
	}
}
