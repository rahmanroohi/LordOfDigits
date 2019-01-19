using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLocationBalls : MonoBehaviour {

	private AllShared sharedobj;

	private List<Vector3> BallVector3_temp;
	private List<string> BallNames_temp;
	
	// Use this for initialization
	void Start () {
		GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
		//GameObject gameSharedPreference = GameObject.Find("GameShared");
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	}
	
	// Update is called once per frame
	void LateUpdate()
	{
		if(sharedobj.getBallsVector3().Count == 0)
		{
			BallVector3_temp = new List<Vector3>();
			BallNames_temp = new List<string>();
			GameObject[] Ball_temp = new GameObject[GameObject.FindGameObjectsWithTag("Ball").Length];

			Ball_temp = GameObject.FindGameObjectsWithTag("Ball");
			//Debug.Log(Ball_temp[0].name);

			for (int i = 0; i < Ball_temp.Length; i++)
			{
				BallVector3_temp.Add(Ball_temp[i].transform.position);
				//Debug.Log(Ball_temp[i].name);
				BallNames_temp.Add(Ball_temp[i].name);
				Debug.Log(Ball_temp[i].name);
			}
			sharedobj.setBallsVector3(BallVector3_temp);
			sharedobj.setBallsName(BallNames_temp);
		}
	}
}
