using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnergyControl : MonoBehaviour {

	public Image energyBar;
	public float energy; // between 0-100
	public PlayerControl playerControl;
	// Use this for initialization
	void Start () {
		GameObject playerControlObject = GameObject.FindWithTag ("Player");
		if (playerControlObject != null)
		{
			playerControl = playerControlObject.GetComponent <PlayerControl>();
		}
		if (playerControl == null) {
			Debug.Log ("Cannot find 'PlayerControl' script");
		}
	}
	
	// Update is called once per frame
	void Update () {
		CheckEnergy ();
		AddEnergy ();
		print (energy);

	}
	void AddEnergy(float energyRegen = 5.2f)
	{
		if (energy + energyRegen > 100.0f) {
			energy = 100.0f;
		} else {
			energy += energyRegen * Time.deltaTime;
		}
	}
	void CheckEnergy()
	{
		energyBar.rectTransform.localScale = new Vector3 (energy / 100, energyBar.rectTransform.localScale.y, energyBar.rectTransform.localScale.z);
		if (energy <= 5.0f) {
			playerControl.energyfull = false;

			//disable shooting
		}
		else {
			playerControl.energyfull = true;
		}
	}
}
