using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Characters : MonoBehaviour {

    public string name;
    [HideInInspector] public RectTransform root;

    public character (string _name) 
    {
        CharacterManager cm = CharacterManager.instance;
        GameObject prefab = Resources.Load("Characters/Character["+_name:"]") as GameObject;
        GameObject ob = Instantiate(prefab, cm.characterPanel);

        root = ob.GetComponent<RectTransform>();
        name = _name;
    }
    class Renderers
    {
        public RawImage renderer;
        public Image bodyRenderer;
        public Image expressionRenderer;
    }
    Renderers renderers;
}
