using UnityEngine;
using System.Collections;

public class MuteSound : MonoBehaviour {

	bool isMute;

	public void Mute (){
		isMute = !isMute;
			AudioListener.volume =  isMute ? 0 : 1;
	}

}
