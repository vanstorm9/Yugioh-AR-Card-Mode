using UnityEngine;
using System.Collections;

public class MonsterTraits : MonoBehaviour {
    public int card_ID;
    public string real_name;
    public string code_name;
    public int type;
    public int atk;
    public int def;
    public int cslot;

    void Start()
    {
        cslot = -1;        
    }
}
