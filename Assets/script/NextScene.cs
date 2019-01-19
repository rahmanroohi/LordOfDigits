using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	//public string SceneName="";
	public string SceneName ;
	
	
	
	private AllShared sharedobj;
	void  Start()
	{
		setshared();
	}

	private void setshared()
	{
		GameObject gameSharedPreference = GameObject.Find("GameShared");
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	}
	public void NextSene()
	{
		//sharedobj.setIsGameStarted(true);
		//Debug.Log(sharedobj.getIsGameStarted());
		
		if(sharedobj.getPlayersTurn() == sharedobj.getPlayersCount()){
			sharedobj.setPlayersTurn(1);
			
		}else
		{
			sharedobj.setPlayersTurn(sharedobj.getPlayersTurn()+1);
		}
		Debug.Log("nobateeeeee: " + sharedobj.getPlayersTurn());
		SceneManager.LoadScene(SceneName);
		
	}
	void Awake()
	{
		//DontDestroyOnLoad(GameObject.Find("StartGame"));
	}
	
}
