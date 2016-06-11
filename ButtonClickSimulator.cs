using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClickSimulator : MonoBehaviour {

	[SerializeField] Button button;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			button.onClick.Invoke ();
		}
	}


}
