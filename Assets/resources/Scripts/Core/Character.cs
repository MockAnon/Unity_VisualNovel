using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character 
{
    
    public string characterName;

    public bool isMultiLayerCharacter { get { return renderers.renderer == null; } }

    public bool enabled { get { return root.gameObject.activeInHierarchy; } set { root.gameObject.SetActive(value); } }

    DialogueSystem dialogue;

    public void Say(string speech, bool add = false)
    {
        if (!enabled)
            enabled = true;

        if (!add)
            dialogue.Say(speech, characterName);
        else
            DialogueSystem.SayAdd (speech, characterName);
    }

    [HideInInspector] public RectTransform root;

    public Character (string _name, bool enableOnStart = true) 
    {
        CharacterManager cm = CharacterManager.instance;
        GameObject prefab = Resources.Load("Characters/Character[" + _name + "]") as GameObject;
        GameObject ob = GameObject.Instantiate (prefab, cm.characterPanel);

        root = ob.GetComponent<RectTransform>();
        characterName = _name;

        renderers.renderer = ob.GetComponentInChildren<RawImage> ();
        if (isMultiLayerCharacter)
        {
            renderers.bodyRenderer = ob.transform.Find ("bodyLayer").GetComponent<Image>();
            renderers.expressionRenderer = ob.transform.Find ("expressionLayer").GetComponent<Image>();
        }
        dialogue = DialogueSystem.instance;

        enabled = enableOnStart;
    }
    [System.Serializable]
    public class Renderers
    {
        
        public RawImage renderer;
        public Image bodyRenderer;
        public Image expressionRenderer;
    }
    public Renderers renderers = new Renderers();
}
