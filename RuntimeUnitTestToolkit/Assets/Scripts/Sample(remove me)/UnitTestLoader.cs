﻿using UnityEngine;
using System.Collections;
using RuntimeUnitTestToolkit;

namespace SampleUnitTest
{
    public static class UnitTestLoader
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            // setup created test class to RegisterAllMethods<T>
            UnitTest.RegisterAllMethods<SampleGroup>();

            // and add other classes
        }
    }
}