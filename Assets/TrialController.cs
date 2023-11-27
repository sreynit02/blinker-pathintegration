using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using System.IO;
using UnityEngine.XR;
using TMPro;
using System.Threading;
using System;

public class TrialController : MonoBehaviour
{
    public GameObject Plane, Poles, ReturnLocator, Pole1, Pole2, Pole3, Pole4, Pole5, Pole6, Pole7, Pole8, Pole9, Pole10, Pole11, Pole12;

    // Start is called before the first frame update
    [HideInInspector]
    public GameObject[] PolesInTrials;
    public void ArrayGenerator()
    {
        PolesInTrials = new GameObject[]{ Pole9, Pole4, Pole2, Pole3, Pole6, Pole11, Pole7, Pole8, Pole5, Pole10, Pole1,
                                              Pole5, Pole2, Pole3, Pole8, Pole9, Pole4, Pole7, Pole11, Pole6, Pole1, Pole10,
                                              Pole8, Pole11, Pole5, Pole4, Pole7, Pole6, Pole9, Pole1, Pole10, Pole2, Pole3,
                                              Pole3, Pole10, Pole5, Pole6, Pole8, Pole9, Pole7, Pole2, Pole4, Pole1, Pole11,
                                              Pole1, Pole7, Pole2, Pole6, Pole4, Pole9, Pole10, Pole8, Pole3, Pole5, Pole11,
                                              Pole3, Pole4, Pole5, Pole2, Pole1, Pole6, Pole7, Pole10, Pole8, Pole9, Pole11,
                                              Pole7, Pole8, Pole2, Pole9, Pole5, Pole3, Pole4, Pole1, Pole6, Pole10, Pole11,
                                              Pole7, Pole6, Pole1, Pole3, Pole8, Pole2, Pole4, Pole11, Pole5, Pole9, Pole10,
                                              Pole4, Pole6, Pole9, Pole11, Pole8, Pole7, Pole1, Pole10, Pole2, Pole3, Pole5,
                                              Pole10, Pole4, Pole9, Pole8, Pole2, Pole7, Pole11, Pole6, Pole3, Pole5, Pole1,
                };
    }

    private void Trial_Controller()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
