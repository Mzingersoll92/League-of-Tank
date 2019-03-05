using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

	public float CurrentHealth { get; set; }
	public float MaxHealth { get; set; }

	public Slider healthbar;

	void Start()
	{
		MaxHealth = 20f;
		//When you restart the game it will reset health
		CurrentHealth = MaxHealth;

			healthbar.value = CalculateHealth();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.X))
			DealDamage(6);
	}

	void DealDamage(float damageValue)
	{
		// Subtract the damgage dealt from the character's health
		CurrentHealth -= damageValue;
		healthbar.value = CalculateHealth();
		// If the character has 0 health it dies
		if (CurrentHealth <= 0)
			Die();
	}

	float CalculateHealth()
	{
		return CurrentHealth / MaxHealth;
	}
	void Die()
	{
		CurrentHealth = 0;
		Debug.Log("You are dead.");
	}
}
