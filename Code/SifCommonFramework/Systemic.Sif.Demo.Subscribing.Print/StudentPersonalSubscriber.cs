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

using Edustructures.SifWorks;
using Edustructures.SifWorks.Student;
using Systemic.Sif.Framework.Model;
using Systemic.Sif.Framework.Subscriber;

namespace Systemic.Sif.Demo.Subscribing.Print
{

    /// <summary>
    /// Subscriber of StudentPersonal data objects.
    /// </summary>
    public class StudentPersonalSubscriber : GenericSubscriber<StudentPersonal>
    {
        // Create a logger for use in this class.
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        int requestFrequency = 30000;

        /// <summary>
        /// This implementation will always make a request.
        /// </summary>
        /// <param name="zone">Zone the request will be made to.</param>
        /// <returns>True is a request is to be made; false otherwise.</returns>
        protected override bool MakeRequest(IZone zone)
        {
            return true;
        }

        /// <summary>
        /// This implementation will simply print the received StudentPersonal record to the console.
        /// </summary>
        /// <param name="sifEvent">SIF Event received.</param>
        /// <param name="zone">Zone the SIF Event was received from.</param>
        protected override void ProcessEvent(SifEvent<StudentPersonal> sifEvent, IZone zone)
        {
            if (log.IsDebugEnabled) log.Debug(sifEvent.SifDataObject.ToXml());
            if (log.IsDebugEnabled) log.Debug("Received a " + sifEvent.EventAction.ToString() + " event for StudentPersonal in Zone " + zone.ZoneId + ".");
        }

        /// <summary>
        /// This implementation will simply print the received StudentPersonal record to the console.
        /// </summary>
        /// <param name="sifDataObject">StudentPersonal record received</param>
        /// <param name="zone">Zone the StudentPersonal record was received from.</param>
        protected override void ProcessResponse(StudentPersonal sifDataObject, IZone zone)
        {
            if (log.IsDebugEnabled) log.Debug(sifDataObject.ToXml());
            if (log.IsDebugEnabled) log.Debug("Received a request response for StudentPersonal in Zone " + zone.ZoneId + ".");
        }

        /// <summary>
        /// This implementation will define a request frequency of 30 seconds.
        /// </summary>
        protected override int RequestFrequency
        {
            get { return requestFrequency; }
            set { requestFrequency = value; }
        }

    }

}
