using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    [SerializeField] private float healthMax;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private float experience;
    [SerializeField] private float cash;
    [SerializeField] private float armor;

    public float HealthMax
    {
        get
        {
            return healthMax;
        }

        set
        {
            healthMax = value;
        }
    }
    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }
    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }
    public float Experience
    {
        get
        {
            return experience;
        }

        set
        {
            experience = value;
        }
    }
    public float Cash
    {
        get
        {
            return cash;
        }

        set
        {
            cash = value;
        }
    }
    public float Armor
    {
        get
        {
            return armor;
        }

        set
        {
            armor = value;
        }
    }
}
