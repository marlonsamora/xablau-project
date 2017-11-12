using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    //TODO-Criar variável para que conterá o scriptable object com as informações do personagem
    //TODO-Criar variável que conterá o tipo de ataque (Melee ou Ranged)

    //Basic info
    private float hp;
    private float attackPower;
    private float attackSpeed;
    private float attackRange;
    private float walkSpeed;
    private int criticalChance;

    //Status info
    private bool isInvisible;
    private bool isDead;

    //Team info
    private bool teamIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
