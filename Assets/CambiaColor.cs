using UnityEngine;

public class CambiaColor : MonoBehaviour
{
    public GameObject Modelo1;
    public Color color;
    public Material materialColor;

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
        Modelo1.GetComponent<Renderer>().material.color = color;
        materialColor.color = color;
    }
}
