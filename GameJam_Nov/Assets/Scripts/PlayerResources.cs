using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResources : MonoBehaviour
{

    public float storedFood;
    public float storedWater;
    public float batteryLevel;

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
        batteryLevel = 0;

        InitializeUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeUI()
    {

        FoodUI.value = storedFood;
        WaterUI.value = storedWater;
        BatteryUI.value = batteryLevel; 
    }

    public void AddFood(float itemValue)
    {
        storedFood += itemValue;
        FoodUI.value = storedFood / 100;
    }
    public void AddWater(float itemValue)
    {
        storedWater += itemValue;
        WaterUI.value += storedWater / 100;
    }
    public void AddBattery(float itemValue)
    {
        batteryLevel += itemValue;
        BatteryUI.value = batteryLevel / 100;
    }
}
