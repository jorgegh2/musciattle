using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour {
	public Transform transformPlayer;
	public float count = 0.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	   count = count - 0.1f;
       transformPlayer.position = new Vector3(count, transformPlayer.position.y, transformPlayer.position.z);
       // GameObject t;
       // t.transform.position = new Vector3(2, 7, 0);
      //  Camera.main.transform.position = new Vector3(5, 5, 0);
	}
}
