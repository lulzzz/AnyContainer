﻿// © Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace AnyContainer
{
	/// <summary>
	/// Registers types for a specific scope (Singleton, transient, etc).
	/// </summary>
    public abstract class ScopeRegistrar
    {
	    /// <summary>
	    /// Registers a type with a given implementation type.
	    /// </summary>
	    /// <typeparam name="T">The type to register.</typeparam>
	    /// <typeparam name="TImpl">The type to implement the registration.</typeparam>
		public abstract void Register<T, TImpl>()
		    where T : class
		    where TImpl : class, T;

	    /// <summary>
	    /// Registers a type with a given factory.
	    /// </summary>
	    /// <typeparam name="T">The type to register.</typeparam>
	    /// <param name="factory">The factory to create the type.</param>
		public abstract void Register<T>(Func<T> factory)
		    where T : class;

	    /// <summary>
	    /// Registers a type.
	    /// </summary>
	    /// <typeparam name="T">The type to register.</typeparam>
		public virtual void Register<T>()
		    where T : class
		{
		    this.Register<T, T>();
	    }
    }
}
