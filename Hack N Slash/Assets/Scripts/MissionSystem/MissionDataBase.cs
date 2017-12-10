using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionDataBase : ScriptableObject {
    [SerializeField]
    List<Mission> missions = new List<Mission>();

}
