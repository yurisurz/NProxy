﻿//
// NProxy is a library for the .NET framework to create lightweight dynamic proxies.
// Copyright © Martin Tamme
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Reflection;

namespace NProxy.Core.Internal.Reflection.Emit
{
    /// <summary>
    /// Defines an invocation type factory.
    /// </summary>
    internal interface IInvocationTypeFactory
    {
        /// <summary>
        /// Creates a new invocation type for the specified method.
        /// </summary>
        /// <param name="eventInfo">The event information.</param>
        /// <param name="methodInfo">The method information.</param>
        /// <returns>The new invocation type.</returns>
        Type CreateInvocationType(EventInfo eventInfo, MethodInfo methodInfo);

        /// <summary>
        /// Creates a new invocation type for the specified method.
        /// </summary>
        /// <param name="propertyInfo">The property information.</param>
        /// <param name="methodInfo">The method information.</param>
        /// <returns>The new invocation type.</returns>
        Type CreateInvocationType(PropertyInfo propertyInfo, MethodInfo methodInfo);

        /// <summary>
        /// Creates a new invocation type for the specified method.
        /// </summary>
        /// <param name="methodInfo">The method information.</param>
        /// <returns>The new invocation type.</returns>
        Type CreateInvocationType(MethodInfo methodInfo);
    }
}