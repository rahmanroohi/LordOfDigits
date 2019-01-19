using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class col : MonoBehaviour {

	public Sprite DisableBall ;

	private AllShared sharedobj;
  	private GameObject Gdelete;
  	private string name = "ss";
  	static int counter = 0;

	int[] playersScoreList_temp;
	void Start()
	{
		setshared();
	}
	public void setGdelete(GameObject gD)
	{
		
		Gdelete=gD;
		//name = gD.GetComponentInChildren<Te
		//Debug.Log("ooooooooooooooooo");
	}
	void  OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("halalalalalalala");
		if(counter % 2 == 1)
		{
			//GameObject ga = new GameObject();
			//ga = Gdelete ;
			// name = Gdelete.GetComponent<Text>().text;
			string[] str = Gdelete.name.Split(' ');
			//Debug.Log("Ball Number: "  + Gdelete.name + " Is Deleted" );
			Destroy(Gdelete);
			//GameObject.Find("7 ُScrolball").GetComponent<CreateBall>().CreateWithFor("eeww");
			//gameObject.GetComponent<CreateBall>().CreateWithFor(name);
			GameObject.FindWithTag("scroll").GetComponent<CreateBall>().CreateWithFor(str[0]);
			//Debug.Log("Ball Number: "+Gdelete.name + " Is Added" );
			//createt();
		}
		counter++ ;
		Debug.Log(counter);	
	}

	private void createt(){
		//GameObject g = new GameObject("ُScrolball");
		GameObject.FindWithTag("scroll").GetComponent<CreateBall>().CreateWithFor(name);
		//GameObject.Find("Scrolball").GetComponent<CreateBall>().CreateWithFor(name);
		//Debug.Log("YESSSSSSSSSSSSSSSSSSSS");
	}
	
	
	public void ClickBall(	)
	{

		if(this.gameObject.GetComponentInChildren<Text>().text == sharedobj.getCurentNumber().ToString())
		{
			if (!sharedobj.getHardLevel())
			{
				this.gameObject.GetComponent<Image>().sprite = DisableBall;
				this.gameObject.GetComponent<Button>().interactable = false;
			}
			sharedobj.setCurentNumber(sharedobj.getCurentNumber()+1);

			sharedobj.setPlayersScoreListIndex(sharedobj.getPlayersScoreListIndex(sharedobj.getPlayersTurn()-1)+1 ,
												sharedobj.getPlayersTurn()-1);
			//Debug.Log("score player num" +sharedobj.getPlayersTurn() + " : " + sharedobj.getPlayersScoreListIndex(sharedobj.getPlayersTurn()-1));
			
		}
	}
	private void setshared()
	{
		GameObject gameSharedPreference = GameObject.Find("GameShared");
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	}
}
