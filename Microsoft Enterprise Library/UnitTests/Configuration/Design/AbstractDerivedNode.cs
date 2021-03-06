//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Tests 
{
    public abstract class AbstractDerivedNode : InstrumentationNode
    {
		protected AbstractDerivedNode(InstrumentationConfigurationSection instrumentationConfigurationSection)
			: base(instrumentationConfigurationSection)
        {
        }            
    }
}