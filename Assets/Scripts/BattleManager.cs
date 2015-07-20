﻿using UnityEngine;
using System.Collections;

public class BattleManager : MonoBehaviour 
{
	public bool m_BattleTimeActive;
	public float m_BattleTime;
	public float m_PlayerTime;
	public float m_EnemyTime;
	public bool m_PlayerReady;
	public bool m_EnemyReady;
	public float m_PlayerCooldownTime = 5f;
	public float m_EnemyCooldownTime = 8f;

	public GameObject m_Player;
	public GameObject m_Enemy;

	// Use this for initialization
	void Start () 
	{
		m_BattleTimeActive = true;
		m_BattleTime = 0f;
		m_PlayerTime = 0f;
		m_EnemyTime = 0f;
		m_PlayerReady = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_BattleTimeActive)
		{
			AddTime(Time.deltaTime);
			if (m_PlayerReady)
			{
				m_BattleTimeActive = false;
				m_PlayerTime = 0f;
				m_PlayerReady = false;
				ShowPlayerMenu();
			}
			if (m_EnemyReady)
			{
				m_EnemyTime = 0f;
				m_EnemyReady = false;
				EnemyAttack();
			}
		}
	}

	private void AddTime ( float pTime )
	{
		m_BattleTime += pTime;
		m_PlayerTime += pTime;
		m_EnemyTime += pTime;

		if (m_PlayerTime >= m_PlayerCooldownTime)
		{
			m_PlayerReady = true;
		}
		if (m_EnemyTime >= m_EnemyCooldownTime)
		{
			m_EnemyReady = true;
		}
	}

	private void ShowPlayerMenu ()
	{
		print ("Menu");
	}


	private void EnemyAttack ()
	{
		print ("EnemyAttack");
	}

	public void ActivateBattleTime ()
	{
		m_BattleTimeActive = true;
		print ("BattleTime reactivated");
	}
}

