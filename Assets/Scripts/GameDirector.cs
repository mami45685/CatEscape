using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;

    public void DecreaseHp(){
        this.hpGauge.fillAmount -= 0.1f;
    }
}
