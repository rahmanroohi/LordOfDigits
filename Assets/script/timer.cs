using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	float StartTime;
	private AllShared sharedobj;

	bool cancount = true;
	bool doonce = false;
	public GameObject alarm;

	private List<Vector3> BallVector3_temp;
	private List<string> BallNames_temp;
	bool act =true;

	int h = 0;
	int m = 0;

	GameObject TimerText;
	// Use this for initialization
	void Start () {
		GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
		//GameObject gameSharedPreference = GameObject.Find("GameShared");
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
		StartTime = float.Parse(sharedobj.getTimerForEveryone());
		sharedobj.setPlayersCount(1);
		TimerText = GameObject.Find("Timer") ;
	}
	
	public void Starter()
	{
		
	}
	// Update is called once per frame
	void Update () {

		if(sharedobj.getPlayersCount() != 1)
		{
			if(StartTime >= 0.0f &&  cancount)
			{
				StartTime -= Time.deltaTime ;
				//alarm.SetActive(true);
				//Debug.Log((int) StartTime + "    " + (int)StartTime % 2);
				if( ((int) StartTime <= 5) && ((int)StartTime % 2 == 1)  &&  cancount)
				{

					alarm.SetActive(act)	 ;
					act = !act;
					//Debug.Log(StartTime);
				}
			}
			else if (StartTime <= 0.0f && !doonce)
			{
				cancount = false;
				doonce = true;
				StartTime = 0.0f;
				//Debug.Log(StartTime);
				alarm.SetActive(false)	 ;
				EndTime();
			}
		}
		else
		{ // مود تک نفره
			//StartTime = 0.0f;
			float t =Time.time;
			h = h+ (int)(t/3600);
			m =m+ (int) ((t % 3600)/60);
			float s =((t % 3600) % 60);
			TimerText.GetComponent<Text>().text =h.ToString() + ":" + m.ToString() + ":" + s.ToString("0.00");
			Debug.Log(t);
		}


		// float t =Time.time - StartTime;
		// Debug.Log(int.Parse( sharedobj.getTimerForEveryone()) + "    " + (int)(t % 60 ) + " sssssssss");
		// string secend = ((t % 60 ) ).ToString("00");
		// if(sharedobj.getTimerForEveryone() == secend ) //5 secend aakhar
		// {
		// 	Debug.Log("end");
		// 	alarm.SetActive(true);
		// 	//alarm.SetActive(!act)	 ;
		// 	//act = !act;
		// 	// if (int.Parse( sharedobj.getTimerForEveryone()) == ( (int)(t % 60 )))
		// 	// {
		// 	// 	SceneManager.LoadScene("mainpage");
		// 	// }
		// }
	}

	private void EndTime()
	{

		//Debug.Log(PlayerPrefs.GetInt("IsGameStarted1"));
		//PlayerPrefs.SetInt("IsGameStarted",1);
		//Debug.Log(PlayerPrefs.GetInt("IsGameStarted1"));
		//Balls_temp = new GameObject[sharedobj.getCountNum()];
				// if(sharedobj.getBallsVector3().Count == 0)
				// {
				// 	BallVector3_temp = new List<Vector3>();
				// 	BallNames_temp = new List<string>();
				// 	GameObject[] Ball_temp = new GameObject[GameObject.FindGameObjectsWithTag("Ball").Length];

				// 	Ball_temp = GameObject.FindGameObjectsWithTag("Ball");
				// 	//Debug.Log(Ball_temp[0].name);

				// 	for (int i = 0; i < Ball_temp.Length; i++)
				// 	{
				// 		BallVector3_temp.Add(Ball_temp[i].transform.position);
				// 		//Debug.Log(Ball_temp[i].name);
				// 		BallNames_temp.Add(Ball_temp[i].name);
				// 		Debug.Log(Ball_temp[i].name);
				// 	}
				// 	sharedobj.setBallsVector3(BallVector3_temp);
				// 	sharedobj.setBallsName(BallNames_temp);
				// }
		//Balls_temp = convertToList(GameObject.FindGameObjectsWithTag("Ball"));
		//Balls_temp=GameObject.FindGameObjectsWithTag("Ball");
		//Debug.Log(Balls_temp.Count);
		//sharedobj.setBalls(Balls_temp);
		
		SceneManager.LoadScene("mainpage");
		
	}

	private List<GameObject> convertToList(GameObject[] AllBall)
	{
		List<GameObject> ListBall = new List<GameObject>();
		for (int i = 0; i < AllBall.Length; i++)
		{
			ListBall.Add(AllBall[i]);
			
		}
		return ListBall;
	}

	void Awake()
	{
		//GameObject[] obj1 = GameObject.FindGameObjectsWithTag("scroll") ;
		//DontDestroyOnLoad();
		//DontDestroyOnLoad(GameObject.Find("Scrolball"));
		GameObject[] obj = GameObject.FindGameObjectsWithTag("GameSharedPublic") ;
		DontDestroyOnLoad(obj[0]);
	}
}
