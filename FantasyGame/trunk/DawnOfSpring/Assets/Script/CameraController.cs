using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float velocidade_ajuste;
	float eixo_camera;
	public GameObject follower;
	public float ajuste;

	void Start ()
	{
		
	}
	

	void Update () 
	{
		Rotacionar ();
		Ajustar ();
	}

	void Rotacionar()
	{
		eixo_camera = Input.GetAxis ("Horizontal");
		gameObject.transform.Rotate (new Vector3 (0f, eixo_camera*velocidade_ajuste, 0f));
	}
	void Ajustar()
	{
		
	}
}
