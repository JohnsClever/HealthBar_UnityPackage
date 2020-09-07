/*
This package was made by Eakrawi Chaisuriya 6/9/2020 V1.3
C# Unity2020.1.3f1
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
	[Header("Setting")]
	public Camera main_cam;
	[Tooltip("This will reduce performance. (Bad performance)")]
	public bool isAutomatic;
	[Header("Health Point Definition Components")]
	public float maxHp;
	public float hp;
	[Header("Health Color Definition Components")]
	public Gradient healthColorGradient;
	[HideInInspector]
	public Slider hpBarSlider;
	[HideInInspector]
	public Image hpBar;
	private void Awake()
	{
		if (main_cam == null)
		{
			Debug.LogWarning("\"main_cam\" variable has not been assigned.");
			main_cam = Camera.main;
		}
		else
		{
			GetComponent<Canvas>().worldCamera = main_cam;
		}
		hpBarSlider.maxValue = maxHp;
		hp = maxHp;
	}
	/// <summary>
	/// debug Hp
	/// </summary>
	public void ShowHp()
	{
		print(this.gameObject.name + " have " + hp + "Hp");
	}
	private void Update()
	{
		LookAtCamera();
		if(isAutomatic)
			UpdateHealthBarValue();
	}
	/// <summary>
	/// Update value of the healthbar to have color and value corrected
	/// </summary>
	public void UpdateHealthBarValue()
	{
		hpBarSlider.value = hp;
		hpBar.color = healthColorGradient.Evaluate(hp / maxHp);
	}
	/// <summary>
	/// make canvas look at assigned camera
	/// </summary>
	public void LookAtCamera()
	{
		transform.LookAt(transform.position + main_cam.transform.forward);
	}
	/// <summary>
	/// Change Hp to desired value
	/// </summary>
	/// <param name="hp"></param>
	public void ChangeHp(float hp)
	{
		this.hp = hp;
	}
}
