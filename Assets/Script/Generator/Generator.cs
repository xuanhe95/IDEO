using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public partial class Generator : MonoBehaviour
{
    public int width = 36;

    public int length = 30;

    public int height = 16;
    // Start is called before the first frame update
    void Start()
    {
        //rd = new System.Random();
        GenerateMeshs();
        GenerateRules();

        LevelBuilder(width, length, height);

        //Debug.Log(levels.Count);
        // PrintRules();
        foreach (Level<GameObject, GameObject> level in levels)
        {
            //Debug.Log(level.ID);
            //PrintRules(level);
        }
        Instantiator();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiator();
        }
        if(Input.GetMouseButtonUp(1)){
            Instantiator();
        }
        
        if (Input.GetMouseButtonUp(2))
        {
            Instantiator();
        }
    }

    // IEnumerator UpdateIns()
    // {
    //     yield return new WaitForSeconds(0);
    //
    // }
}
