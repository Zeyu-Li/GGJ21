﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 20;
    public HealthBarScript healthBar;
    public GameObject gameOverMenu;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) {
            TakeDamage(1);
        }
        
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        if (currentHealth == 0) {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        healthBar.SetHealth(currentHealth);
    }
}