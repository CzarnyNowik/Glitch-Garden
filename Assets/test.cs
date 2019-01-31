using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefsController.SetMasterVolume(1f);
        Debug.Log(PlayerPrefsController.GetMasterVolume());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
