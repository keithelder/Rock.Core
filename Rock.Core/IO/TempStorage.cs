﻿using System.Collections.Generic;
using Rock.Defaults;
using Rock.Defaults.Implementation;
using Rock.KeyValueStores;

namespace Rock.IO
{
    public static class TempStorage
    {
        [UsesDefaultValue(typeof(Default), "TempStorage")]
        public static IEnumerable<IBucketItem> GetItems(string bucket)
        {
            return Default.TempStorage.GetItems(bucket);
        }

        [UsesDefaultValue(typeof(Default), "TempStorage")]
        public static void Put<T>(string bucket, string key, T value)
        {
            Default.TempStorage.Put(bucket, key, value);
        }

        [UsesDefaultValue(typeof(Default), "TempStorage")]
        public static T Get<T>(string bucket, string key)
        {
            return Default.TempStorage.Get<T>(bucket, key);
        }

        [UsesDefaultValue(typeof(Default), "TempStorage")]
        public static void Delete(string bucket, string key)
        {
            Default.TempStorage.Delete(bucket, key);
        }
    }
}