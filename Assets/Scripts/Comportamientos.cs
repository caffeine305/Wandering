using UnityEngine;
using System.Collections;

/* Script que hace uso de sensores y actuadores para crear estrategias de busqueda*/
public class Comportamientos : MonoBehaviour {

	// Declarar los objetos para realizar acciones y percibir el mundo
	private Actuadores actuador;
	private Sensores sensor;
	private Rigidbody rb;
	public float speed;

	private bool fwd;
	private bool bwd;
	private bool rght;
	private bool lft;

	// Inicializar (obtener referencia de) scripts
	void Start () {
		actuador = GetComponent<Actuadores> ();
		sensor = GetComponent<Sensores> ();
		rb = GetComponent<Rigidbody>();
	}
	
	/* El comportamiento del agente se declara en este metodo, que se ejecura siempre
	 * (cada frame de la simulacion) para determinar que hacer.
	 * 
	 * NOTA: Tambien es valido usar FixedUpdate() en vez de Update().
	 * La diferencia radica en que el primer metodo se recomienda para calculos gemometricos
	 * y el segundo metodo para calculos numericos.
	 */
	void FixedUpdate () {

		if (sensor.forward == true) {
			rb.velocity = new Vector3(0,0,-speed);
		}
		if (sensor.backward == true) {
			rb.velocity = new Vector3(0,0,speed);
		}
		if (sensor.right == true) {
			rb.velocity = new Vector3(-speed,0,0);
		}
		if (sensor.left == true) {
			rb.velocity = new Vector3(speed,0,0);
		}







		// Ejemplo de uso de actuadores y sensores:
		/*actuador.Forward ();
		if (sensor.RayCast ()) {
			actuador.RotateLeft();
		}*/

		// HINT: Dibuja una linea azul (de tamaño 5) al frente del agente para ubicar su direccion visualmente
		//Debug.DrawRay(transform.position, transform.forward * 5, Color.blue);
		
		// NOTA: Input.GetAxis() devuelve un numero entre -1 y 1. Es util para joysticks
		// Input.GetKey devuelve boolean. Es util para el teclado
		// NOTA: Debug.Log() permite escribir mensajes a la consola de Unity
	}

	// Es valido (y recomendable) crear metodos auxiliares que pueden ser llamados en Update():
	/*public void Regresar(){
		// Regresar al ultimo lugar explorado
	}*/
}
