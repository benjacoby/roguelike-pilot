﻿using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {

	public int startingHP;
	private int currentHP;

	void Awake ()
	{
		currentHP = startingHP;
	}

	public void ApplyDamage(int damage)
	{
		currentHP -= damage;
		if (currentHP <= 0)
		{
			Die();
		}
	}

	public void Die()
	{
		gameObject.SendMessage("Unregister");
		Destroy(gameObject);
	}
}