using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianController : CharacterController {
 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ai();
	}

    // Controla a inteligência artificial do Guardião
    void Ai()
    {
        //TODO-Procurar por alvos que estão no alcance e attacar dentro da base (Cancelar ataque caso alvo esteja fora da base)
        //TODO-Após x minutos o Guardião poderá sair da base e atacar o Guardião inimigo
        //
    }
}
