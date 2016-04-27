using UnityEngine;
using System.Collections;

/* En este script se incluyen todas las posibles acciones que puede llevar a cabo el agente.
 * En este caso solo puede moverse hacia adelante/atras y girar a la derecha/izquierda. 
 */
public class Actuadores : MonoBehaviour {

	/* Estos valores son opcionales pero recomendables de usar: */
	public float speed = 10.0f; // Velocidad de movimiento para el agente
	public float speedRotation = 10.0f; // Velocidad de rotacion (al girar) del agente
	public float movement;


	private Rigidbody rb;


	// Usar solo en caso de requerir inicializar variables
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}




	/* Gira el agente hacia la derecha a partir de su vector de direccion (rotacion)
	 * El angulo a rotar es libre de asignar 
	 */
	public void RotateRight()
	{
		
	}

	/* Realiza la misma accion que el metodo anterior pero gira hacia la derecha */
	public void RotateLeft()
	{
		
	}

	/* Mueve al agente hacia adelante a partir de su vector de direccion (rotacion)
	 * La distancia a recorrer es libre de asignar.
	 */
	public void Forward()
	{
		
	}

	/* Realiza la misma accion que el metodo anterior pero mueve al agente hacia atras*/
	public void Reverse()
	{
		
	}
}
