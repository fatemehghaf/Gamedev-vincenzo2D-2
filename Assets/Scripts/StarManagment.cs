using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManagment : MonoBehaviour
{
    public int starnum;
    public Text stars;
    void Start()
    {
        starnum = PlayerPrefs.GetInt("StarSave1" , 0);
    }

    void Update()
    {
        stars.text = "Star: " + PlayerPrefs.GetInt("StarSave1" , 0).ToString();
    }

    public void AddStar(){
        starnum++;
        PlayerPrefs.SetInt("StarSave1" , starnum);
    }
}
