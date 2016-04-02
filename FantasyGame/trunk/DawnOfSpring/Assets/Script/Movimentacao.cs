using UnityEngine;
using System.Collections;

public class Movimentacao : InputManager {

	public bool is_player1;
	public bool is_keyboard;
	public float velocidade;
	public float forca_pulo;
	public bool is_pulo;
    public bool pode_mover;
	Rigidbody rb;
	BoxCollider bc;
	bool pode_pular;

	void Start ()
	{
		SetarVariaveisStart ();
	}
	

	void Update ()
	{
		Gerenciar ();
		Movimentar ();
	}

	void SetarVariaveisStart()
	{
		isPlayer1 = is_player1;
		isKeyboard = is_keyboard;
		rb = gameObject.GetComponent<Rigidbody>();
		bc = gameObject.GetComponent<BoxCollider> ();
	}

	void Movimentar()
	{
        if (pode_mover)
        {
            if (input_frente)
            {
                gameObject.transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
            }
            else if (input_costas)
            {
                gameObject.transform.Translate(Vector3.back * velocidade * Time.deltaTime);
            }
            if (input_direita)
            {
                gameObject.transform.Translate(Vector3.right * velocidade * Time.deltaTime);
            }
            else if (input_esquerda)
            {
                gameObject.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
            }
            if (input_pulo && pode_pular && is_pulo)
            {
                rb.AddForce(new Vector3(0f, forca_pulo, 0f));
            }
        }
	}

	void OnCollisionEnter(Collision colisao)
	{
		if (colisao.gameObject.CompareTag ("Chao")) {
			pode_pular = true;
		} else
		{
			pode_pular = false;
		}
	}
	void OnCollisionStay(Collision colisao)
	{
		if (colisao.gameObject.CompareTag ("Chao")) 
		{
			pode_pular = true;
		} else
		{
			pode_pular = false;
		}
	}
	void OnCollisionExit(Collision colisao)
	{
		if (colisao.gameObject.CompareTag ("Chao"))
		{
			pode_pular = false;
		}
	}

}
