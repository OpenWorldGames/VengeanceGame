using UnityEngine;
using System.Collections;
using SmartLocalization;

public class LanguageLocal : MonoBehaviour {

	public string WelcomeKey = "welcome";
	public string HelloKey = "hello";

	void OnGUI () {
		GUILayout.Label (LanguageManager.Instance.GetTextValue (HelloKey));
		GUILayout.Label (LanguageManager.Instance.GetTextValue (WelcomeKey));
	}


}
