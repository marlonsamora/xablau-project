using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AttackType
{
    melle,
    ranged
}

public struct Damage
{
    public float damageValue;
}

public class CharacterController : MonoBehaviour {

    //TODO-Criar variável para que conterá o scriptable object com as informações do personagem


    //Basic info
    private float maxHp; //Total de hp
    private float currentHp; // Hp atual
    private float attackPower; //Dano base
    private float attackSpeed; //Velocidade de ataque
    private float attackRange; //Alcance do ataque
    private AttackType attackType; //Tipo de ataque
    private float walkSpeed; //Velocidade para andar
    private int criticalChance; //Chance de acerto crítico
    private float viewDistance; //Distância na qual é possível enxergar outros objetos

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

    void OnDamageReceived(Damage dmg)
    {
        
        Debug.Log("Dano recebido"+dmg.damageValue);
    }
}
