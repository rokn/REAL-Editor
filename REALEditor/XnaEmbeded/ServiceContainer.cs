#region File Description
//-----------------------------------------------------------------------------
// ServiceContainer.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
// This file is under the Microsoft Permissive License provided with the file.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements

using System;
using System.Collections.Generic;

#endregion

namespace XnaEmbeded
{
    /// <summary>
    /// Container class implements the IServiceProvider interface. This is used
    /// to pass shared services between different components, for instance the
    /// ContentManager uses it to locate the IGraphicsDeviceService implementation.
    /// </summary>
    public class ServiceContainer : IServiceProvider
    {
	    readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();


        /// <summary>
        /// Adds a new service to the collection.
        /// </summary>
        public void AddService<T>(T service)
        {
            _services.Add(typeof(T), service);
        }


        /// <summary>
        /// Looks up the specified service.
        /// </summary>
        public object GetService(Type serviceType)
        {
            object service;

            _services.TryGetValue(serviceType, out service);

            return service;
        }
    }
}
