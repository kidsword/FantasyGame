using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{
	public static bool isKeyboard = false;
	public static bool isPlayer1 = false;
	public static bool input_direita = false;
	public static bool input_esquerda = false;
	public static bool input_frente = false;
	public static bool input_costas = false;
	public static bool input_pulo = false;
	public static bool input_acao = false;
    public static bool input_quest = false;

	public static void Gerenciar()
	{
		if (isPlayer1) 
		{
			if (isKeyboard)
			{
				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
				{
					input_direita = true;
				} else
				{
					input_direita = false;
				}
				if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
				{
					input_esquerda = true;
				} 
				else 
				{
					input_esquerda = false;
				}
				if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
				{
					input_frente = true;
				} else {
					input_frente = false;
				}
				if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow))
				{
					input_costas = true;
				} else {
					input_costas = false;
				}
				if (Input.GetKeyDown (KeyCode.Space))
				{
					input_pulo = true;
				} else 
				{
					input_pulo = false;
				}
                if (Input.GetKey(KeyCode.E))
                {
                    input_quest = true;
                }
                else {
                    input_quest = false;
                }
            }
		}
	}
}
