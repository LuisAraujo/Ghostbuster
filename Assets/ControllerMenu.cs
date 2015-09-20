using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllerMenu : MonoBehaviour, IObservavel {

	private int estado;
	private List<IObservador> listaObservadores;
	private bool teclaBloqueada;


	// Use this for initialization
	void Start () {

		registrarObservador (GameObject.Find("Bt_Jogar").GetComponent<BotaoScript>());
		registrarObservador (GameObject.Find("Bt_Menu").GetComponent<BotaoScript>());
		registrarObservador (GameObject.Find("Bt_Opcoes").GetComponent<BotaoScript>());

		this.setEstado (0);
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( (Input.GetKey (KeyCode.LeftArrow)) && (getEstado () > 0) && (teclaBloqueada == false) ) {
			this.setEstado (getEstado () - 1);
			teclaBloqueada = true;
		} else if ( (Input.GetKey(KeyCode.RightArrow)) && (getEstado () < 2) && (teclaBloqueada == false)) {
			this.setEstado (getEstado () + 1);
			teclaBloqueada = true;
		}

		if( (Input.GetKeyUp (KeyCode.RightArrow)) || (Input.GetKeyUp (KeyCode.LeftArrow)) ){
			teclaBloqueada = false;
		}
	
	}


	public void setEstado (int estado){
		this.estado = estado;

		notificarObservador ();
	}
	
	public int getEstado (){
		return estado;
	}
	
	public void registrarObservador(IObservador observador){
		if(this.listaObservadores == null)
			this.listaObservadores = new List<IObservador> ();
		
		this.listaObservadores.Add (observador);
	}
	
	public void removerObservador(IObservador observador){
		this.listaObservadores.Remove (observador);	
	}
	
	public void notificarObservador(){
		foreach (IObservador obs in this.listaObservadores) {
			obs.atualizar (this);
		}
	}


}
	