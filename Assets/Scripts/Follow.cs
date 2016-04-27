using UnityEngine;
using System.Collections;

/* Script para que la camara siga a un objeto, en este caso, al agente de busqueda */
public class Follow : MonoBehaviour {

	public GameObject agente; // El GameObject a seguir
	public Vector3 offset; // Distancia a que estara con respecto al agente
	
	void Start () 
	{
		offset = new Vector3 (0.0f, 8.25f, -7.5f); // Valor convenientemente adecuado para la camara
	}

	void LateUpdate () 
	{
		transform.position = agente.transform.position + offset; // Copia posicion del agente
	}
}
