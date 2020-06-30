using UnityEngine;
using System.Collections;

public class ClickManager : MonoBehaviour
{

    void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Mouse Clicked");
		}
	}

}