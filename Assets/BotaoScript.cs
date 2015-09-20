using UnityEngine;
using System.Collections;

public class BotaoScript : MonoBehaviour, IObservador {

	public Sprite spriteSelect;
	public Sprite sprite;
	private bool ativo;
	public int identificador;

	// Use this for initialization
	void Start () {
		ativo = false;
		GetComponent<SpriteRenderer> ().sprite = sprite;
	}
	
	// Update is called once per frame
	void Update () {

		if ((ativo) && (GetComponent<SpriteRenderer> ().sprite != spriteSelect)) {
			GetComponent<SpriteRenderer> ().sprite = spriteSelect;
			Debug.Log ("ok "+identificador);
		} else if ((!ativo) && (GetComponent<SpriteRenderer> ().sprite != sprite)) {
			GetComponent<SpriteRenderer> ().sprite = sprite;
		}
	
	}


	public void atualizar(IObservavel obj){

		if (obj.getEstado () == this.identificador) {
			ativo = true;
		} else if(ativo == true) {
			ativo = false;
		}

	}
 
}
