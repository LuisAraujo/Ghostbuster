using UnityEngine;
using System.Collections;

public class FadeIn_Screen : MonoBehaviour {

	public bool fadein;
	public int level;
	static public bool continueMusica;

	// Use this for initialization
	void Start () {
		if (fadein)
			gameObject.GetComponent<Animator> ().Play ("FadeIn_Screen");
		else
			gameObject.GetComponent<Animator> ().Play ("FadeOut_Screen");

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void LoadScreen(){

		//if (!fadein && !continueMusica) {

		//	Destroy(GameObject.Find("AudioMusica"));
						
		//}


		Application.LoadLevel (level);
	}

	//public void setContinueMusica(bool param){

	//	continueMusica =  param;
	//}



	public void DestroyThis(){
		Destroy (gameObject);
	}





}