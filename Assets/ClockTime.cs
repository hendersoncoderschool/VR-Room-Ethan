using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Globalization;

public class ClockTime : MonoBehaviour
{
    GameObject hourHand;
    GameObject minutehand;
    GameObject secondhand;


    // Start is called before the first frame update
    void Start()
    {
        hourHand = transform.Find("Clock_Analog_A_Hour").gameObject;
        minutehand = transform.Find("Clock_Analog_A_Minute").gameObject;
        secondhand = transform.Find("Clock_Analog_A_Second").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime moment= DateTime.Now;
        hourHand.transform.localRotation = Quaternion.Euler(moment.Hour * 30f,0f,0f);
        minutehand.transform.localRotation= Quaternion.Euler(moment.Minute*6f,0f,0f);
        secondhand.transform.localRotation=Quaternion.Euler(moment.Second*6f,0f,0f);
        
    }
}
