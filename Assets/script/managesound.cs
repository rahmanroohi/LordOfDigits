using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managesound : MonoBehaviour {



	//private AllShared sharedobj;
    public GameObject soundSource;
    public Sprite buttonOFF ;
	public Sprite buttonOn ;

	void Awake()
	{
//		Debug.Log ("Awake: " + AudioListener.pause);
//		//AudioListener.pause = false;
		//GameObject[] obj = GameObject.FindGameObjectsWithTag("GameSharedPublic") ;
//		if (obj.Length > 1) {
//			Destroy (obj [0]);
//		}
//		//if(AudioListener.pause == false)
//
		//DontDestroyOnLoad(this.gameObject);

	}
    // Use this for initialization
    void Start () {
		//setshared();
		
		if(AudioListener.pause == true)
			soundSource.GetComponent<Image>().sprite = buttonOFF;
		else
			soundSource.GetComponent<Image>().sprite = buttonOn;

		
	}

	// private void setshared()
	// {
	// 	//GameObject gameSharedPreference = GameObject.Find("GameShared");
	// 	GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
	// 	sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	// 	//Debug.Log(sharedobj.getCountNum());
	// }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void controlmusics()
	{
		//Debug.Log ("controlmusic: " + AudioListener.pause);
		if(AudioListener.pause == true)
		{
				AudioListener.pause = false;
				soundSource.GetComponent<Image>().sprite = buttonOn;
		}
		else
		{
			AudioListener.pause = true;
				soundSource.GetComponent<Image>().sprite = buttonOFF;
		}
	}
}
