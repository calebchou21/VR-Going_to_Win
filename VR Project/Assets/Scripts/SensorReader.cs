using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HP.Omnicept.Unity;

public class SensorReader : MonoBehaviour
{
    // Start is called before the first frame update

    private GliaBehaviour GLIA;
    void Start()
    {
        GLIA = GetComponent<GliaBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        var heartrate = GLIA.GetLastHeartRate();
        Debug.Log(heartrate);
    }
}
