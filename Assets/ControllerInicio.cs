using UnityEngine;
using System.Collections;

public class ControllerInicio : ControllerPAI {

	public GameObject logo;
	private Animator aniLogo;

	// Use this for initialization
	void Start () {
	
		aniLogo = logo.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if( aniLogo.GetCurrentAnimatorStateInfo (0).IsName("LogoGRUDE_out") ){
			GameObject.Find("ControllerCenaInicio").GetComponent<ControllerCenaInicio>().NextLevel(1, false);
		}
	}
}
