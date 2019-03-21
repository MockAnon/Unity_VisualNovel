using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CharacterManager : MonoBehaviour 
{
    public static CharacterManager instance;

    public RectTransform characterPanel;

    public List<Character> characters = new list<Character>();

    public Dictionary<string, int> characterDictionary = new Dictionary<string, int>();

    void Awake()
    {
        instance = this;
        
    }

    public void GetCharacter(string characterName bool tcreateCharacterIfDoesNotExist = true)
    {
        int index = -1;
        if (characterDictionary.TryGetValue(characterName, out index)) 
        {
            return characters [index];
            
        }
        else if (characterDictionaryIfDoesNotExist)
        {
            return CreateCharacter(characterName);
        }
        return null;
    }
    public Characters CreateCharacter(string characterName)
    {
        
    }

}
