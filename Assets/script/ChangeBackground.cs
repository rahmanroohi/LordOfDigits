using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour {


	public Texture[] BackGroundColor;

	public RawImage RawObj;

	private AllShared sharedobj;
	private RawImage img;
	// Use this for initialization
	void Start () {
		setshared();
		//sharedobj.getPlayersTurn();
		RawObj.texture = (Texture) BackGroundColor[sharedobj.getPlayersTurn()-1];
		//img = (RawImage) this.gameObject.GetComponent<RawImage>();
		//img.texture = (Texture) BackGroundColor[sharedobj.getPlayersTurn()-1];
		//this.gameObject.GetComponent<Image>().sprite = BackGroundColor[0];
		// RawImage Raw_temp ;
		// Raw_temp = BackGroundImage.GetComponent<RawImage>();
		// Raw_temp.texture = BackGroundColor[sharedobj.getPlayersTurn()-1];

		//GameObject.Find("background").GetComponent<Image>().sprite = 
		//BackGroundImage.GetComponent<Texture>().sprite = BackGroundColor[sharedobj.getPlayersTurn()-1];
	}

	private void setshared()
	{
		//GameObject gameSharedPreference = GameObject.Find("GameShared");
		GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	}
	
	
}
