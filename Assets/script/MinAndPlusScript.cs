using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MinAndPlusScript : MonoBehaviour {

	public Text butt = null;

	public void Plus (){
		int ValueText = int.Parse(butt.text);
		//Debug.Log (a);
		//butt.text.Clone
		
		if (butt.name == "PlayerText") {
			Debug.Log (ValueText);	
			if (ValueText >= 2 & ValueText <= 5) {
				//ValueText++;
				Debug.Log (ValueText++);
				butt.text = (ValueText++).ToString ();
			}
		} else if (butt.name == "timerText") {
			Debug.Log (ValueText);	
			if (ValueText >= 15 & ValueText <= 40) {
				//ValueText++;
				Debug.Log (ValueText+5);
				butt.text = (ValueText+5).ToString ();
			}
		}else if (butt.name == "numText") {
			Debug.Log (ValueText);	
			if (ValueText >= 25 & ValueText <= 120) {
				//ValueText++;
				Debug.Log (ValueText+5);
				butt.text = (ValueText+5).ToString ();
			}
		}
	}

	public void Min (){
		int ValueText = int.Parse(butt.text);
		//Debug.Log (a);
		//butt.text.Clone

		if (butt.name == "PlayerText") {
			Debug.Log (ValueText);	
			if (ValueText >= 3 & ValueText <= 6) {
				//ValueText++;
				Debug.Log (ValueText--);
				butt.text = (ValueText--).ToString ();
			}
		} else if (butt.name == "timerText") {
			Debug.Log (ValueText);	
			if (ValueText >= 20 & ValueText <= 45) {
				//ValueText++;
				Debug.Log (ValueText-5);
				butt.text = (ValueText-5).ToString ();
			}
		}else if (butt.name == "numText") {
			Debug.Log (ValueText);	
			if (ValueText >= 30 & ValueText <= 125) {
				//ValueText++;
				Debug.Log (ValueText-5);
				butt.text = (ValueText-5).ToString ();
			}
		}
	}

	

}
