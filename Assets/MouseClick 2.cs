using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {
	/*
	void Start(){
		Debug.Log("I am alive");
	}
	*/

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//Debug.Log("I clicked it!");
			Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    		RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

    		if (cubeHit)
    		{
        		Debug.Log("We hit " + cubeHit.collider.name);
    		}
		}
		
	}

}
