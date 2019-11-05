using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private Gun startingGun;
    [SerializeField]
    private Transform gunHold;

    private Gun equippedGun;

    private void Start()
    {
        EquipGun(startingGun);
    }

    public void EquipGun(Gun gunToEquip)
    {
        if (equippedGun != null)
        {
            Destroy(equippedGun);
        }
        equippedGun = Instantiate(gunToEquip, gunHold.position, gunHold.rotation, gunHold);
    }

    public void TryShooting()
    {
        equippedGun.TryShooting();
    }
}
