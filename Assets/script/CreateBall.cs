using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBall : MonoBehaviour {

	public GameObject itemPrefab;

	public Sprite[] ColorSprite ;
	private int numCount ;
	//public int itemCount = 10, columnCount = 1;
	float width = 125;
		//float width = 1100;

	private AllShared sharedobj;

	private List<Vector3> BallVector3_temp;
	private List<string> BallNames_temp;


//	float ratio = 1;

	float height = 125;

	GameObject[] Balls_temp ;
	GameObject[] Balls_temp2 ;
	void Start () {
		setshared();
		Balls_temp2 = new GameObject[sharedobj.getCountNum()];	
		
		if (sharedobj.getIsGameStarted())
		{
			BallVector3_temp = new List<Vector3>();
			BallNames_temp = new List<string>();
			GameObject[] Ball_temp = new GameObject[sharedobj.getBallsVector3().Count];
			BallVector3_temp =  sharedobj.getBallsVector3();
			BallNames_temp = sharedobj.getBallsName();
			for (int i = 0; i < BallVector3_temp.Count; i++)
			{
				ShowAgainBalls(i);
			}
			
			//Debug.Log(sharedobj.getBalls().Count);
			// Balls_temp2 = sharedobj.getBalls();
			// foreach (GameObject g in Balls_temp2)
			// {
			// 	Debug.Log(g.GetComponent<Text>().text);
			// }
			// for (int i = 1; i <= sharedobj.getBalls().Count; i++)
			// {
			// 	GameObject newItem = Instantiate(sharedobj.getBalls() as GameObject;
			// }
		}else
		{
		
			numCount = sharedobj.getCountNum();
			//Debug.Log(sharedobj.getIsGameStarted() + "asasasasasasaasasasas");
			// GameObject newItem = Instantiate(itemPrefab) as GameObject;
			// RectTransform r =  newItem.GetComponent<RectTransform>();
			// r.position = new Vector3(100,100,0);
			// Debug.Log(newItem.transform.position);
			//create ();
			//createtest();
			if(numCount > 70)
				{
					width = 0.9f * width;
					height = 0.9f * height;
					itemPrefab.GetComponent<CircleCollider2D>().radius = width/2;
				}
				else if(numCount > 130)
				{
					width = 0.8f * width;
					height = 0.8f * height;
					itemPrefab.GetComponent<CircleCollider2D>().radius =  width/2;
				}else if(numCount > 200)
				{
					width = 0.5f * width;
					height = 0.5f * height;
					itemPrefab.GetComponent<CircleCollider2D>().radius =  width/2;
				}

			if (sharedobj.getIsGameStarted() == false)
			{
				//Debug.Log("te0");
				//Balls_temp = new List<GameObject>();
				
				//Debug.Log("te1");
				
				for (int i = 0; i < numCount ; i++) {
					CreateWithFor((i+1).ToString());
				}
				sharedobj.setIsGameStarted(true);
				
				//Debug.Log("te3");
				//sharedobj.setBalls(Balls_temp);
				//Debug.Log("te4");
				// for (int i = 0; i < numCount; i++)
				// {
				// 	Debug.Log("x: " + Balls_temp[i].GetComponent<Transform>().position.x + " y: "
				// 				+ Balls_temp[i].GetComponent<Transform>().position.y);
				// }
			}
			else
			{
				//SetSpriteBallSelected(); 
			}
			//Debug.Log("jjjjjjjjjjjjjjjjj :"+ Balls_temp.Count);
		}

	}
	
	private void SetSpriteBallSelected() //تنظیم عکس توپهای انتخاب شده
	{
		for (int i = 0; i < numCount ; i++) {
				if( i < sharedobj.getCurentNumber() )
				{
					GameObject.Find(i.ToString()).GetComponent<Image>().sprite = ColorSprite[5];
					GameObject.Find(i.ToString()).GetComponent<Button>().interactable = false;
				}
			}
	}

	private void setshared()
	{
		//GameObject gameSharedPreference = GameObject.Find("GameShared");
		GameObject gameSharedPreference = GameObject.FindGameObjectWithTag("GameSharedPublic") ;
		sharedobj =  gameSharedPreference.GetComponent<AllShared>();
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.Q)) {
			//GameObject newItem = Instantiate(itemPrefab) as GameObject;
			//Debug.Log("dd");
			//create();
		}
	}

	

	public void ShowAgainBalls(int i)
	{
		RectTransform BallRectTransform = itemPrefab.GetComponent<RectTransform> ();
		CircleCollider2D BallCollider = itemPrefab.GetComponent<CircleCollider2D> ();

		RectTransform containerRectTransform = gameObject.GetComponent<RectTransform> ();

		//calculate the width and height of each child item.
 
			GameObject newItem = Instantiate (itemPrefab) as GameObject;
			newItem.GetComponentInChildren<Text> ().text = BallNames_temp[i].ToString();
			newItem.GetComponentInChildren<Text> ().name = BallNames_temp[i].ToString();
			//newItem.GetComponentInChildren<col> ().setGdelete(newItem);
			
			if(i < sharedobj.getCurentNumber()-1){
				newItem.GetComponent<Image>().sprite = ColorSprite[5];
				newItem.GetComponent<Button>().interactable = false;
			}else
			{
				int ColorNum = i % 5;
				newItem.GetComponent<Image>().sprite = ColorSprite[ColorNum];
			}
			

			//Debug.Log(width + "   " + height + "   " + newItem.GetComponent<CircleCollider2D>().radius + "hhhhhhh");
			
            // col.Gdelete=newItem;
			//collider2D colli = newItem.collider2D
			//newItem.GetComponent<Text>().text = "dd";
			//newItem.GetComponentInChildren<Text>().Text = "dd";
			//newItem.GetComponentInChildren<GUIText>().text = "d";
			newItem.name =  BallNames_temp[i].ToString(); //+ " " + gameObject.name;
			//Debug.Log(newItem.name);
			newItem.transform.parent = gameObject.transform;

			//move and size the new item
			RectTransform rectTransform = newItem.GetComponent<RectTransform> ();
			//Debug.Log(rectTransform.position);
			//rectTransform =  containerRectTransform ;
			rectTransform.anchorMin = new Vector2 (0, 0);
			rectTransform.anchorMax = new Vector2 (0, 0);
			//rectTransform.position = new Vector3(00,00,0);
			//float x = -containerRectTransform.rect.width / 2 + width * (i % columnCount);
			//float newx = Random.Range (107, 2142);
			//Debug.Log("x:" + x);
			//float y = containerRectTransform.rect.height / 2 - height * j;
			//float newy = Random.Range (101, 3816);
			newItem.GetComponentInChildren<Text> ().name = BallVector3_temp[i].x.ToString () + 
															" " + BallVector3_temp[i].y.ToString ();
			//Debug.Log("y:" + y);
			//rectTransform.position = new Vector3(x,y,0);

			//Debug.Log(x.ToString() + " : " + y.ToString());
			float x = 0;
			float y = 0;
			rectTransform.offsetMin = new Vector2 (x, y);

			x = rectTransform.offsetMin.x + width;
			y = rectTransform.offsetMin.y + height;
			//Debug.Log ("rectTransform.offsetMin.x: " + rectTransform.offsetMin.x);
			//Debug.Log ("rectTransform.offsetMin.y :" + rectTransform.offsetMin.y);

			//x=56;
			//y=56;
			rectTransform.offsetMax = new Vector2 (x, y);
			rectTransform.position = new Vector3 (BallVector3_temp[i].x, BallVector3_temp[i].y, 0); // (0,0) => (42+65,36+65,0) = (107,101,0)    and (2099,3780,0)

			Debug.Log("counter: " +i);
			
			//Balls_temp.Add( newItem);
			Debug.Log("rrrr: ");
		
	}

	public void CreateWithFor(string i)
	{
		RectTransform BallRectTransform = itemPrefab.GetComponent<RectTransform> ();
		CircleCollider2D BallCollider = itemPrefab.GetComponent<CircleCollider2D> ();

		RectTransform containerRectTransform = gameObject.GetComponent<RectTransform> ();

		//calculate the width and height of each child item.
 
			GameObject newItem = Instantiate (itemPrefab) as GameObject;
			newItem.GetComponentInChildren<Text> ().text = i;
			newItem.GetComponentInChildren<Text> ().name = i;
			newItem.GetComponentInChildren<col> ().setGdelete(newItem);
			
			if(int.Parse(i) < sharedobj.getCurentNumber()){
				newItem.GetComponent<Image>().sprite = ColorSprite[5];
				newItem.GetComponent<Button>().interactable = false;
			}else
			{
				int ColorNum = int.Parse(i) % 5;
				newItem.GetComponent<Image>().sprite = ColorSprite[ColorNum];
			}
			

			Debug.Log(width + "   " + height + "   " + newItem.GetComponent<CircleCollider2D>().radius + "hhhhhhh");
			
            // col.Gdelete=newItem;
			//collider2D colli = newItem.collider2D
			//newItem.GetComponent<Text>().text = "dd";
			//newItem.GetComponentInChildren<Text>().Text = "dd";
			//newItem.GetComponentInChildren<GUIText>().text = "d";
			newItem.name = i ; //+ " " + gameObject.name;
			//Debug.Log(newItem.name);
			newItem.transform.parent = gameObject.transform;

			//move and size the new item
			RectTransform rectTransform = newItem.GetComponent<RectTransform> ();
			//Debug.Log(rectTransform.position);
			//rectTransform =  containerRectTransform ;
			rectTransform.anchorMin = new Vector2 (0, 0);
			rectTransform.anchorMax = new Vector2 (0, 0);
			//rectTransform.position = new Vector3(00,00,0);
			//float x = -containerRectTransform.rect.width / 2 + width * (i % columnCount);
			float newx = Random.Range (107, 2142);
			//Debug.Log("x:" + x);
			//float y = containerRectTransform.rect.height / 2 - height * j;
			float newy = Random.Range (101, 3816);
			newItem.GetComponentInChildren<Text> ().name = newx.ToString () + " " + newy.ToString ();
			//Debug.Log("y:" + y);
			//rectTransform.position = new Vector3(x,y,0);

			//Debug.Log(x.ToString() + " : " + y.ToString());
			float x = 0;
			float y = 0;
			rectTransform.offsetMin = new Vector2 (x, y);

			x = rectTransform.offsetMin.x + width;
			y = rectTransform.offsetMin.y + height;
			//Debug.Log ("rectTransform.offsetMin.x: " + rectTransform.offsetMin.x);
			//Debug.Log ("rectTransform.offsetMin.y :" + rectTransform.offsetMin.y);

			//x=56;
			//y=56;
			rectTransform.offsetMax = new Vector2 (x, y);
			rectTransform.position = new Vector3 (newx, newy, 0); // (0,0) => (42+65,36+65,0) = (107,101,0)    and (2099,3780,0)

			Debug.Log("counter: " +i);
			
			//Balls_temp.Add( newItem);
			Debug.Log("rrrr: ");
		
	}
	
	private void create () {
		RectTransform BallRectTransform = itemPrefab.GetComponent<RectTransform> ();
		CircleCollider2D BallCollider = itemPrefab.GetComponent<CircleCollider2D> ();

		RectTransform containerRectTransform = gameObject.GetComponent<RectTransform> ();

		//calculate the width and height of each child item.

		float width = 125;
		//float width = 1100;

		float ratio = 1;

		float height = 125;
		//float height = 2000;

		//if (itemCount % rowCount > 0)
		//	rowCount++;

		//adjust the height of the container so that it will just barely fit all its children
		//float scrollHeight = height * rowCount;
		//containerRectTransform.offsetMin = new Vector2(containerRectTransform.offsetMin.x, -scrollHeight / 2);

		//containerRectTransform.offsetMax = new Vector2(containerRectTransform.offsetMax.x, scrollHeight / 2);
		//Debug.Log(containerRectTransform.offsetMin.ToString());

		//int j = 0;
		/*while (gameObject.transform.childCount <= numCount)
		{
			
		}*/
		/*for (int i = 0; i < numCount; i++) {
			
			
		}*/
		while (gameObject.transform.childCount<numCount)
		{
			Debug.Log(gameObject.transform.childCount);
			//this is used instead of a double for loop because itemCount may not fit perfectly into the rows/columns
			// if (i % columnCount == 0)
			// 	j++;

			//create a new item, name it, and set the parent
			//int Num = Random.Range(1,20)
			//int numname= 
			GameObject newItem = Instantiate (itemPrefab) as GameObject;
			newItem.GetComponentInChildren<Text> ().text = gameObject.transform.childCount.ToString ();
			newItem.GetComponentInChildren<Text> ().name = gameObject.transform.childCount.ToString ();
			newItem.GetComponentInChildren<col> ().setGdelete(newItem);
			//newItem.GetComponent<Text>().text = "dd";
			//newItem.GetComponentInChildren<Text>().Text = "dd";
			//newItem.GetComponentInChildren<GUIText>().text = "d";
			newItem.name = gameObject.transform.childCount + " " + gameObject.name;
			//Debug.Log(newItem.name);
			newItem.transform.parent = gameObject.transform;

			//move and size the new item
			RectTransform rectTransform = newItem.GetComponent<RectTransform> ();
			//Debug.Log(rectTransform.position);
			//rectTransform =  containerRectTransform ;
			rectTransform.anchorMin = new Vector2 (0, 0);
			rectTransform.anchorMax = new Vector2 (0, 0);
			//rectTransform.position = new Vector3(00,00,0);
			//float x = -containerRectTransform.rect.width / 2 + width * (i % columnCount);
			float newx = Random.Range (107, 2142);
			//Debug.Log("x:" + x);
			//float y = containerRectTransform.rect.height / 2 - height * j;
			float newy = Random.Range (101, 3816);
			newItem.GetComponentInChildren<Text> ().name = newx.ToString () + " " + newy.ToString ();
			//Debug.Log("y:" + y);
			//rectTransform.position = new Vector3(x,y,0);

			//Debug.Log(x.ToString() + " : " + y.ToString());
			float x = 0;
			float y = 0;
			rectTransform.offsetMin = new Vector2 (x, y);

			x = rectTransform.offsetMin.x + width;
			y = rectTransform.offsetMin.y + height;
			

			//x=56;
			//y=56;
			rectTransform.offsetMax = new Vector2 (x, y);
			rectTransform.position = new Vector3 (newx, newy, 0); // (0,0) => (42+65,36+65,0) = (107,101,0)    and (2099,3780,0)

		}
	  

	}
}