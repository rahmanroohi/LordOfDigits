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
	public GameObject[] Balls;


	[HideInInspector]
	

	/*
	[HideInInspector]
	public List<GameObject> blocksList;
	[HideInInspector]
	public List<GameObject> cloudBlocksList;
	[HideInInspector]
	public List<int[]> baseBlocksCoordinateList;
	[HideInInspector]
	public List<Color> baseBlocksColors;
	
	[HideInInspector]
	public List<Button> buttonsList;
	[HideInInspector]
	public int mafiaGuyNumber;
	
	[HideInInspector]
	public Vector3 moveToCoordinate;
	[HideInInspector]
	public string moveToBlockName;
	[HideInInspector]
	public int revealedBaseBlockOwner;
	[HideInInspector]
	public bool isKillingMove;
	[HideInInspector]
	public int lastCivilianKilledNumber;
	[HideInInspector]
	public List<int> killedCivilianList;
	
	[HideInInspector]
	public List<int[]> toolsbaseCoordinateList;

	[HideInInspector]
	public Vector3 toolsCoordinate;
	[HideInInspector]
	public int toolsOwnerNumber;
	[HideInInspector]
	public bool toolsUsed;
	*/

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

	// public void setBlocksList(List<GameObject> list)
	// {
	// 	blocksList = list;
	// }

	// public void setCloudBlocksList(List<GameObject> list)
	// {
	// 	cloudBlocksList = list;
	// }

	// public void setBaseBlocksCoordinateList(List<int[]> list)
	// {
	// 	baseBlocksCoordinateList = list;
	// }

	// public void setBaseBlocksColors(List<Color> list)
	// {
	// 	baseBlocksColors = list;
	// }

	public void setPlayersList(List<GameObject> list)
	{
		playersList = list;
	}

	// public void setButtonsList(List<Button> list)
	// {
	// 	buttonsList = list;
	// }

	// public void setMafiaGuyNumber(int number)
	// {
	// 	mafiaGuyNumber = number;
	// }

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

	// public void setIsKillingMove(bool isKilling)
	// {
	// 	isKillingMove = isKilling;
	// }

	// public void setLastCivilianKilled(int number)
	// {
	// 	lastCivilianKilledNumber = number;
	// }

	// public void setMoveToCoordinate(Vector3 destination)
	// {
	// 	moveToCoordinate = destination;
	// }

	// public void setMoveToBlockName(string name)
	// {
	// 	moveToBlockName = name;
	// }

	// public void setRevealedBaseBlockOwner(int number)
	// {
	// 	revealedBaseBlockOwner = number;
	// }

	// public void setKilledCivilianList(List<int> list)
	// {
	// 	killedCivilianList = list;
	// }

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

	// public void settoolsbaseCoordinateList(List<int[]> list)
	// {
	// 	toolsbaseCoordinateList = list;
	// }


	public int getPlayersCount()
	{
		return playersCount;
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

	// public List<GameObject> getBlocksList()
	// {
	// 	return blocksList;
	// }

	// public List<GameObject> getCloudBlocksList()
	// {
	// 	return cloudBlocksList;
	// }

	// public List<int[]> getBaseBlocksCoordinateList()
	// {
	// 	return baseBlocksCoordinateList;
	// }

	// public List<Color> getBaseBlocksColors()
	// {
	// 	return baseBlocksColors;
	// }

	public List<GameObject> getPlayersList()
	{
		return playersList;
	}

	public GameObject[] getBalls()
	{
		return Balls;
	}

	// public List<Button> getButtonsList()
	// {
	// 	return buttonsList;
	// }

	// public int getMafiaGuyNumber()
	// {
	// 	return mafiaGuyNumber;
	// }

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

	// public bool getIsKillingMove()
	// {
	// 	return isKillingMove;
	// }

	// public Vector3 getMoveToCoordinate()
	// {
	// 	return moveToCoordinate;
	// }

	// public string getMoveToBlockName()
	// {
	// 	return moveToBlockName;
	// }

	// public int getRevealedBaseBlockOwner()
	// {
	// 	return revealedBaseBlockOwner;
	// }

	// public int getLastCivilianKilled()
	// {
	// 	return lastCivilianKilledNumber;
	// }

	// public List<int> getKilledCivilianList()
	// {
	// 	return killedCivilianList;
	// }

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

	// public List<int[]> gettoolsbaseCoordinateList()
	// {
	// 	return toolsbaseCoordinateList;
	// }
}
