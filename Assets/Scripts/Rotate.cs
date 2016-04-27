using UnityEngine;
using System.Collections;

/* Script para rotar un gameObject */
public class Rotate : MonoBehaviour {
	
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); // Rota indefinidamente el objeto
	}
}
