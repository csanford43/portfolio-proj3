using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public Material[] materials;
    public string[] propertyNames;
    public AK.Wwise.RTPC[] wwisePropertys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Material mat in materials)
        {
            mat.SetFloat(propertyNames[0], (wwisePropertys[0].GetGlobalValue() + 48f)); // low part
            mat.SetFloat(propertyNames[1], (wwisePropertys[1].GetGlobalValue() + 48f)); // mid part
            mat.SetFloat(propertyNames[2], (wwisePropertys[2].GetGlobalValue() + 48f)); // high part
        }
    }
}
