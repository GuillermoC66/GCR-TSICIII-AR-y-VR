using UnityEngine;
using UnityEngine.UI;

public class CambiaColor : MonoBehaviour
{
    public GameObject Modelo1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor_Chicken()
    {

        Color randomColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f), 
            1f                   
        );
        Modelo1.GetComponent<Renderer>().material.color = randomColor;
    }
}
