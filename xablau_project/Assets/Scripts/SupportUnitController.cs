using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportUnitController : CharacterController {

    //TODO - Criar AI
    //Criar variável para conter os alvos que a unidade procurará (Guardiões, Heróis, Unidades de suporte, Todos)

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ai();
	}

    //Implementar inteligência artifical das unidades de suporte
    void Ai()
    {

        //TODO-Caminhar até spawn points e procurando inimigos
        //TODO-Ataque

    }
}
