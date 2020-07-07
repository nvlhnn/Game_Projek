﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        BossHealth enemy = other.GetComponent<BossHealth>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}

        Debug.Log("hit " + other.name);

    }
}
