using UnityEngine;
using System.Collections;
using UnityEditor;

// <sumary>
//
//</sumary>

[CustomEditor(typeof(ControllerPAI), true)]
public class ControllerPAI : MonoBehaviour {

	//Prefab Fade da tela 
	public GameObject Prefab_Fade;
	/*Esta flag controla se o usuario ja faz requisiçao para
	/*Mudança de tela
	*/
	protected bool screenIsFinished;
	protected GameObject MainCamera;
	// Use this for initialization
	protected void Start () {

		MainCamera = GameObject.Find("Main Camera");

		GameObject gb = Instantiate (Prefab_Fade) as GameObject;
		gb.transform.parent = MainCamera.transform;
		gb.transform.localPosition = new Vector3 (0,0,2);


	}
	
	// Update is called once per frame
	void Update () {

	}


	public void NextLevel(int level, bool continueMusica){

		if (!screenIsFinished) {

			GameObject gb = Instantiate (Prefab_Fade) as GameObject;
			gb.transform.parent = MainCamera.transform;
			gb.transform.localPosition = new Vector3 (0,0,2);

			gb.GetComponent<FadeIn_Screen> ().fadein = false;
			//gb.GetComponent<FadeIn_Screen> ().setContinueMusica(continueMusica);
			gb.GetComponent<FadeIn_Screen> ().level = level;
			screenIsFinished = true;
		}
	}
}
