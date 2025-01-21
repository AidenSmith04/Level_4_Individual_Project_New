using System.Collections.Generic;
using Meta.XR.BuildingBlocks;
using NUnit.Framework;
using UnityEngine;

public class ModelChanger : MonoBehaviour
{
    public GameObject spatialAnchorController;
    public List<GameObject> prefabs = new List<GameObject>();
    public List<Vector3> displacements = new List<Vector3>();
    public List<Quaternion> rotations = new List<Quaternion>();

    public void SwitchModel(int modelID)
    {
        SpatialAnchorSpawnerBuildingBlock spatialAnchorScript = spatialAnchorController.GetComponent<SpatialAnchorSpawnerBuildingBlock>();
        spatialAnchorScript.AnchorPrefab = prefabs[modelID];
        spatialAnchorScript.SetDisplacement(displacements[modelID]);
        spatialAnchorScript.SetRotationOffset(rotations[modelID]);
    }
}
