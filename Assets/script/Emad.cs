using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator anim=GetComponent<Animator>();
		anim.SetInteger("state",1);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeState2(){

		Animator anim=GetComponent<Animator>();
		anim.SetInteger("state",0);
	}
}
