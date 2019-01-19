using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollableList : MonoBehaviour {

	public GameObject itemPrefab;
	public int itemCount = 10, columnCount = 1;

	void Start()
	{
		create();

	}

	void Update()
	{
		if(Input.GetKeyUp(KeyCode.Q))
		{
			Debug.Log("dd");
			create();
		}
	}

	private void create(){
		RectTransform rowRectTransform = itemPrefab.GetComponent<RectTransform>();
		RectTransform containerRectTransform = gameObject.GetComponent<RectTransform>();

		//calculate the width and height of each child item.
		
		float width = containerRectTransform.rect.width / columnCount;
		//float width = 1100;
		
		float ratio = width / rowRectTransform.rect.width;
		
		float height = rowRectTransform.rect.height * ratio;
		//float height = 2000;

		int rowCount = itemCount / columnCount;
		if (itemCount % rowCount > 0)
			rowCount++;

		//adjust the height of the container so that it will just barely fit all its children
		float scrollHeight = height * rowCount;
		containerRectTransform.offsetMin = new Vector2(containerRectTransform.offsetMin.x, -scrollHeight / 2);
		
		containerRectTransform.offsetMax = new Vector2(containerRectTransform.offsetMax.x, scrollHeight / 2);
		Debug.Log(containerRectTransform.offsetMin.ToString());

		int j = 0;
		for (int i = 0; i < itemCount; i++)
		{
			//this is used instead of a double for loop because itemCount may not fit perfectly into the rows/columns
			if (i % columnCount == 0)
				j++;

			//create a new item, name it, and set the parent
			GameObject newItem = Instantiate(itemPrefab) as GameObject;
			newItem.name = gameObject.name + " item at (" + i + "," + j + ")";
			Debug.Log(newItem.name);
			newItem.transform.parent = gameObject.transform;

			//move and size the new item
			RectTransform rectTransform = newItem.GetComponent<RectTransform>();
			//Debug.Log(rectTransform.position);

			float x = -containerRectTransform.rect.width / 2 + width * (i % columnCount);
			Debug.Log("width:" + containerRectTransform.rect.width.ToString());
			float y = containerRectTransform.rect.height / 2 - height * j;
			Debug.Log("height:" + containerRectTransform.rect.height.ToString());
			Debug.Log(x.ToString() + " : " + y.ToString());
			x=0;
			y=0;
			rectTransform.offsetMin = new Vector2(x, y);
			
			x = rectTransform.offsetMin.x + width;
			y = rectTransform.offsetMin.y + height;
			x=56;
			y=56;
			rectTransform.offsetMax = new Vector2(x, y);
			Debug.Log(rectTransform.position);
		}

	}
}
