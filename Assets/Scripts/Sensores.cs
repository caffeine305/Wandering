using UnityEngine;
using System.Collections;

/* Script que monitorea los alrededores y el estado del mundo a partir de la posicion y direccion
 del agente.
 */
public class Sensores : MonoBehaviour {
	
	private bool isColliding; // si esta chocando con una pared
	private bool isInGoal; // si toco la meta/objetivo por alcanzar
	public float dist; //distancia a las paredes

	public bool forward;
	public bool backward;
	public bool right;
	public bool left;

	// Inicializacion de variables
	void Start () 
	{
		isColliding = false;
		isInGoal = false;
	}

	void FixedUpdate()
	{
		
		Vector3 adelante = transform.TransformDirection (Vector3.forward);
		Vector3 atras = transform.TransformDirection (Vector3.back);
		Vector3 derecha = transform.TransformDirection (Vector3.right);
		Vector3 izquierda = transform.TransformDirection (Vector3.left);

		if (Physics.Raycast (transform.position, adelante, dist)) 
		{
			forward = true;
		}
		else
		{
			forward = false;
		}
		if (Physics.Raycast (transform.position, atras, dist)) {
			backward = true;
		} else 
		{
			backward = false;
		}
		if (Physics.Raycast (transform.position, derecha, dist)) {
			right = true;
		} else 
		{
			right = false;
		}
		if (Physics.Raycast (transform.position, izquierda, dist)) {
			left = true;
		} else 
		{
			left = false;
		}
	}


	// Verifica si el agente esta tocando/chocando con una pared
	public bool IsColliding()
	{
		return isColliding;
		// HINT: Cada pared tiene un Collider con el tag "Pared"
	}

	/* Lanza un rayo hacia adelante desde la posicion del agente para verificar si
	 * colisiona con algun objeto
	 */ 
	public bool RayCast()
	{
		return false;
	}

	// Verifica si el agente esta tocando/alcanzando el objetivo
	public bool IsInGoal()
	{
		return isInGoal;
		// HINT: El objetivo tiene habilitada la opcion "Is Trigger"
	}
}
