using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResources : MonoBehaviour
{

    public float storedFood;
    public float storedWater;
    public float batterylevel;

    [SerializeField]
    Slider FoodUI;
    [SerializeField]
    Slider WaterUI;
    [SerializeField]
    Slider BatteryUI;

    // Start is called before the first frame update
    void Start()
    {
        storedFood = 0;
        storedWater = 0;
        batterylevel = 1;

        InitializeUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeUI()
    {
        if (FoodUI == null) return;
        if (WaterUI == null) return;
        if (BatteryUI == null) return;

        FoodUI.value = storedFood;
        WaterUI.value = storedWater;
        BatteryUI.value = batterylevel; 
    }
}
