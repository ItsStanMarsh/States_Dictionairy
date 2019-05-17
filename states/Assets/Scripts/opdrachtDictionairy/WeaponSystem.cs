using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{

    enum Weapons
    {
        ShitMachineGun,
        ShitSniper,
        ShitShotgun
    }

    Dictionary<Weapons, int> weaponSystem = new Dictionary<Weapons, int>();
    Weapons currentWeapon;

    void Start()
    {
        weaponSystem.Add(Weapons.ShitMachineGun, 100);
        weaponSystem.Add(Weapons.ShitShotgun, 50);
        weaponSystem.Add(Weapons.ShitSniper, 20);
        currentWeapon = Weapons.ShitSniper;
    }

    void Update()
    {
        bool jomp = Input.GetButtonDown("Jomp");
        if (jomp)
        {
            if (weaponSystem[currentWeapon] > 0)
            {
                weaponSystem[currentWeapon] -= 1;
                print(currentWeapon + " has " + weaponSystem[currentWeapon] + " bullets left.");
            }
            else
            {
                print("Ahh shit man.....");
                print("The " + currentWeapon + " is empty.");
            }
        }
    }
}
