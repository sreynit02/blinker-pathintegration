using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolesGenerator : MonoBehaviour
{
    public TrialController trialController;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            GameObject X = this.gameObject.transform.GetChild(i).gameObject;

            if (i == 0)
                X.transform.Rotate(new Vector3(0, 0, 0));
            else if (i == 1)
                X.transform.Rotate(new Vector3(0, 30, 0));
            else if (i == 2)
                X.transform.Rotate(new Vector3(0, 60, 0));
            else if (i == 3)
                X.transform.Rotate(new Vector3(0, 90, 0));
            else if (i == 4)
                X.transform.Rotate(new Vector3(0, 120, 0));
            else if (i == 5)
                X.transform.Rotate(new Vector3(0, 150, 0));
            else if (i == 6)
                X.transform.Rotate(new Vector3(0, 180, 0));
            else if (i == 7)
                X.transform.Rotate(new Vector3(0, 210, 0));
            else if (i == 8)
                X.transform.Rotate(new Vector3(0, 240, 0));
            else if (i == 9)
                X.transform.Rotate(new Vector3(0, 270, 0));
            else if (i == 10)
                X.transform.Rotate(new Vector3(0, 300, 0));
            else if (i == 11)
                X.transform.Rotate(new Vector3(0, 330, 0));

           
           X.transform.position += (X.transform.forward * 1.5f);
           

            X.SetActive(false);
        }

        trialController.ArrayGenerator();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

