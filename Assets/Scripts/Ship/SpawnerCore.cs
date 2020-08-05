﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCore : MonoBehaviour
{
    [SerializeField] private CannonController _cannon;
    [SerializeField] private CoreController _core;

    public CoreController SpawnCore()
    {
        Instantiate(_core, _cannon.transform);
        return _core;
    }
}
