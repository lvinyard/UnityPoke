using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePokemon : MonoBehaviour {

    public string Pname;
    public Sprite image;
    public BiomeList biomeFound;
    public PokemonType type;
    public Rarity rarity;
    public int HP;
    private int maxHP;
    public Stat AttackStat;
    public Stat DefStat;

    public PokemonStats pokemonStats;

    public bool canEvolve;
    public PokemonEvolution evolveTo;

    private int level;
    
	// Use this for initialization
	void Start () {
        maxHP = HP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddMember(BasePokemon bp)
    {
        this.Pname = bp.Pname;
        this.image = bp.image;
        this.biomeFound = bp.biomeFound;
        this.type = bp.type;
        this.rarity = bp.rarity;
        this.HP = bp.HP;
        this.maxHP = bp.maxHP;
        this.AttackStat = bp.AttackStat;
        this.DefStat = bp.DefStat;
        this.pokemonStats = bp.pokemonStats;
        this.canEvolve = bp.canEvolve;
        this.evolveTo = bp.evolveTo;
        this.level = bp.level;
    }

}

public enum Rarity
{
    VeryCommon,
    Common,
    SemiRare,
    Rare,
    VeryRare
}

public enum PokemonType
{
    Flying,
    Ground,
    Rock,
    Steel,
    Fire,
    Water,
    Grass,
    Ice,
    Electric,
    Psychic,
    Dark,
    Dragon,
    Fighting,
    Normal
}

[System.SerializableAttribute]

public class PokemonEvolution
    {
        public BasePokemon nextEvolution;
        public int levelUpLevel;
    }

[System.Serializable]

public class PokemonStats
{
    public int AttackStat;
    public int DefenseStat;
    public int SpAttackStat;
    public int spDefenseStat;
    public int EvasionStat;
}