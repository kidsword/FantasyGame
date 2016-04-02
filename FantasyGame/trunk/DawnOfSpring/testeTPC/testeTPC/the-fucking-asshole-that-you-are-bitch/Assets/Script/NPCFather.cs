using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class NPCFather : MonoBehaviour {

    public string nome_npc;
    public int idade_npc;
    public string texto_quest;

    public Text text_nome;
    public Text text_idade;
    public Text text_quest;
	
	void Start ()
    {
        SetVariaveisStart();

    }
    void SetVariaveisStart()
    {
        text_nome.enabled = false;
        text_idade.enabled = false;
        text_quest.enabled = false;
    }
    void OnTriggerEnter(Collider colisao)
    {
        print(colisao.tag);
        if (colisao.gameObject.CompareTag("Jogador"))
        {
            text_idade.text = "Anos: " + idade_npc.ToString();
            text_nome.text = "Nome: " + nome_npc.ToString();
            text_quest.text = texto_quest.ToString();
            text_nome.enabled = true;
            text_idade.enabled = true;
        }
    }

    void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Jogador"))
        {
            text_nome.enabled = false;
            text_idade.enabled = false;
            text_idade.text = null;
            text_nome.text = null;
            text_quest.text = null;
        }
    }
}
