using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
	private GameObject settingTab;
	public void LoadScene(string s){
		SceneManager.LoadScene (s, LoadSceneMode.Single);
	}
	public void LoadPanel()
	{
		//GameObject settingTab=GameObject.FindGameObjectWithTag("settingTag");
		settingTab.SetActive (true);
	}

	// Use this for initialization
	void Start () {
		settingTab=GameObject.FindGameObjectWithTag("settingTag");
		settingTab.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
//hello k xa khabbar
