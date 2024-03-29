﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoulBossHpBar : MonoBehaviour {
    private Slider sliderHpBar;//Boss血条

    private void Start()
    {
        sliderHpBar = this.GetComponentInChildren<Slider>();    
    }
    private void Update()
    {
        sliderHpBar.value = this.GetComponent<ATKAndDamage>().hp / 200;//设置血条的值
    }
}
