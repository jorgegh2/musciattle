using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour {
	public Transform transformPlayer;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //transformPlayer.position = new Vector3(0, transformPlayer.position.y, transformPlayer.position.z);
       // GameObject t;
       // t.transform.position = new Vector3(2, 7, 0);
        Camera.main.transform.position = new Vector3(5, 5, 0);
	}
}
