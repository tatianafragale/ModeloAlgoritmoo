using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class FlywaightPointer
{
    public static readonly Flywaight NormalBullet = new Flywaight()
    {
        speed = 5
    };


    public static readonly Flywaight MegaBullet = new Flywaight()
    {
        speed = 3
    };
}
