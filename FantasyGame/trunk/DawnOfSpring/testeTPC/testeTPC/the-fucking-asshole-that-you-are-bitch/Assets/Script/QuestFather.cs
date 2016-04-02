using UnityEngine;
using System.Collections;

public class QuestFather : InputManager {


    public GameObject jogador;
    Movimentacao movimentacao;
    NPCFather npc_temporario;
    bool pode_ler;
    bool tentou_ler;
    bool lendo;

	void Start ()
    {
        SetarVariaveisStart();
	}
	
	
	void Update ()
    {
        Gerenciar();
        LerQuest();
	}

    void LerQuest()
    {
        if (pode_ler)
        {
            lendo = true;
        }
        if (lendo)
        {
            movimentacao.pode_mover = false;
            npc_temporario.text_idade.enabled = false;
            npc_temporario.text_nome.enabled = false;
            npc_temporario.text_quest.enabled = true;
            if (input_quest)
            {
                npc_temporario.text_idade.enabled = true;
                npc_temporario.text_nome.enabled = true;
                npc_temporario.text_quest.enabled = false;
                movimentacao.pode_mover = true;
                lendo = false;
                tentou_ler = false;
            }
        }
    }

    void SetarVariaveisStart()
    {
        pode_ler = false;
        tentou_ler = false;
        lendo = false;
        npc_temporario = null;
        movimentacao = jogador.GetComponent<Movimentacao>();
        isKeyboard = movimentacao.is_keyboard;
        isPlayer1 = movimentacao.is_player1;
    }

    void OnTriggerEnter(Collider colisao)
    {
        Debug.Log(colisao.name);
        if (colisao.gameObject.CompareTag("NPCQuest"))
        {
            npc_temporario = colisao.GetComponent<NPCFather>();
        }
    }
    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("NPCQuest"))
        {
            if (input_quest && !tentou_ler)
            {
                pode_ler = true;
                tentou_ler = true;
            }
            else
            {
                pode_ler = false;
            }
        }
    }
}
