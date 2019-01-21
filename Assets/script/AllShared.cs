using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllShared : MonoBehaviour {

	[HideInInspector]
	public int playersCount;
	[HideInInspector]
	public List<GameObject> playersList;
	[HideInInspector]
	public int playersTurn;
	[HideInInspector]
	public bool isGameStarted;
	[HideInInspector]
	public bool isFirstRound;
	[HideInInspector]
	public int[] playersScoreList = new int[6];

	[HideInInspector]
	public List<Vector3> BallsVector3;
	
	[HideInInspector]
	public List<string> BallsName;


	[HideInInspector]
	public List<GameObject> toolsList;
	[HideInInspector]
	public List<int> toolsOwnerNumber;
	
	[HideInInspector]
	public bool HardLevel;

	[HideInInspector]
	public string TimerForEveryone;

	[HideInInspector]
	public int CountNum;
	[HideInInspector]
	public int CurentNumber;

	[HideInInspector]
	public string RecordOnePersonMode;

	[HideInInspector]
	public GameObject[] Balls;


	public AllShared () {
		playersCount = 0;
		//blocksList = new List<GameObject> ();
		//cloudBlocksList = new List<GameObject> ();
		//baseBlocksCoordinateList = new List<int[]>();
		playersList = new List<GameObject> ();
		//buttonsList = new List<Button> ();
		//mafiaGuyNumber = 0;
		playersTurn = 0;
		isGameStarted = false;
		isFirstRound = true;
		//isKillingMove = false;
		//killedCivilianList = new List<int> ();
		//playersScoreList = new int[6];

		toolsList = new List<GameObject> ();
		toolsOwnerNumber = new List<int> ();
		//Balls = new List<GameObject>();
		HardLevel =false;
		TimerForEveryone = "15";
		CountNum = 25;
		CurentNumber = 1;
		//toolsbaseCoordinateList = new List<int[]> ();
	}

	public void setPlayersCount(int count)
	{
		playersCount = count;
	}

	public void setRecordOnePersonMode(string Record)
	{
		RecordOnePersonMode = Record;
	}
	public void setBallsVector3(List<Vector3> count)
	{
		BallsVector3 = count;
	}

	public void setBallsName(List<string> count)
	{
		BallsName = count;
	}

	public void setCountNum(int count)
	{
		CountNum = count;
	}
	
	public void setCurentNumber(int curent)
	{
		CurentNumber = curent;
	}
	public void setTimerForEveryone(string time)
	{
		TimerForEveryone = time;
	}

	public void setPlayersList(List<GameObject> list)
	{
		playersList = list;
	}

	public void setPlayersTurn(int turn)
	{
		playersTurn = turn;
	}

	public void setHardLevel(bool status)
	{
		HardLevel = status;
	}

	public void setIsGameStarted(bool isStarted)
	{
		isGameStarted = isStarted;
	}

	public void setIsFirstRound(bool isFirst)
	{
		isFirstRound = isFirst;
	}

	public void setPlayersScoreList(int[] list)
	{
		playersScoreList = list;
	}

	public void setPlayersScoreListIndex(int Value, int index)
	{
		playersScoreList[index] = Value;
	}

	public void settoolsList(List<GameObject> list)
	{
		toolsList = list;
	}

	public void setBalls(GameObject[] list)
	{
		Balls = list;
	}

	public void settoolsOwnerNumber(List<int> list)
	{
		toolsOwnerNumber = list;
	}


	public int getPlayersCount()
	{
		return playersCount;
	}
	
	public string getRecordOnePersonMode()
	{
		return RecordOnePersonMode;
	}
	public List<Vector3> getBallsVector3()
	{
		return BallsVector3 ;
	}

	public List<string> getBallsName()
	{
		return BallsName ;
	}

	public string getTimerForEveryone()
	{
		return TimerForEveryone ;
	}

	public int getCurentNumber()
	{
		return CurentNumber;
	}
	public int getCountNum()
	{
		return CountNum;
	}
	public bool getHardLevel()
	{
		return HardLevel;
	}

	public List<GameObject> getPlayersList()
	{
		return playersList;
	}

	public GameObject[] getBalls()
	{
		return Balls;
	}

	public int getPlayersTurn()
	{
		return playersTurn;
	}

	public bool getIsGameStarted()
	{
		return isGameStarted;
	}

	public bool getIsFirstRound()
	{
		return isFirstRound;
	}

	public int[] getPlayersScoreList()
	{
		return playersScoreList;
	}

	public int getPlayersScoreListIndex(int index)
	{
		return playersScoreList[index];
	}


	public List<GameObject> gettoolsList()
	{
		return toolsList;
	}

	public List<int> gettoolsOwnerNumber()
	{
		return toolsOwnerNumber;
	}

	
}
