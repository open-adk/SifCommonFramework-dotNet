﻿/*
* Copyright 2010-2011 Systemic Pty Ltd
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*    http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software distributed under the License 
* is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
* or implied.
* See the License for the specific language governing permissions and limitations under the License.
*/

using OpenADK.Library;
using OpenADK.Library.Tools.Cfg;

namespace Systemic.Sif.Framework.Subscriber
{

    /// <summary>
    /// This interface defines common methods used by the Agents of this framework.
    /// </summary>
    public interface IBaseSubscriber : ISubscriber, IQueryResults
    {

        /// <summary>
        /// The configuration information associated with the Agent for this Subscriber.
        /// </summary>
        AgentConfig AgentConfiguration { get; set; }

        /// <summary>
        /// The SIF Data Object type associated with this Subscriber.
        /// </summary>
        IElementDef SifObjectType { get; }

        /// <summary>
        /// This method is used to make requests for SIF Data Objects at regular intervals.
        /// </summary>
        /// <param name="zones">Zones to request from.</param>
        void StartRequestProcessing(IZone[] zones);

    }

}
