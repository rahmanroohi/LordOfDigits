using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingAndRun : MonoBehaviour {

	private AllShared sharedobj;
	public Text PlayerTextCount;
	public Text TimerTextCount;
	public Text NumTextCount;
	public Sprite[] btn;

	public GameObject btn_hard;
	public GameObject btn_easy;
	public GameObject setactive_Obj;
	// Use this for initialization
	void Start () {
		setshared();
		
		if(sharedobj.getIsGameStarted() == true)
		{
			//Debug.Log(sharedobj.getBallsVector3());
			GameObject.Find("mainmenu").SetActive(false);
			//GameObject StartGame_temp = GameObject.Find("StartGame");
			//GameObject.Find("StartGame").SetActive(true);
			setactive_Obj.SetActive(true);
			GameObject.Find("numbernowText").GetComponent<Text>().text= sharedobj.getCurentNumber().ToString();
			GameObject.Find("timernowText").GetComponent<Text>().text= sharedobj.getTimerForEveryone().ToString();
			//GameObject[] gg = new GameObject[sharedobj.getCountNum()];
			//GameObject gg = new GameObject();
			//gg= sharedobj.getTemp();
			//gg = sharedobj.getBalls();
			Debug.Log(";");
			//GameObject.Find("setting").SetActive(false);
			//GameObject.Find("SetPlayers").SetActive(false);
			
		}
		//Debug.Log(PlayerPrefs.GetInt("IsGameStarted"));
		//Debug.Log(PlayerPrefs.GetInt("IsGameStarted1"));
		//Debug.Log(sharedobj.getIsGameStarted());
		//if(PlayerPrefs.GetInt("IsGameStarted1") == 1)
		
	}
	
	private void setshared()
	{
		//GameObject gameSharedPreference = GameObject.Find("GameShared");
		GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
		//Debug.Log(sharedobj.getCountNum());
	}

	void  Awake()
	{
		GameObject[] obj = GameObject.FindGameObjectsWithTag("GameSharedPublic") ;
		DontDestroyOnLoad(obj[0]);
		
		
	}
	public void SaveSetting()
	{
		//Debug.Log(PlayerTextCount.text);
		sharedobj.setPlayersCount ( int.Parse (PlayerTextCount.text));
		sharedobj.setIsFirstRound ( true);
		//sharedobj.setIsGameStarted(true);
		sharedobj.setTimerForEveryone(TimerTextCount.text);
		sharedobj.setCountNum(int.Parse(NumTextCount.text));
		sharedobj.setCurentNumber(1);
		sharedobj.setPlayersTurn(0); //نوبت نفر اول
		int[] Empty_Score = new int[6];
		Empty_Score[0] = 0;
		Empty_Score[1] = 0;
		Empty_Score[2] = 0;
		Empty_Score[3] = 0;
		Empty_Score[4] = 0;
		Empty_Score[5] = 0;

		sharedobj.setPlayersScoreList(Empty_Score);

				//PlayerPrefs.SetInt("IsGameStarted1",0);
		Debug.Log( sharedobj.getIsGameStarted());
		set();
	}

	public void ReSetDetails()
	{
		set();
	}

	private void set()
	{
		GameObject.Find("timernowText").GetComponent<Text>().text = sharedobj.getTimerForEveryone();
		//numbernowText 
		GameObject.Find("numbernowText").GetComponent<Text>().text = sharedobj.getCurentNumber().ToString(); 
	}

	public void print(){
		Debug.Log(sharedobj.getIsGameStarted());
	}

	public void setting(bool hard)
	{
		setshared();
		if(hard) // is hard
		{
			sharedobj.setHardLevel(true);
			btn_hard.GetComponent<Image>().sprite = btn[1];
			btn_easy.GetComponent<Image>().sprite = btn[0];
		}
		else  // is easy
		{
			sharedobj.setHardLevel(false);
			btn_hard.GetComponent<Image>().sprite = btn[0];
			btn_easy.GetComponent<Image>().sprite = btn[1];
		}
		Debug.Log(sharedobj.getHardLevel());
	}
}
