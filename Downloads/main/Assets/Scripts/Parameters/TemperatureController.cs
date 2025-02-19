using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class TemperatureController : MonoBehaviour
{
    public Slider temperatureSlider;
    public float maxTemperature;
    public static float currentTemperature;
    public Image fillSlider;
    // Start is called before the first frame update
    void Start()
    {
        currentTemperature = maxTemperature;
        fillSlider = (temperatureSlider as UnityEngine.UI.Slider).GetComponentsInChildren<UnityEngine.UI.Image>().FirstOrDefault(t => t.name == "Fill");
    }

    // Update is called once per frame
    void Update()
    {
        temperatureSlider.value = currentTemperature;
        if (currentTemperature >=50 )
            fillSlider.color = new Color(0.576f, 0.886f, 0.972f); //blue
        else if (currentTemperature < 50 && currentTemperature >= 30)
        {
            Color orangeColor = new Color();
            fillSlider.color = new Color(0.972f, 0.792f, 0.576f); //orange
        }
        else if (currentTemperature < 30)
            fillSlider.color = new Color(0.976f, 0.596f, 0.576f); //red
        
    }
}
