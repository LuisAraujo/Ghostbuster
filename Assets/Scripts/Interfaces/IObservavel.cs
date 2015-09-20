using UnityEngine;
using System.Collections;

//Subject 
public interface IObservavel
{

	void setEstado (int obj);
	
	int getEstado ();

	void registrarObservador(IObservador observador);

	void removerObservador(IObservador observador);

	void notificarObservador();

}

