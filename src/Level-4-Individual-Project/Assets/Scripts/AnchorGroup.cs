using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnchorGroup
{
    public string GroupName;
    public List<GameObject> AnchorModels;

    public AnchorGroup(string groupName)
    {
        GroupName = groupName;
        AnchorModels = new List<GameObject>();
    }

    public void AddModel(GameObject model)
    {
        AnchorModels.Add(model);
    }
}
